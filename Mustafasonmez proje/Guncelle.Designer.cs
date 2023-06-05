namespace Mustafasonmez_proje
{
    partial class Guncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZamanlamaCb = new System.Windows.Forms.ComboBox();
            this.OdemeTb = new System.Windows.Forms.TextBox();
            this.CinsiyetCb = new System.Windows.Forms.ComboBox();
            this.YasTb = new System.Windows.Forms.TextBox();
            this.AdSoyadTb = new System.Windows.Forms.TextBox();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uyedatagrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ZamanlamaCb
            // 
            this.ZamanlamaCb.FormattingEnabled = true;
            this.ZamanlamaCb.Items.AddRange(new object[] {
            "1 AY",
            "2 AY",
            "3 AY",
            "4 AY",
            "5 AY",
            "6 AY",
            "7 AY",
            "8 AY",
            "9 AY",
            "10 AY",
            "11 AY",
            "12 AY",
            "SINIRSIZ"});
            this.ZamanlamaCb.Location = new System.Drawing.Point(448, 197);
            this.ZamanlamaCb.Name = "ZamanlamaCb";
            this.ZamanlamaCb.Size = new System.Drawing.Size(126, 24);
            this.ZamanlamaCb.TabIndex = 26;
            // 
            // OdemeTb
            // 
            this.OdemeTb.Location = new System.Drawing.Point(259, 197);
            this.OdemeTb.Name = "OdemeTb";
            this.OdemeTb.Size = new System.Drawing.Size(126, 22);
            this.OdemeTb.TabIndex = 23;
            // 
            // CinsiyetCb
            // 
            this.CinsiyetCb.FormattingEnabled = true;
            this.CinsiyetCb.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.CinsiyetCb.Location = new System.Drawing.Point(448, 114);
            this.CinsiyetCb.Name = "CinsiyetCb";
            this.CinsiyetCb.Size = new System.Drawing.Size(126, 24);
            this.CinsiyetCb.TabIndex = 22;
            // 
            // YasTb
            // 
            this.YasTb.Location = new System.Drawing.Point(259, 114);
            this.YasTb.Name = "YasTb";
            this.YasTb.Size = new System.Drawing.Size(126, 22);
            this.YasTb.TabIndex = 21;
            // 
            // AdSoyadTb
            // 
            this.AdSoyadTb.Location = new System.Drawing.Point(27, 114);
            this.AdSoyadTb.Name = "AdSoyadTb";
            this.AdSoyadTb.Size = new System.Drawing.Size(126, 22);
            this.AdSoyadTb.TabIndex = 19;
            this.AdSoyadTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(30, 197);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(126, 22);
            this.TelefonTb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Herborn", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "UYELIK GUNCELLE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(825, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyedatagrid
            // 
            this.uyedatagrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.uyedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyedatagrid.ColumnHeadersVisible = false;
            this.uyedatagrid.GridColor = System.Drawing.Color.Crimson;
            this.uyedatagrid.Location = new System.Drawing.Point(30, 240);
            this.uyedatagrid.Name = "uyedatagrid";
            this.uyedatagrid.RowHeadersWidth = 51;
            this.uyedatagrid.RowTemplate.Height = 24;
            this.uyedatagrid.Size = new System.Drawing.Size(996, 303);
            this.uyedatagrid.TabIndex = 30;
            this.uyedatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uyedatagrid_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(467, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(503, 38);
            this.label8.TabIndex = 31;
            this.label8.Text = "Silinecek üyeye tıklayınız.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(657, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "GÜNECELLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 26);
            this.label12.TabIndex = 38;
            this.label12.Text = "TELEFON";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(254, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 26);
            this.label11.TabIndex = 37;
            this.label11.Text = "YAŞ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(254, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "AYLIK TUTAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(443, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 26);
            this.label9.TabIndex = 35;
            this.label9.Text = "CİNSİYET";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(443, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 26);
            this.label13.TabIndex = 34;
            this.label13.Text = "ÜYELİK SÜRESİ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(25, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 26);
            this.label14.TabIndex = 33;
            this.label14.Text = "ADI SOYADI";
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 656);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uyedatagrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZamanlamaCb);
            this.Controls.Add(this.OdemeTb);
            this.Controls.Add(this.CinsiyetCb);
            this.Controls.Add(this.YasTb);
            this.Controls.Add(this.AdSoyadTb);
            this.Controls.Add(this.TelefonTb);
            this.Controls.Add(this.label1);
            this.Name = "Guncelle";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ZamanlamaCb;
        private System.Windows.Forms.TextBox OdemeTb;
        private System.Windows.Forms.ComboBox CinsiyetCb;
        private System.Windows.Forms.TextBox YasTb;
        private System.Windows.Forms.TextBox AdSoyadTb;
        private System.Windows.Forms.TextBox TelefonTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView uyedatagrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}