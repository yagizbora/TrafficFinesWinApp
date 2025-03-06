using DotNetEnv;
using Microsoft.Data.SqlClient;
using System.Data;
using TrafficFines.Models;

namespace TrafficFines
{
    public partial class Car_Operations_Form : Form
    {
        public Car_Operations_Form()
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

                AddCarModels data = new()
                {
                    Model = textBoxModel.Text.Trim(),
                    YearOfRelease = (int)YearOfRelease.Value,
                    LicensePlate = textBoxLicansePlate.Text.Trim(),
                    InsurableValue = (decimal)InsurableValue.Value,
                    OwnerFullName = textBoxOwnerFullName.Text.Trim(),
                    OwnerPassportData = textBoxOwnerPassportData.Text.Trim()
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
                int affectedRows = response.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Car added!", "Completed!");
                }
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

        private void dataGridViewCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chooseline = dataGridViewCars.SelectedCells[0].RowIndex;
            EditDataCarModels data = new()
            {
                Carid = dataGridViewCars.Rows[chooseline].Cells[0].Value?.ToString(),
                Model = dataGridViewCars.Rows[chooseline].Cells[1].Value?.ToString(),
                YearOfRelease = (int?)dataGridViewCars.Rows[chooseline].Cells[2].Value,
                LicensePlate = dataGridViewCars.Rows[chooseline].Cells[3].Value?.ToString(),
                InsurableValue = (decimal?)dataGridViewCars.Rows[chooseline].Cells[4].Value,
                OwnerFullName = dataGridViewCars.Rows[chooseline].Cells[5].Value?.ToString(),
                OwnerPassportData = dataGridViewCars.Rows[chooseline].Cells[6].Value?.ToString()
            };
            CarIdLabel.Text = data.Carid;
            textBoxEditModel.Text = data.Model;
            EditYearOfRelease.Value = data.YearOfRelease.HasValue ? (decimal)data.YearOfRelease.Value : 0;
            EditInsurableValue.Value = data.InsurableValue.HasValue ? (decimal)data.InsurableValue.Value : 0;
            textBoxEditOwnerFullName.Text = data.OwnerFullName;
            textBoxEditOwnerPassportData.Text = data.OwnerPassportData;
            textBoxEditLicansePlate.Text = data.LicensePlate;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SendEditDataCarModels data = new()
            {
                Carid = CarIdLabel.Text.Trim(),
                Model = textBoxEditModel.Text.Trim(),
                YearOfRelease = (int?)EditYearOfRelease.Value,
                LicensePlate = textBoxEditLicansePlate.Text.Trim(),
                InsurableValue = (int?)EditInsurableValue.Value,
                OwnerFullName = textBoxEditOwnerFullName.Text.Trim(),
                OwnerPassportData = textBoxEditOwnerPassportData.Text.Trim()
            };

            if (!int.TryParse(CarIdLabel.Text, out int carId))
            {
                MessageBox.Show("Hata: Geçersiz Car ID!");
                return;
            }

            try
            {
                if (connection?.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "UPDATE Cars SET Model = @Model, YearOfRelease = @YearOfRelease, LicensePlate = @LicensePlate," +
                    " InsurableValue = @InsurableValue, OwnerFullName = @OwnerFullName, OwnerPassportData = @OwnerPassportData WHERE CarID = @id";

                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", carId);
                response.Parameters.AddWithValue("@Model", data.Model);
                response.Parameters.AddWithValue("@YearOfRelease", data.YearOfRelease ?? (object)DBNull.Value);
                response.Parameters.AddWithValue("@LicensePlate", data.LicensePlate);
                response.Parameters.AddWithValue("@OwnerFullName", data.OwnerFullName);
                response.Parameters.AddWithValue("@OwnerPassportData", data.OwnerPassportData);
                response.Parameters.AddWithValue("@InsurableValue", data.InsurableValue ?? (object)DBNull.Value);

                int rowsAffected = response.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"This Car:({data.Model}) edited!", "Completed!");
                    ShowAllCars();
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız, lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DeleteCarModels data = new()
                {
                    Carid = CarIdLabel.Text
                };

                if (data.Carid == "-" || string.IsNullOrEmpty(data.Carid))
                {
                    MessageBox.Show("Please choose car!", "Warning!");
                    return;
                }

                if (connection?.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                DialogResult result = MessageBox.Show("Are you sure? Car will deleted", "Question!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Cars WHERE CarID = @id";
                    SqlCommand response = new(query, connection);
                    response.Parameters.AddWithValue("@id", data.Carid);
                    int affectedRows = response.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Car Deleted!", "Succesfull!");
                        ShowAllCars();
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void buttonclearadddatas_Click(object sender, EventArgs e)
        {
            textBoxModel.Text = "";
            YearOfRelease.Value = DateTime.Now.Year;
            textBoxLicansePlate.Text = "";
            InsurableValue.Value = 0;
            textBoxOwnerFullName.Text = "";
            textBoxOwnerPassportData.Text = "";
            ShowAllCars();
        }
    }
}
