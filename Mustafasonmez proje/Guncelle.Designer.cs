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
            this.label7 = new System.Windows.Forms.Label();
            this.ZamanlamaCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OdemeTb = new System.Windows.Forms.TextBox();
            this.CinsiyetCb = new System.Windows.Forms.ComboBox();
            this.YasTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdSoyadTb = new System.Windows.Forms.TextBox();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uyedatagrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Üyelik Süresi";
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
            this.ZamanlamaCb.Location = new System.Drawing.Point(191, 401);
            this.ZamanlamaCb.Name = "ZamanlamaCb";
            this.ZamanlamaCb.Size = new System.Drawing.Size(126, 24);
            this.ZamanlamaCb.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Aylık Tutar";
            // 
            // OdemeTb
            // 
            this.OdemeTb.Location = new System.Drawing.Point(191, 285);
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
            this.CinsiyetCb.Location = new System.Drawing.Point(191, 343);
            this.CinsiyetCb.Name = "CinsiyetCb";
            this.CinsiyetCb.Size = new System.Drawing.Size(126, 24);
            this.CinsiyetCb.TabIndex = 22;
            // 
            // YasTb
            // 
            this.YasTb.Location = new System.Drawing.Point(191, 227);
            this.YasTb.Name = "YasTb";
            this.YasTb.Size = new System.Drawing.Size(126, 22);
            this.YasTb.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yaş";
            // 
            // AdSoyadTb
            // 
            this.AdSoyadTb.Location = new System.Drawing.Point(191, 111);
            this.AdSoyadTb.Name = "AdSoyadTb";
            this.AdSoyadTb.Size = new System.Drawing.Size(126, 22);
            this.AdSoyadTb.TabIndex = 19;
            this.AdSoyadTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(191, 169);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(126, 22);
            this.TelefonTb.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Adı-Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Herborn", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "UYELIK GUNCELLE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyedatagrid
            // 
            this.uyedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyedatagrid.Location = new System.Drawing.Point(337, 64);
            this.uyedatagrid.Name = "uyedatagrid";
            this.uyedatagrid.RowHeadersWidth = 51;
            this.uyedatagrid.RowTemplate.Height = 24;
            this.uyedatagrid.Size = new System.Drawing.Size(694, 490);
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
            this.button2.Location = new System.Drawing.Point(12, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "GÜNECELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uyedatagrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ZamanlamaCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OdemeTb);
            this.Controls.Add(this.CinsiyetCb);
            this.Controls.Add(this.YasTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdSoyadTb);
            this.Controls.Add(this.TelefonTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Guncelle";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ZamanlamaCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OdemeTb;
        private System.Windows.Forms.ComboBox CinsiyetCb;
        private System.Windows.Forms.TextBox YasTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdSoyadTb;
        private System.Windows.Forms.TextBox TelefonTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView uyedatagrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}