using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mustafasonmez_proje
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90545\Documents\SalonDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text == ""||TelefonTb.Text==""||OdemeTb.Text==""||YasTb.Text=="")
            {
                MessageBox.Show("Hatalı bilgi girişi yaptınız.");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert info UyeTbl values ('" + AdSoyadTb.Text + "','" + TelefonTb.Text + "','" + CinsiyetCb.SelectedItem.ToString() + "','" + YasTb.Text + "','" + OdemeTb.Text + "','" + ZamanlamaCb.SelectedItem.ToString() + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Başarıyla eklendi.");
                    baglanti.Close();
                }catch(Exception Ex)
                {
                    MessageBox.Show("Ex.Massage");
                }
            }
        }
    }
}
