using DotNetEnv;
using Microsoft.Data.SqlClient;
using System.Data;
using TrafficFines.Models;

namespace TrafficFines
{
    public partial class Violation_Operations_Form : Form
    {
        public Violation_Operations_Form()
        {
            InitializeComponent();
        }

        SqlConnection? connection;

        public void ShowData()
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                dataGridViewViolation.DataSource = null;
                dataGridViewViolation.Columns.Clear();

                string query = "SELECT * FROM TYPES_OF_VIOLATIONS";
                SqlCommand response = new(query, connection);
                SqlDataReader result = response.ExecuteReader();

                List<ViolationModel> violations = new List<ViolationModel>();

                while (result.Read())
                {
                    violations.Add(new ViolationModel
                    {
                        id = result["ViolationID"] != DBNull.Value ? Convert.ToInt32(result["ViolationID"]) : (int?)null,
                        ViolationType = result["ViolationType"].ToString(),
                        FineAmount = result["FineAmount"] != DBNull.Value ? Convert.ToDecimal(result["FineAmount"]) : (decimal?)null
                    });
                }

                result.Close();
                dataGridViewViolation.AutoGenerateColumns = false;
                dataGridViewViolation.DataSource = violations;

                dataGridViewViolation.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation ID",
                    DataPropertyName = "id",
                    DisplayIndex = 0
                });
                dataGridViewViolation.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation Type",
                    DataPropertyName = "ViolationType",
                    DisplayIndex = 1
                });
                dataGridViewViolation.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Fine Amount",
                    DataPropertyName = "FineAmount",
                    DisplayIndex = 2
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


        private void Violation_Operations_Form_Load(object sender, EventArgs e)
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
                ShowData();
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
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                AddViolationModel data = new()
                {
                    ViolationType = richTextBoxViolationType.Text.Trim(),
                    FineAmount = FineAmount.Value
                };

                string query = "INSERT INTO TYPES_OF_VIOLATIONS (ViolationType,FineAmount) VALUES (@ViolationType,@FineAmount)";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@ViolationType", data.ViolationType);
                response.Parameters.AddWithValue("@FineAmount", data.FineAmount);
                int? reader = response.ExecuteNonQuery();
                if (reader > 0)
                {
                    MessageBox.Show($"This ({data.ViolationType}) Violation Added ");
                    ShowData();
                }
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

        private void dataGridViewViolation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chooseline = dataGridViewViolation.SelectedCells[0].RowIndex;
            GetViolationModel data = new()
            {
                id = (int?)dataGridViewViolation.Rows[chooseline].Cells[0].Value,
                ViolationType = dataGridViewViolation.Rows[chooseline].Cells[1].Value?.ToString(),
                FineAmount = dataGridViewViolation.Rows[chooseline].Cells[2].Value != DBNull.Value ? Convert.ToDecimal(dataGridViewViolation.Rows[chooseline].Cells[2].Value) : (decimal?)null
            };
            ViolationIDLabel.Text = data.id.ToString();
            richTextBoxEditViolationType.Text = data.ViolationType;

            if (data.FineAmount.HasValue)
            {
                EditFineAmount.Value = data.FineAmount.Value;
            }
            else
            {
                EditFineAmount.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                EditViolationModel data = new()
                {
                    id = ViolationIDLabel.Text,
                    ViolationType = richTextBoxEditViolationType.Text,
                    FineAmount = EditFineAmount.Value
                };

                string query = "UPDATE TYPES_OF_VIOLATIONS SET ViolationType = @ViolationType, FineAmount = @FineAmount WHERE ViolationID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@ViolationType", data.ViolationType);
                response.Parameters.AddWithValue("@FineAmount", data.@FineAmount);
                response.Parameters.AddWithValue("@id", data.id);
                int affectedrows = response.ExecuteNonQuery();

                if (affectedrows > 0 || affectedrows == 1)
                {
                    MessageBox.Show("Violation is edited!", "Success");
                    ShowData();
                }
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

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteViolationTypeModel data = new()
            {
                Id = ViolationIDLabel.Text
            };
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                string query = "DELETE FROM TYPES_OF_VIOLATIONS WHERE ViolationID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", data.Id);
                int affectedRows = response.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Violation is deleted!", "Succesfully");
                    ShowData();

                }
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
