﻿namespace SistemScolarDeInregistrareApp
{
    partial class FrmTaxa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaxa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_taxa_DataAdmiterii = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_taxa_Luna = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_taxa_prenume = new System.Windows.Forms.ComboBox();
            this.cmb_taxa_nume = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taxa_Suma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_taxa_Clasa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_taxa_Date = new System.Windows.Forms.Button();
            this.btn_taxa_Stergere = new System.Windows.Forms.Button();
            this.btn_taxa_Actualizare = new System.Windows.Forms.Button();
            this.btn_taxa_Salvare = new System.Windows.Forms.Button();
            this.btn_taxa_Adaugare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dt_taxa_DataAdmiterii);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_taxa_Luna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_taxa_prenume);
            this.groupBox1.Controls.Add(this.cmb_taxa_nume);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_taxa_Suma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_taxa_Clasa);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 356);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Personale";
            // 
            // dt_taxa_DataAdmiterii
            // 
            this.dt_taxa_DataAdmiterii.CustomFormat = "dd-MM-yyyy";
            this.dt_taxa_DataAdmiterii.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_taxa_DataAdmiterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_taxa_DataAdmiterii.Location = new System.Drawing.Point(209, 185);
            this.dt_taxa_DataAdmiterii.Name = "dt_taxa_DataAdmiterii";
            this.dt_taxa_DataAdmiterii.Size = new System.Drawing.Size(252, 28);
            this.dt_taxa_DataAdmiterii.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Luna";
            // 
            // cmb_taxa_Luna
            // 
            this.cmb_taxa_Luna.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_taxa_Luna.FormattingEnabled = true;
            this.cmb_taxa_Luna.Location = new System.Drawing.Point(209, 249);
            this.cmb_taxa_Luna.Name = "cmb_taxa_Luna";
            this.cmb_taxa_Luna.Size = new System.Drawing.Size(252, 28);
            this.cmb_taxa_Luna.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prenume";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nume";
            // 
            // cmb_taxa_prenume
            // 
            this.cmb_taxa_prenume.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_taxa_prenume.FormattingEnabled = true;
            this.cmb_taxa_prenume.Location = new System.Drawing.Point(209, 133);
            this.cmb_taxa_prenume.Name = "cmb_taxa_prenume";
            this.cmb_taxa_prenume.Size = new System.Drawing.Size(252, 28);
            this.cmb_taxa_prenume.TabIndex = 19;
            // 
            // cmb_taxa_nume
            // 
            this.cmb_taxa_nume.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_taxa_nume.FormattingEnabled = true;
            this.cmb_taxa_nume.Location = new System.Drawing.Point(209, 89);
            this.cmb_taxa_nume.Name = "cmb_taxa_nume";
            this.cmb_taxa_nume.Size = new System.Drawing.Size(252, 28);
            this.cmb_taxa_nume.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 48);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data Admiterii";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suma";
            // 
            // txt_taxa_Suma
            // 
            this.txt_taxa_Suma.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taxa_Suma.Location = new System.Drawing.Point(209, 304);
            this.txt_taxa_Suma.Multiline = true;
            this.txt_taxa_Suma.Name = "txt_taxa_Suma";
            this.txt_taxa_Suma.Size = new System.Drawing.Size(252, 30);
            this.txt_taxa_Suma.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clasa";
            // 
            // cmb_taxa_Clasa
            // 
            this.cmb_taxa_Clasa.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_taxa_Clasa.FormattingEnabled = true;
            this.cmb_taxa_Clasa.Location = new System.Drawing.Point(209, 44);
            this.cmb_taxa_Clasa.Name = "cmb_taxa_Clasa";
            this.cmb_taxa_Clasa.Size = new System.Drawing.Size(252, 28);
            this.cmb_taxa_Clasa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_taxa_Date);
            this.groupBox2.Controls.Add(this.btn_taxa_Stergere);
            this.groupBox2.Controls.Add(this.btn_taxa_Actualizare);
            this.groupBox2.Controls.Add(this.btn_taxa_Salvare);
            this.groupBox2.Controls.Add(this.btn_taxa_Adaugare);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(695, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 356);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesare";
            // 
            // btn_taxa_Date
            // 
            this.btn_taxa_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taxa_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxa_Date.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxa_Date.ForeColor = System.Drawing.Color.White;
            this.btn_taxa_Date.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxa_Date.Image")));
            this.btn_taxa_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxa_Date.Location = new System.Drawing.Point(19, 267);
            this.btn_taxa_Date.Name = "btn_taxa_Date";
            this.btn_taxa_Date.Size = new System.Drawing.Size(189, 42);
            this.btn_taxa_Date.TabIndex = 4;
            this.btn_taxa_Date.Text = "Date";
            this.btn_taxa_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taxa_Date.UseVisualStyleBackColor = false;
            this.btn_taxa_Date.Click += new System.EventHandler(this.btn_taxa_Date_Click);
            // 
            // btn_taxa_Stergere
            // 
            this.btn_taxa_Stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taxa_Stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxa_Stergere.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxa_Stergere.ForeColor = System.Drawing.Color.White;
            this.btn_taxa_Stergere.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxa_Stergere.Image")));
            this.btn_taxa_Stergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxa_Stergere.Location = new System.Drawing.Point(19, 205);
            this.btn_taxa_Stergere.Name = "btn_taxa_Stergere";
            this.btn_taxa_Stergere.Size = new System.Drawing.Size(189, 42);
            this.btn_taxa_Stergere.TabIndex = 3;
            this.btn_taxa_Stergere.Text = "Stergere";
            this.btn_taxa_Stergere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taxa_Stergere.UseVisualStyleBackColor = false;
            this.btn_taxa_Stergere.Click += new System.EventHandler(this.btn_taxa_Stergere_Click);
            // 
            // btn_taxa_Actualizare
            // 
            this.btn_taxa_Actualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taxa_Actualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxa_Actualizare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxa_Actualizare.ForeColor = System.Drawing.Color.White;
            this.btn_taxa_Actualizare.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxa_Actualizare.Image")));
            this.btn_taxa_Actualizare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxa_Actualizare.Location = new System.Drawing.Point(19, 150);
            this.btn_taxa_Actualizare.Name = "btn_taxa_Actualizare";
            this.btn_taxa_Actualizare.Size = new System.Drawing.Size(189, 42);
            this.btn_taxa_Actualizare.TabIndex = 2;
            this.btn_taxa_Actualizare.Text = "Actualizare";
            this.btn_taxa_Actualizare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taxa_Actualizare.UseVisualStyleBackColor = false;
            this.btn_taxa_Actualizare.Click += new System.EventHandler(this.btn_taxa_Actualizare_Click);
            // 
            // btn_taxa_Salvare
            // 
            this.btn_taxa_Salvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taxa_Salvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxa_Salvare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxa_Salvare.ForeColor = System.Drawing.Color.White;
            this.btn_taxa_Salvare.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxa_Salvare.Image")));
            this.btn_taxa_Salvare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxa_Salvare.Location = new System.Drawing.Point(19, 92);
            this.btn_taxa_Salvare.Name = "btn_taxa_Salvare";
            this.btn_taxa_Salvare.Size = new System.Drawing.Size(189, 42);
            this.btn_taxa_Salvare.TabIndex = 1;
            this.btn_taxa_Salvare.Text = "Salvare";
            this.btn_taxa_Salvare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taxa_Salvare.UseVisualStyleBackColor = false;
            this.btn_taxa_Salvare.Click += new System.EventHandler(this.btn_taxa_Salvare_Click);
            // 
            // btn_taxa_Adaugare
            // 
            this.btn_taxa_Adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_taxa_Adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taxa_Adaugare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taxa_Adaugare.ForeColor = System.Drawing.Color.White;
            this.btn_taxa_Adaugare.Image = ((System.Drawing.Image)(resources.GetObject("btn_taxa_Adaugare.Image")));
            this.btn_taxa_Adaugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_taxa_Adaugare.Location = new System.Drawing.Point(19, 40);
            this.btn_taxa_Adaugare.Name = "btn_taxa_Adaugare";
            this.btn_taxa_Adaugare.Size = new System.Drawing.Size(189, 42);
            this.btn_taxa_Adaugare.TabIndex = 0;
            this.btn_taxa_Adaugare.Text = "Adaugare";
            this.btn_taxa_Adaugare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_taxa_Adaugare.UseVisualStyleBackColor = false;
            this.btn_taxa_Adaugare.Click += new System.EventHandler(this.btn_taxa_Adaugare_Click);
            // 
            // FrmTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FrmTaxa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dt_taxa_DataAdmiterii;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmb_taxa_Luna;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmb_taxa_nume;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_taxa_Suma;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_taxa_Clasa;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_taxa_Date;
        public System.Windows.Forms.Button btn_taxa_Stergere;
        public System.Windows.Forms.Button btn_taxa_Actualizare;
        public System.Windows.Forms.Button btn_taxa_Salvare;
        public System.Windows.Forms.Button btn_taxa_Adaugare;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmb_taxa_prenume;
    }
}