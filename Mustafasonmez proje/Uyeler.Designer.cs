﻿namespace Mustafasonmez_proje
{
    partial class Uyeler
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
            this.uyedatagrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AraUyeTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Yeniletextbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uyedatagrid
            // 
            this.uyedatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyedatagrid.Location = new System.Drawing.Point(423, 2);
            this.uyedatagrid.Name = "uyedatagrid";
            this.uyedatagrid.RowHeadersWidth = 51;
            this.uyedatagrid.RowTemplate.Height = 24;
            this.uyedatagrid.Size = new System.Drawing.Size(694, 490);
            this.uyedatagrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(255, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AraUyeTextbox
            // 
            this.AraUyeTextbox.Location = new System.Drawing.Point(12, 140);
            this.AraUyeTextbox.Multiline = true;
            this.AraUyeTextbox.Name = "AraUyeTextbox";
            this.AraUyeTextbox.Size = new System.Drawing.Size(234, 34);
            this.AraUyeTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averta-Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜYE LİSTESİ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(139, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Yeniletextbox
            // 
            this.Yeniletextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yeniletextbox.Location = new System.Drawing.Point(139, 231);
            this.Yeniletextbox.Name = "Yeniletextbox";
            this.Yeniletextbox.Size = new System.Drawing.Size(149, 34);
            this.Yeniletextbox.TabIndex = 6;
            this.Yeniletextbox.Text = "YENİLE";
            this.Yeniletextbox.UseVisualStyleBackColor = true;
            this.Yeniletextbox.Click += new System.EventHandler(this.Yeniletextbox_Click);
            // 
            // Uyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 490);
            this.Controls.Add(this.Yeniletextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AraUyeTextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uyedatagrid);
            this.Name = "Uyeler";
            this.Text = "Uyeler";
            this.Load += new System.EventHandler(this.Uyeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyedatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uyedatagrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AraUyeTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Yeniletextbox;
    }
}