namespace Mustafasonmez_proje
{
    partial class Odeme
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
            this.Periyot = new System.Windows.Forms.DateTimePicker();
            this.OdemeTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OdemeDgv = new System.Windows.Forms.DataGridView();
            this.AdSoyadCb = new System.Windows.Forms.ComboBox();
            this.AraTb = new System.Windows.Forms.TextBox();
            this.Arabtn = new System.Windows.Forms.Button();
            this.Yenilebtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Periyot
            // 
            this.Periyot.CalendarFont = new System.Drawing.Font("Averta-Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Location = new System.Drawing.Point(44, 175);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(304, 30);
            this.Periyot.TabIndex = 0;
            // 
            // OdemeTb
            // 
            this.OdemeTb.Font = new System.Drawing.Font("Averta-Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdemeTb.Location = new System.Drawing.Point(44, 331);
            this.OdemeTb.Multiline = true;
            this.OdemeTb.Name = "OdemeTb";
            this.OdemeTb.Size = new System.Drawing.Size(304, 37);
            this.OdemeTb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(44, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÖDEME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdemeDgv
            // 
            this.OdemeDgv.BackgroundColor = System.Drawing.SystemColors.Info;
            this.OdemeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeDgv.GridColor = System.Drawing.Color.Crimson;
            this.OdemeDgv.Location = new System.Drawing.Point(499, 127);
            this.OdemeDgv.Name = "OdemeDgv";
            this.OdemeDgv.RowHeadersWidth = 51;
            this.OdemeDgv.RowTemplate.Height = 24;
            this.OdemeDgv.Size = new System.Drawing.Size(703, 397);
            this.OdemeDgv.TabIndex = 7;
            this.OdemeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdemeDgv_CellContentClick);
            // 
            // AdSoyadCb
            // 
            this.AdSoyadCb.FormattingEnabled = true;
            this.AdSoyadCb.Location = new System.Drawing.Point(44, 247);
            this.AdSoyadCb.Name = "AdSoyadCb";
            this.AdSoyadCb.Size = new System.Drawing.Size(304, 24);
            this.AdSoyadCb.TabIndex = 8;
            this.AdSoyadCb.SelectedIndexChanged += new System.EventHandler(this.AdSoyadCb_SelectedIndexChanged);
            // 
            // AraTb
            // 
            this.AraTb.Location = new System.Drawing.Point(516, 59);
            this.AraTb.Multiline = true;
            this.AraTb.Name = "AraTb";
            this.AraTb.Size = new System.Drawing.Size(207, 36);
            this.AraTb.TabIndex = 9;
            this.AraTb.TextChanged += new System.EventHandler(this.AraTb_TextChanged);
            // 
            // Arabtn
            // 
            this.Arabtn.BackColor = System.Drawing.Color.Crimson;
            this.Arabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Arabtn.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Arabtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Arabtn.Location = new System.Drawing.Point(729, 59);
            this.Arabtn.Name = "Arabtn";
            this.Arabtn.Size = new System.Drawing.Size(156, 36);
            this.Arabtn.TabIndex = 10;
            this.Arabtn.Text = "ARA";
            this.Arabtn.UseVisualStyleBackColor = false;
            this.Arabtn.Click += new System.EventHandler(this.Arabtn_Click);
            // 
            // Yenilebtn
            // 
            this.Yenilebtn.BackColor = System.Drawing.Color.Crimson;
            this.Yenilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenilebtn.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenilebtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Yenilebtn.Location = new System.Drawing.Point(891, 59);
            this.Yenilebtn.Name = "Yenilebtn";
            this.Yenilebtn.Size = new System.Drawing.Size(156, 36);
            this.Yenilebtn.TabIndex = 11;
            this.Yenilebtn.Text = "YENİLE";
            this.Yenilebtn.UseVisualStyleBackColor = false;
            this.Yenilebtn.Click += new System.EventHandler(this.Yenilebtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(39, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "ADI SOYADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "ÖDEME TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "TUTAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Averta-Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 52);
            this.label3.TabIndex = 37;
            this.label3.Text = "ÖDEME EKRANI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(125, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 52);
            this.button2.TabIndex = 38;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Averta-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(215, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 52);
            this.button3.TabIndex = 39;
            this.button3.Text = "TEMİZLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Yenilebtn);
            this.Controls.Add(this.Arabtn);
            this.Controls.Add(this.AraTb);
            this.Controls.Add(this.AdSoyadCb);
            this.Controls.Add(this.OdemeDgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OdemeTb);
            this.Controls.Add(this.Periyot);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Periyot;
        private System.Windows.Forms.TextBox OdemeTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OdemeDgv;
        private System.Windows.Forms.ComboBox AdSoyadCb;
        private System.Windows.Forms.TextBox AraTb;
        private System.Windows.Forms.Button Arabtn;
        private System.Windows.Forms.Button Yenilebtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}