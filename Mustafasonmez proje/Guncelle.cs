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
        private void uyedatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uyedatagrid.CellClick += uyedatagrid_CellContentClick;

            AdSoyadTb.Text = uyedatagrid.SelectedRows[0].Cells[1].Value.ToString();
            TelefonTb.Text = uyedatagrid.SelectedRows[0].Cells[2].Value.ToString();
            CinsiyetCb.Text = uyedatagrid.SelectedRows[0].Cells[3].Value.ToString();
            YasTb.Text = uyedatagrid.SelectedRows[0].Cells[4].Value.ToString();
            OdemeTb.Text = uyedatagrid.SelectedRows[0].Cells[5].Value.ToString();
            ZamanlamaCb.Text = uyedatagrid.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
