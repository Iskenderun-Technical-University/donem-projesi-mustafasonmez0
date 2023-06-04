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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OdemeTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OdemeDgv = new System.Windows.Forms.DataGridView();
            this.AdSoyadCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Periyot
            // 
            this.Periyot.CalendarFont = new System.Drawing.Font("Averta-Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Periyot.Location = new System.Drawing.Point(55, 110);
            this.Periyot.Name = "Periyot";
            this.Periyot.Size = new System.Drawing.Size(225, 22);
            this.Periyot.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödeme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÜYE ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TUTAR";
            // 
            // OdemeTb
            // 
            this.OdemeTb.Location = new System.Drawing.Point(55, 291);
            this.OdemeTb.Name = "OdemeTb";
            this.OdemeTb.Size = new System.Drawing.Size(100, 22);
            this.OdemeTb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÖDEME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdemeDgv
            // 
            this.OdemeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdemeDgv.Location = new System.Drawing.Point(492, 52);
            this.OdemeDgv.Name = "OdemeDgv";
            this.OdemeDgv.RowHeadersWidth = 51;
            this.OdemeDgv.RowTemplate.Height = 24;
            this.OdemeDgv.Size = new System.Drawing.Size(593, 345);
            this.OdemeDgv.TabIndex = 7;
            // 
            // AdSoyadCb
            // 
            this.AdSoyadCb.FormattingEnabled = true;
            this.AdSoyadCb.Location = new System.Drawing.Point(55, 201);
            this.AdSoyadCb.Name = "AdSoyadCb";
            this.AdSoyadCb.Size = new System.Drawing.Size(100, 24);
            this.AdSoyadCb.TabIndex = 8;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 418);
            this.Controls.Add(this.AdSoyadCb);
            this.Controls.Add(this.OdemeDgv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OdemeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OdemeTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView OdemeDgv;
        private System.Windows.Forms.ComboBox AdSoyadCb;
    }
}