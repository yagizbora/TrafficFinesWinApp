using DotNetEnv;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;
using TrafficFines.Models;


namespace TrafficFines
{
    public partial class Fine : Form
    {
        public Fine()
        {
            InitializeComponent();
        }
        SqlConnection? connection;

        public void cleareditallfield()
        {
            editdataid = null;
            if (EditOwnerRadioButton.Checked)
            {
                EditOwnerRadioButton.Checked = false;
            }
            if (EditProxyRadioButton.Checked)
            {
                EditProxyRadioButton.Checked = false;
            }
            richTextBoxEditDriverFullName.Text = "";
            richTextBoxEditDriverFullName.Enabled = false;
            EditViolationDate.Value = DateTime.Now;
            LabelEditFeeAmount.Text = "";
        }

        public void LoadCars()
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
                    " T.ViolationType, F.FineAmount, F.ViolationDate, F.is_paid, " +
                    " F.ViolationPaymentDate, F.PaymentAmount, F.PaymentMethod,  F.DriverFullName, F.RightOfManagement, F.DiscountOrPenaltyReason " +
                    " FROM FACTS_OF_VIOLATIONS F JOIN CARS C ON F.CarID = C.CarID JOIN TYPES_OF_VIOLATIONS T ON F.ViolationID = T.ViolationID  " +
                    " ORDER BY F.ViolationDate DESC;";


                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<FeeModels> violations = new();

