using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginPage
{
    public partial class telefon_no : Form
    {
        SqlConnection sconn;
        SqlDataReader dr;
        SqlCommand com;

        public telefon_no()
        {
            InitializeComponent();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            sconn = new SqlConnection(@"Data Source=""HILAL\SQLEXPRESS"";Initial Catalog=loginpage;Integrated Security=True");
            com = new SqlCommand();
            sconn.Open();
            com.Connection = sconn;
            com.CommandText = "Select*From loginpage where kullanici_adi = '" + textBox1.Text + "' And sevdigi_renk = '" + textBox2.Text + "'";
            dr = com.ExecuteReader();



            if (dr.Read())
            {
                label3.Visible = true;
                label3.Text = dr["sifre"].ToString();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                label3.Visible = false;

                MessageBox.Show("Kullanıcı Adı  hatalı!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            dr.Close();
        }

    }
}

