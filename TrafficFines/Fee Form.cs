﻿using System.Data;
using System.Text.Json;
using DotNetEnv;
using Microsoft.Data.SqlClient;
using TrafficFines.Models;


namespace TrafficFines
{
    public partial class Fee : Form
    {
        public Fee()
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

                List<CarsComboBoxModels> data = new();
                while (reader.Read())
                {
                    data.Add(new CarsComboBoxModels
                    {
                        Carid = reader["CarID"] != DBNull.Value ? Convert.ToInt32(reader["CarID"]) : 0,
                        LicensePlate = reader["LicensePlate"]?.ToString(),
                    });
                }
                reader.Close();

                CarComboBox.DataSource = data;
                CarComboBox.DisplayMember = "LicensePlate";
                CarComboBox.ValueMember = "Carid";
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
        private void LoadViolations()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "SELECT ViolationID, ViolationType FROM TYPES_OF_VIOLATIONS";
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<ViolationComboBoxModels> data = new();
                while (reader.Read())
                {
                    data.Add(new ViolationComboBoxModels
                    {
                        ViolationID = reader["ViolationID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationID"]) : 0,
                        ViolationType = reader["ViolationType"]?.ToString(),
                    });
                }
                reader.Close();

                comboBoxViolations.DataSource = data;
                comboBoxViolations.DisplayMember = "ViolationType";
                comboBoxViolations.ValueMember = "ViolationID";
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
            LoadViolations();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowViolations();
            LoadCars();
            LoadViolations();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {

            }
        }
        private void CarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(radioButton2.Checked || radioButton1.Checked) 
           {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                if (richTextBoxDriverFullName.Enabled == true)
                {
                    richTextBoxDriverFullName.Enabled = false;
                }
            
           }
        }
        private void radiobutton_checkedchanged(object sender, EventArgs e)
        {
            RadioButton? rb = sender as RadioButton;
            //if (rb != null && rb.Checked)
            //{
            //    MessageBox.Show("Seçilen: " + rb.Text);
            //}
            if (radioButton1.Checked)
            {
                try
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }
                    //richTextBoxDriverFullName
                    //Console.WriteLine(carid);
                    int? carid = (int?)CarComboBox.SelectedValue;

                    string query = "SELECT OwnerFullName FROM CARS WHERE CarID = @id";
                    SqlCommand response = new(query, connection);
                    response.Parameters.AddWithValue("@id", carid);
                    object data = response.ExecuteScalar();
                    //Console.WriteLine(data);
                    if(data != null)
                    {
                        var result = new { OwnerFullName = data.ToString() };
                        string json = JsonSerializer.Serialize(result);
                        //Console.WriteLine(json);
                        richTextBoxDriverFullName.Text = result.OwnerFullName;
                    }
                    else
                    {
                        //pass 

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection?.Close();
                }
            }
            else if (radioButton2.Checked)
            {
                richTextBoxDriverFullName.Enabled = true;
            }
        }


    }
}