                while (reader.Read())
                {
                    int isPaidIndex = reader.GetOrdinal("is_paid");

                    violations.Add(new FeeModels
                    {
                        ViolationFactID = reader["ViolationFactID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationFactID"]) : (int?)null,
                        LicensePlate = reader["LicensePlate"]?.ToString(),
                        OwnerFullName = reader["OwnerFullName"]?.ToString(),
                        ViolationType = reader["ViolationType"]?.ToString(),
                        FineAmount = reader["FineAmount"] != DBNull.Value ? Convert.ToDecimal(reader["FineAmount"]) : (decimal?)null,
                        ViolationDate = reader["ViolationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ViolationDate"]) : (DateTime?)null,
                        DriverFullName = reader["DriverFullName"]?.ToString(),
                        RightOfManagement = reader["RightOfManagement"]?.ToString(),
                        is_paid = !reader.IsDBNull(isPaidIndex) ? (bool?)Convert.ToBoolean(reader["is_paid"]) : null,
                        PaymentAmount = reader["PaymentAmount"] != DBNull.Value ? Convert.ToDecimal(reader["PaymentAmount"]) : (decimal?)null,
                        PaymentMethod = reader["PaymentMethod"]?.ToString(),
                        ViolationPaymentDate = reader["ViolationPaymentDate"] != DBNull.Value ? Convert.ToDateTime(reader["ViolationPaymentDate"]) : (DateTime?)null,
                        DiscountOrPenaltyReason = reader["DiscountOrPenaltyReason"]?.ToString()
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
                dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Is paid?",
                    DataPropertyName = "is_paid",
                    DisplayIndex = 8
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Violation Payment Date",
                    DataPropertyName = "ViolationPaymentDate",
                    DisplayIndex = 9
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Payment Method",
                    DataPropertyName = "PaymentMethod",
                    DisplayIndex = 10
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Payment Amount",
                    DataPropertyName = "PaymentAmount",
                    DisplayIndex = 11
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Discount or Penalty Reason",
                    DataPropertyName = "DiscountOrPenaltyReason",
                    DisplayIndex = 12
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.Message);
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
                        ViolationID = reader["ViolationID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationID"]) : (int?)null,
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
                MessageBox.Show("Error" + ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        public void EditLoadCarsAndViolations(int carId, int violationId)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                // İlk önce Cars verilerini alıyoruz
                string carQuery = "SELECT CarID, LicensePlate FROM CARS";
                using (SqlCommand carResponse = new(carQuery, connection))
                {
                    using (SqlDataReader carReader = carResponse.ExecuteReader())
                    {
                        List<EditCarsComboBoxModels> carData = new();

                        while (carReader.Read())
                        {
                            carData.Add(new EditCarsComboBoxModels
                            {
                                Carid = carReader["CarID"] != DBNull.Value ? Convert.ToInt32(carReader["CarID"]) : 0,
                                LicensePlate = carReader["LicensePlate"]?.ToString(),
                            });
                        }

                        // Cars verilerini comboBox'a yükleme
                        CarEditComboBox.DataSource = carData;
                        CarEditComboBox.DisplayMember = "LicensePlate";  // LicensePlate'yi gösterebiliriz
                        CarEditComboBox.ValueMember = "CarID";
                        CarEditComboBox.SelectedValue = carId;
                    }
                }

                // Cars verileri tamamlandıktan sonra Violations verilerini alıyoruz
                string violationQuery = "SELECT ViolationID, ViolationType FROM TYPES_OF_VIOLATIONS";
                using (SqlCommand violationResponse = new(violationQuery, connection))
                {
                    using (SqlDataReader violationReader = violationResponse.ExecuteReader())
                    {
                        List<EditViolationComboBoxModels> violationData = new();

                        while (violationReader.Read())
                        {
                            violationData.Add(new EditViolationComboBoxModels
                            {
                                ViolationID = violationReader["ViolationID"] != DBNull.Value ? Convert.ToInt32(violationReader["ViolationID"]) : (int?)null,
                                ViolationType = violationReader["ViolationType"]?.ToString(),
                            });
                        }

                        // Violations verilerini comboBox'a yükleme
                        comboBoxEditViolations.DataSource = violationData;
                        comboBoxEditViolations.DisplayMember = "ViolationType";
                        comboBoxEditViolations.ValueMember = "ViolationID";
                        comboBoxEditViolations.SelectedValue = violationId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine(ex.Message);
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
            richTextBoxDriverFullName.Text = "";
            if (radioButton2.Checked || radioButton1.Checked)
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
                if (richTextBoxDriverFullName.Enabled == true)
                {
                    richTextBoxDriverFullName.Enabled = false;
                }
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
                    if (data != null)
                    {
                        var result = new
                        {
                            OwnerFullName = data.ToString()
                        };
                        string json = JsonSerializer.Serialize(result);
                        //Console.WriteLine(json);
                        richTextBoxDriverFullName.Text = result.OwnerFullName;
                    }
                    else
                    {
                        if (richTextBoxDriverFullName.Enabled == true)
                        {
                            richTextBoxDriverFullName.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
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
                richTextBoxDriverFullName.Text = "";
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
                string ownerorproxycontrol = "";
                if (radioButton1.Checked)
                {
                    ownerorproxycontrol = radioButton1.Text.Trim();
                }
                else if (radioButton2.Checked)
                {
                    ownerorproxycontrol = radioButton2.Text.Trim();
                }
                if (CarComboBox.SelectedValue == null || comboBoxViolations.SelectedValue == null || string.IsNullOrEmpty(richTextBoxDriverFullName.Text)
                    || string.IsNullOrEmpty(ownerorproxycontrol))
                {
                    MessageBox.Show("All fields required", "Error!");
                    return;
                }


                decimal? fetchfineamount = 0;
                string fetchfeequery = "SELECT FineAmount AS FineAmount FROM TYPES_OF_VIOLATIONS WHERE ViolationID = @id";
                SqlCommand command = new(fetchfeequery, connection);
                command.Parameters.AddWithValue("@id", comboBoxViolations.SelectedValue);
                object resultfineamonut = command.ExecuteScalar();

                if (resultfineamonut != null)
                {
                    if (resultfineamonut == DBNull.Value)
                    {
                        MessageBox.Show("Something wrong happen try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var result = new
                    {
                        fineamount = (decimal)resultfineamonut
                    };
                    string json = JsonSerializer.Serialize(result);
                    fetchfineamount = (decimal)result.fineamount;
                }



                AddFeeModels data = new()
                {
                    Carid = (int)CarComboBox.SelectedValue,
                    ViolationID = (int)comboBoxViolations.SelectedValue,
                    DriverFullName = richTextBoxDriverFullName.Text.ToString(),
                    ViolationDate = ViolationDate.Value,
                    RightOfManagement = ownerorproxycontrol,
                    FineAmount = (decimal)fetchfineamount
                };
                string query = "INSERT INTO FACTS_OF_VIOLATIONS (CarID, ViolationID, ViolationDate, DriverFullName, RightOfManagement,FineAmount,is_paid) " +
                       "VALUES (@CarID, @ViolationID, @ViolationDate, @DriverFullName, @RightOfManagement,@FineAmount,@is_paid)";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@CarID", data.Carid);
                response.Parameters.AddWithValue("@ViolationID", data.ViolationID);
                response.Parameters.AddWithValue("@ViolationDate", data.ViolationDate);
                response.Parameters.AddWithValue("@DriverFullName", data.DriverFullName);
                response.Parameters.AddWithValue("@RightOfManagement", data.RightOfManagement);
                response.Parameters.AddWithValue("@FineAmount", data.FineAmount);
                response.Parameters.AddWithValue("@is_paid", false);
                int affectedRows = response.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Fine is created!", "Succesfull!");
                    ShowViolations();
                    LoadCars();
                    LoadViolations();
                    return;
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
        private void comboBoxViolations_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? id = comboBoxViolations.SelectedValue as int?;
            if (id == null)
            {
                return;
            }

            decimal? fetchfineamount = 0;
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string fetchfeequery = "SELECT FineAmount FROM TYPES_OF_VIOLATIONS WHERE ViolationID = @id";
                SqlCommand command = new(fetchfeequery, connection);
                command.Parameters.AddWithValue("@id", id ?? (object)DBNull.Value);

                object resultfineamount = command.ExecuteScalar();

                if (resultfineamount == DBNull.Value)
                {
                    MessageBox.Show("Something wrong happened, try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fetchfineamount = (decimal?)resultfineamount;
                Console.WriteLine($"Fine Amount: {fetchfineamount}\nComboBox ID: {id}");

                LabelFeeAmount.Text = fetchfineamount?.ToString() ?? "N/A";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int? editdataid = null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int chooseline = dataGridView1.SelectedCells[0].RowIndex;
                int? id = (int?)dataGridView1.Rows[chooseline].Cells[0].Value;
                editdataid = id;

                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string query = "SELECT F.*,T.FineAmount FROM FACTS_OF_VIOLATIONS F JOIN TYPES_OF_VIOLATIONS T ON T.ViolationID = F.ViolationID WHERE ViolationFactID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", id);

                List<GetEditData> data = [];
                using (SqlDataReader reader = response.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(new GetEditData
                        {
                            ViolationFactID = reader["ViolationFactID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationFactID"]) : (int?)null,
                            carId = reader["CarID"] != DBNull.Value ? Convert.ToInt32(reader["CarID"]) : (int?)null,
                            violationId = reader["ViolationID"] != DBNull.Value ? Convert.ToInt32(reader["ViolationID"]) : (int?)null,
                            ViolationDate = reader["ViolationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ViolationDate"]) : (DateTime?)null,
                            DriverFullName = reader["DriverFullName"]?.ToString(),
                            RightOfManagement = reader["RightOfManagement"]?.ToString(),
                            FineAmount = (decimal)(reader["FineAmount"] != DBNull.Value ? Convert.ToDecimal(reader["FineAmount"]) : (decimal?)0),
                        });

                    }
                }
                foreach (var item in data)
                {
                    EditLoadCarsAndViolations((int)item.carId, (int)item.violationId);
                    if (item.ViolationDate.HasValue)
                    {
                        EditViolationDate.Value = item.ViolationDate.Value;
                    }
                    else
                    {
                        EditViolationDate.Value = DateTime.Now;
                    }
                    richTextBoxEditDriverFullName.Text = item.DriverFullName?.ToString();
                    if (item.RightOfManagement == "Owner")
                    {
                        EditOwnerRadioButton.Checked = true;
                        richTextBoxEditDriverFullName.Enabled = false;
                    }
                    else if (item.RightOfManagement == "Proxy")
                    {
                        EditProxyRadioButton.Checked = true;
                        richTextBoxEditDriverFullName.Enabled = true;
                        richTextBoxDriverFullName.Text = item.DriverFullName;
                        LabelEditFeeAmount.Text = item.FineAmount.ToString();
                    }
                    LabelEditFeeAmount.Text = item.FineAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
                Console.WriteLine("SQL StackTrace: " + ex.StackTrace);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (editdataid == null)
            {
                MessageBox.Show("Please Choose Fine", "Warning!");
                return;
            }
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                string ownerorproxycontrol = "";
                if (EditOwnerRadioButton.Checked)
                {
                    ownerorproxycontrol = EditOwnerRadioButton.Text.Trim();
                }
                else if (EditProxyRadioButton.Checked)
                {
                    ownerorproxycontrol = EditProxyRadioButton.Text.Trim();
                }


                decimal? fetchfineamount = 0;
                string fetchfeequery = "SELECT FineAmount AS FineAmount FROM TYPES_OF_VIOLATIONS WHERE ViolationID = @id";
                SqlCommand command = new(fetchfeequery, connection);
                command.Parameters.AddWithValue("@id", comboBoxEditViolations.SelectedValue);
                object resultfineamonut = command.ExecuteScalar();

                if (resultfineamonut != null)
                {
                    if (resultfineamonut == DBNull.Value)
                    {
                        MessageBox.Show("Something wrong happen try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var result = new
                    {
                        fineamount = (decimal)resultfineamonut
                    };
                    string json = JsonSerializer.Serialize(result);
                    fetchfineamount = (decimal)result.fineamount;
                }



                EditFeeModels data = new()
                {
                    ViolationFactID = editdataid,
                    Carid = (int)CarEditComboBox.SelectedValue,
                    ViolationID = (int)comboBoxEditViolations.SelectedValue,
                    DriverFullName = richTextBoxEditDriverFullName.Text.ToString(),
                    ViolationDate = EditViolationDate.Value,
                    RightOfManagement = ownerorproxycontrol,
                    FineAmount = (decimal)fetchfineamount
                };

                string query = "UPDATE FACTS_OF_VIOLATIONS SET CarID = @carid," +
                    "ViolationID = @ViolationID, ViolationDate = @violationdate," +
                    "DriverFullname = @DriverFullname," +
                    "RightOfManagement = @RightOfManagement," +
                    "FineAmount = @FineAmount" +
                    "WHERE ViolationFactId= @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", data.ViolationFactID);
                response.Parameters.AddWithValue("@carid", data.Carid);
                response.Parameters.AddWithValue("@ViolationID", data.ViolationID);
                response.Parameters.AddWithValue("@ViolationDate", data.ViolationDate);
                response.Parameters.AddWithValue("@DriverFullName", data.DriverFullName);
                response.Parameters.AddWithValue("@RightOfManagement", data.RightOfManagement);
                response.Parameters.AddWithValue("@FineAmount", data.FineAmount);
                int affectedRows = response.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Fine is edited!", "Succesfull!");
                    ShowViolations();
                    LoadCars();
                    LoadViolations();
                    cleareditallfield();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine("SQL StackTrace: " + ex.StackTrace);

            }
            finally
            {
                connection?.Close();
            }
        }
        private void comboBoxEditViolations_SelectedIndexChanged(object sender, EventArgs e)
        {

            int? id = comboBoxEditViolations.SelectedValue as int?;
            if (id == null)
            {
                return;
            }

            decimal? fetchfineamount = 0;
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string fetchfeequery = "SELECT FineAmount FROM TYPES_OF_VIOLATIONS WHERE ViolationID = @id";
                SqlCommand command = new(fetchfeequery, connection);
                command.Parameters.AddWithValue("@id", id ?? (object)DBNull.Value);

                object resultfineamount = command.ExecuteScalar();

                if (resultfineamount == DBNull.Value)
                {
                    MessageBox.Show("Something wrong happened, try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fetchfineamount = (decimal?)resultfineamount;
                //Console.WriteLine($"Fine Amount: {fetchfineamount}\nComboBox ID: {id}");

                LabelEditFeeAmount.Text = fetchfineamount?.ToString() ?? "N/A";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void CarEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxEditDriverFullName.Text = "";
            if (EditProxyRadioButton.Checked || EditOwnerRadioButton.Checked)
            {
                EditOwnerRadioButton.Checked = false;
                EditProxyRadioButton.Checked = false;
                if (richTextBoxEditDriverFullName.Enabled == true)
                {
                    richTextBoxEditDriverFullName.Enabled = false;
                }
            }
        }

        private void EditOwnerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton? rb = sender as RadioButton;
            //if (rb != null && rb.Checked)
            //{
            //    MessageBox.Show("Seçilen: " + rb.Text);
            //}
            if (EditOwnerRadioButton.Checked)
            {
                if (richTextBoxEditDriverFullName.Enabled == true)
                {
                    richTextBoxEditDriverFullName.Enabled = false;
                }
                try
                {
                    int? carid = (int?)CarEditComboBox.SelectedValue;

                    if (carid == null)
                    {
                        //pass
                        return;
                    }

                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection?.Open();
                    }
                    //richTextBoxDriverFullName
                    //Console.WriteLine(carid);

                    string query = "SELECT OwnerFullName FROM CARS WHERE CarID = @id";
                    SqlCommand response = new(query, connection);
                    response.Parameters.AddWithValue("@id", carid);
                    object data = response.ExecuteScalar();
                    //Console.WriteLine(data);
                    if (data != null)
                    {
                        var result = new
                        {
                            OwnerFullName = data.ToString()
                        };
                        string json = JsonSerializer.Serialize(result);
                        //Console.WriteLine(json);
                        richTextBoxEditDriverFullName.Text = result.OwnerFullName;
                    }
                    else
                    {
                        if (richTextBoxEditDriverFullName.Enabled == true)
                        {
                            richTextBoxEditDriverFullName.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection?.Close();
                }
            }
            else if (EditProxyRadioButton.Checked)
            {
                richTextBoxEditDriverFullName.Enabled = true;
                if (!string.IsNullOrEmpty(richTextBoxDriverFullName.Text))
                {
                    richTextBoxEditDriverFullName.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                if (editdataid == null)
                {
                    MessageBox.Show("Choose Fine! ", "Error!");
                    return;
                }

                string query = "DELETE FROM FACTS_OF_VIOLATIONS WHERE ViolationFactID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@id", editdataid);
                int affectedrows = response.ExecuteNonQuery();
                if (affectedrows > 0)
                {
                    MessageBox.Show($"Fine data is succesfully deleted \n " +
                        $"{affectedrows} data was deleted"
                        , "Success!");
                    ShowViolations();
                    LoadCars();
                    LoadViolations();
                    cleareditallfield();
                    return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }
    }
}