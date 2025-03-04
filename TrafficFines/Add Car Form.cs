using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;
using Microsoft.Data.SqlClient;
using Sprache;
using TrafficFines.Models;

namespace TrafficFines
{
    public partial class Add_Car_Form : Form
    {
        public Add_Car_Form()
        {
            InitializeComponent();
        }
        SqlConnection? connection;

        private void ShowAllCars()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                dataGridViewCars.DataSource = null;
                dataGridViewCars.Columns.Clear();

                string query = "SELECT CarID, Model, YearOfRelease, LicensePlate, InsurableValue, OwnerFullName, OwnerPassportData FROM CARS";
                SqlCommand command = new(query, connection);
                SqlDataReader result = command.ExecuteReader();

                List<CarModels> carList = [];

                while (result.Read())
                {
                    carList.Add(new CarModels
                    {
                        Carid = result["CarID"] != DBNull.Value ? Convert.ToInt32(result["CarID"]) : (int?)null,
                        Model = result["Model"].ToString(),
                        YearOfRelease = result["YearOfRelease"] != DBNull.Value ? Convert.ToInt32(result["YearOfRelease"]) : (int?)null,
                        LicensePlate = result["LicensePlate"].ToString(),
                        InsurableValue = result["InsurableValue"] != DBNull.Value ? Convert.ToDecimal(result["InsurableValue"]) : (decimal?)null,
                        OwnerFullName = result["OwnerFullName"].ToString(),
                        OwnerPassportData = result["OwnerPassportData"].ToString()
                    });
                }

                result.Close();
                dataGridViewCars.AutoGenerateColumns = false;
                dataGridViewCars.DataSource = carList;

                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Car ID",
                    DataPropertyName = "Carid",
                    DisplayIndex = 0
                });
                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Model",
                    DataPropertyName = "Model",
                    DisplayIndex = 1
                });

                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Year Of Release",
                    DataPropertyName = "YearOfRelease",
                    DisplayIndex = 2
                });

                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "LicensePlate",
                    DataPropertyName = "LicensePlate",
                    DisplayIndex = 3
                });
                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Insurable Value",
                    DataPropertyName = "InsurableValue",
                    DisplayIndex = 4
                });
                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Owner Full Name",
                    DataPropertyName = "OwnerFullName",
                    DisplayIndex = 5
                });
                dataGridViewCars.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Owner Passport Data",
                    DataPropertyName = "OwnerPassportData",
                    DisplayIndex = 6
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


        private void Add_Car_Form_Load(object sender, EventArgs e)
        {
            try
            {
                Env.Load();
                string connectionString = Env.GetString("DB_CONNECTION_STRING");

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Bağlantı dizesi null veya boş. Lütfen .env dosyasını kontrol edin.");
                    return;
                }

                connection = new SqlConnection(connectionString);
                ShowAllCars();
                //Console.WriteLine(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection?.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                AddCarModels data = new AddCarModels
                {
                    Model = textBoxModel.Text,
                    YearOfRelease = (int)YearOfRelease.Value,
                    LicensePlate = textBoxLicansePlate.Text,
                    InsurableValue = (decimal)InsurableValue.Value,
                    OwnerFullName = textBoxOwnerFullName.Text,
                    OwnerPassportData = textBoxOwnerPassportData.Text
                };

                string query = "INSERT INTO Cars (Model, YearOfRelease, LicensePlate, InsurableValue, OwnerFullName, OwnerPassportData)" +
                    " VALUES(@Model,@YearOfRelease,@LicensePlate,@InsurableValue,@OwnerFullName,@OwnerPassportData)";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@Model", data.Model);
                response.Parameters.AddWithValue("@YearOfRelease", data.YearOfRelease);
                response.Parameters.AddWithValue("@InsurableValue", data.InsurableValue);
                response.Parameters.AddWithValue("@LicensePlate", data.LicensePlate);
                response.Parameters.AddWithValue("@OwnerFullName", data.OwnerFullName);
                response.Parameters.AddWithValue("@OwnerPassportData", data.OwnerPassportData);
                response.ExecuteNonQuery();
                ShowAllCars();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}
