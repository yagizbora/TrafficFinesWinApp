using DotNetEnv;
using Microsoft.Data.SqlClient;
using System.Data;
using TrafficFines.Models;

namespace TrafficFines
{
    public partial class Payment_Fine_Form : Form
    {
        SqlConnection? connection;

        public Payment_Fine_Form()
        {
            InitializeComponent();
        }

        public void ClearAllField()
        {
            textBoxViolationFactID.Text = "";
            textBoxFineAmount.Text = "";
            textBoxReceiptNumber.Text = "";
            textBoxViolationType.Text = "";
            richTextBoxDriverFullName.Text = "";
            richTextBoxOverDueDays.Text = "";
            textBoxModel.Text = "";
            dateTimePickerViolationDate.Value = DateTime.Now;
        }
        public string? DiscountOrPenaltyReason = "";
        public void GetFine(int id)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Please write Fine number!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }
                string query = "SELECT " +
                               "F.ViolationDate, " +
                               "F.ViolationFactID, " +
                               "F.DriverFullName, " +
                               "T.FineAmount, " +
                               "F.is_paid, " +
                               "C.Model, " +
                               "T.ViolationType " +
                               "FROM FACTS_OF_VIOLATIONS F " +
                               "JOIN CARS C ON C.CarID = F.CarID " +
                               "JOIN TYPES_OF_VIOLATIONS T ON T.ViolationID = F.ViolationID " +
                               "WHERE F.ViolationFactID = @ViolationFactID;";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@ViolationFactID", id);
                SqlDataReader reader = response.ExecuteReader();
                List<PaymentModels> data = new();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Fine is not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                while (reader.Read())
                {

                    data.Add(new PaymentModels
                    {
                        ViolationDate = (DateTime)reader["ViolationDate"],
                        DriverFullName = reader["DriverFullName"].ToString(),
                        Model = reader["Model"].ToString(),
                        ViolationType = reader["ViolationType"].ToString(),
                        FineAmount = (decimal)reader["FineAmount"],
                        ViolationFactID = (int)reader["ViolationFactID"],
                        is_paid = (bool)reader["is_paid"]
                    });
                }
                reader.Close();
                foreach (var item in data)
                {
                    if (item.is_paid)
                    {
                       MessageBox.Show("This Fine this paid!");
                       return;
                    }

                    DateTime checkPaymentDate = DateTime.Now;
                    dateTimePickerViolationDate.Value = (DateTime)item.ViolationDate;
                    decimal dailyPenalty = (decimal)50.1;
                    int discountrate = 25;
                    int ViolationDateControl = (checkPaymentDate - item.ViolationDate).Days;
                    if (ViolationDateControl > 10)
                    {
                        ViolationDateControl = ViolationDateControl - 10;
                        item.FineAmount += (ViolationDateControl) * dailyPenalty;
                        richTextBoxOverDueDays.Text = $"Payment date is delayed by {ViolationDateControl} days";
                        DiscountOrPenaltyReason = $"Payment date is delayed by {ViolationDateControl} days";
                    }
                    if (ViolationDateControl < 7)
                    {
                        item.FineAmount -= item.FineAmount * discountrate / 100;
                        richTextBoxOverDueDays.Text = "Payment date is Not Delayed!. " + "\n" + $"You get {discountrate}% discount because you pay within 7 days after the fine is issued!";
                        DiscountOrPenaltyReason = $"Payment with discount because payment within 7 days after the fine is issued! ";
                    }
                    if (ViolationDateControl < 10 || ViolationDateControl <= 0)
                    {
                        richTextBoxOverDueDays.Text = "Payment date is Not Delayed!.";
                        DiscountOrPenaltyReason = "Normal Payment";
                    }

                    textBoxFineAmount.Text = item.FineAmount.ToString();
                    richTextBoxDriverFullName.Text = item.DriverFullName;
                    textBoxModel.Text = item.Model.ToString();
                    textBoxViolationType.Text = item.ViolationType;
                    textBoxViolationFactID.Text = item.ViolationFactID.ToString();
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
        private void Payment_Fine_Form_Load(object sender, EventArgs e)
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
                //Console.WriteLine(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + "\n" + (ex?.Message ?? "Bilinmeyen bir hata oluştu."));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFine((int)numericUpDownViolationFactID.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    connection?.Open();
                }

                string paymentmethodcontrol = "";

                if(radioButtonCash.Checked)
                {
                    paymentmethodcontrol = radioButtonCash.Text;
                }
                else if (radioButtonCreditCard.Checked)
                {
                    paymentmethodcontrol = radioButtonCreditCard.Text;
                }

                if(string.IsNullOrEmpty(textBoxFineAmount.Text) || numericUpDownViolationFactID.Value == 0 || string.IsNullOrEmpty(paymentmethodcontrol))
                {
                    MessageBox.Show("You cannot pay fine becuase you didn't fetch!","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }

                PaymmentFineModels data = new()
                {
                    ViolationFactID = (int)numericUpDownViolationFactID.Value,
                    is_paid = true,
                    ReceiptNumber = textBoxReceiptNumber.Text,
                    ViolationPaymentDate = DateTime.Now,
                    PaymentMethod = paymentmethodcontrol,
                    ViolationPayment = textBoxFineAmount.Text,
                    PaymentAmount = textBoxFineAmount.Text,
                    DiscountOrPenaltyReason = DiscountOrPenaltyReason?.ToString()
                };
                string query = "UPDATE FACTS_OF_VIOLATIONS SET is_paid = @is_paid,ReceiptNumber = @ReceiptNumber," +
                    "ViolationPaymentDate = @ViolationPaymentDate,PaymentMethod = @PaymentMethod,PaymentAmount = @PaymentAmount,DiscountOrPenaltyReason = @DiscountOrPenaltyReason WHERE ViolationFactID = @id";
                SqlCommand response = new(query, connection);
                response.Parameters.AddWithValue("@is_paid",data.is_paid);
                response.Parameters.AddWithValue("@PaymentAmonut", data.PaymentAmount);
                response.Parameters.AddWithValue("@ReceiptNumber",data.ReceiptNumber);
                response.Parameters.AddWithValue("@ViolationPaymentDate", data.ViolationPaymentDate);
                response.Parameters.AddWithValue("@PaymentMethod", data.PaymentMethod);
                response.Parameters.AddWithValue("@PaymentAmount", data.PaymentAmount);
                response.Parameters.AddWithValue("@DiscountOrPenaltyReason", data.DiscountOrPenaltyReason);
                response.Parameters.AddWithValue("@id",data.ViolationFactID);
                int affectedrows = response.ExecuteNonQuery();
                if(affectedrows > 0)
                {
                    MessageBox.Show("Payment is updated fine is paid!","Successfully!");
                    ClearAllField();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
