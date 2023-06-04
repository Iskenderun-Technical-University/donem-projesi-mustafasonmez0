using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Mustafasonmez_proje
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = KullaniciAdiTb.Text;
            string password = SifreTb.Text;
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\90545\\Documents\\Salondb.mdf;Integrated Security=True;Connect Timeout=30");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText="Select *from LoginTbl where kullanici_adi='"+KullaniciAdiTb.Text+"'And sifre='" + SifreTb.Text + "'";
            dr=com.ExecuteReader();
            if (dr.Read()) {
                MessageBox.Show("Giriş yapılıyor.");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
