﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustafasonmez_proje
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uyeler uyelerigoruntule = new Uyeler();
            uyelerigoruntule.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Hide();
        }
    }
}
