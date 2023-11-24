

using System.Data.Sql;
using System.Data.SqlClient;


namespace LoginPage
{
    public partial class Form1 : Form
    {
        SqlConnection sconn;
        SqlDataReader dr;
        SqlCommand com;



        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String K_adi = textBox1.Text;
            String sifre = textBox2.Text;

            sconn = new SqlConnection(@"Data Source=""HILAL\SQLEXPRESS"";Initial Catalog=loginpage;Integrated Security=True");
            com = new SqlCommand();
            sconn.Open();
            com.Connection = sconn;
            com.CommandText = "Select*From loginpage where kullanici_adi = '" + textBox1.Text + "' And sifre = '" + textBox2.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Giriþ Baþarýlý");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Kullanýcý Adý veya Þifre hatalý!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telefon_no telefon_No = new telefon_no();

            telefon_No.Show();







        }
    }
}