﻿using System.Data;
using System.Diagnostics;
using System.Timers;
using DotNetEnv;
using Microsoft.Data.SqlClient;
using TrafficFines.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace TrafficFines
{
    public partial class Violations : Form
    {
        public Violations()
        {
            InitializeComponent();
        }
        SqlConnection? connection;
        private void LoadCars()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "SELECT CarID, LicensePlate FROM CARS";
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                Dictionary<int, string> cars = new();
                while (reader.Read())
                {
                    cars[Convert.ToInt32(reader["CarID"])] = reader["LicensePlate"].ToString();
                }
                reader.Close();

                CarComboBox.DataSource = new BindingSource(cars, null);
                CarComboBox.DisplayMember = "Value"; 
                CarComboBox.ValueMember = "Key"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void ShowViolations()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "SELECT F.ViolationFactID, C.LicensePlate, C.OwnerFullName, " +
                               "T.ViolationType, T.FineAmount, F.ViolationDate, " +
                               "F.DriverFullName, F.RightOfManagement " +
                               "FROM FACTS_OF_VIOLATIONS F " +
                               "JOIN CARS C ON F.CarID = C.CarID " +
                               "JOIN TYPES_OF_VIOLATIONS T ON F.ViolationID = T.ViolationID " +
                               "ORDER BY F.ViolationDate DESC;";

                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<FeeModels> violations = new();

                while (reader.Read())
                {
                    violations.Add(new FeeModels
                    {
                        ViolationFactID = reader["ViolationFactID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationFactID"]) : (int?)null,
                        LicensePlate = reader["LicensePlate"]?.ToString(),
                        OwnerFullName = reader["OwnerFullName"]?.ToString(),
                        ViolationType = reader["ViolationType"]?.ToString(),
                        FineAmount = reader["FineAmount"] != DBNull.Value ? Convert.ToDecimal(reader["FineAmount"]) : (decimal?)null,
                        ViolationDate = reader["ViolationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ViolationDate"]) : (DateTime?)null,
                        DriverFullName = reader["DriverFullName"]?.ToString(),
                        RightOfManagement = reader["RightOfManagement"]?.ToString()
                    });
                }

                reader.Close();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = violations;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation ID",
                    DataPropertyName = "ViolationFactID",
                    DisplayIndex = 0
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Car License Plate",
                    DataPropertyName = "LicensePlate",
                    DisplayIndex = 1
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Owner Name",
                    DataPropertyName = "OwnerFullName",
                    DisplayIndex = 2
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation Type",
                    DataPropertyName = "ViolationType",
                    DisplayIndex = 3
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fine Amount",
                    DataPropertyName = "FineAmount",
                    DisplayIndex = 4
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation Date",
                    DataPropertyName = "ViolationDate",
                    DisplayIndex = 5
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Driver Name",
                    DataPropertyName = "DriverFullName",
                    DisplayIndex = 6
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Right of Management",
                    DataPropertyName = "RightOfManagement",
                    DisplayIndex = 7
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }


        private void Violations_Load(object sender, EventArgs e)
        {
            Env.Load();
            string connectionString = Env.GetString("DB_CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Bağlantı dizesi null veya boş. Lütfen .env dosyasını kontrol edin.");
                return;
            }

            connection = new SqlConnection(connectionString);


            ShowViolations();
            LoadCars();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowViolations();
            LoadCars();
        }

    }
}
