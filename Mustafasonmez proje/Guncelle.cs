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
using System.Data.SqlClient;

namespace Mustafasonmez_proje
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90545\Documents\Salondb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyedatagrid.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;

        private void uyedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(uyedatagrid.SelectedRows[0].Cells[0].Value.ToString());

            AdSoyadTb.Text = uyedatagrid.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = uyedatagrid.SelectedRows[0].Cells[2].Value.ToString();
            CinsiyetCb.Text = uyedatagrid.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = uyedatagrid.SelectedRows[0].Cells[4].Value.ToString();
            OdemeTb.Text = uyedatagrid.SelectedRows[0].Cells[5].Value.ToString();
            ZamanlamaCb.Text = uyedatagrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Silinecek üyeyi seçmediniz.");
                
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from UyeTbl where UId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi.");
                    baglanti.Close();
                    uyeler();
                }
                catch(Exception Ex) {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 ||AdSoyadTb.Text==""||TelefonTb.Text==""||CinsiyetCb.Text==""||YasTb.Text==""||OdemeTb.Text==""||ZamanlamaCb.Text=="")
            {
                MessageBox.Show("Hatalı giriş yaptınız.");

            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update  UyeTbl set UAdSoyad='"+AdSoyadTb.Text+"',UTelefon='"+TelefonTb.Text+"',UCinsiyet='"+CinsiyetCb.Text+"',UYas='"+YasTb.Text+"',UOdeme='"+OdemeTb.Text+"',UZamanlama='"+ZamanlamaCb.Text+"' where  UId="+key+";";
                    
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi.");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
