using DotNetEnv;
using Microsoft.Data.SqlClient;


namespace TrafficFines
{
    public partial class Entry_Screen : Form
    {
        public Entry_Screen()
        {
            InitializeComponent();
        }
        SqlConnection? connection;

        Car_Operations_Form? addcarform;

        Violation_Operations_Form? violationform;
        Payment_Fine_Form? paymentform;

        Fine? feeforms;

        private void Form1_Load(object sender, EventArgs e)
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
            addcarform = new Car_Operations_Form();
            addcarform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            violationform = new Violation_Operations_Form();
            violationform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            feeforms = new Fine();
            feeforms?.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paymentform = new Payment_Fine_Form();
            paymentform?.Show();
        }
    }
}
