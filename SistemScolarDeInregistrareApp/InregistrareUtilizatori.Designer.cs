namespace SistemScolarDeInregistrareApp
{
    partial class InregistrareUtilizatori
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnResetare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnUtilizatorInregistrare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.utilizatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozitiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemScolarDataSet2 = new SistemScolarDeInregistrareApp.SistemScolarDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPozitie = new System.Windows.Forms.TextBox();
            this.txtConfirmareParola = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUtilizatoriTableAdapter = new SistemScolarDeInregistrareApp.SistemScolarDataSet2TableAdapters.tblUtilizatoriTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemScolarDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnStergere);
            this.panel1.Controls.Add(this.btnResetare);
            this.panel1.Controls.Add(this.btnActualizare);
            this.panel1.Controls.Add(this.btnUtilizatorInregistrare);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 418);
            this.panel1.TabIndex = 0;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.Location = new System.Drawing.Point(788, 325);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(189, 49);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnResetare
            // 
            this.btnResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnResetare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetare.ForeColor = System.Drawing.Color.White;
            this.btnResetare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetare.Location = new System.Drawing.Point(534, 325);
            this.btnResetare.Name = "btnResetare";
            this.btnResetare.Size = new System.Drawing.Size(189, 49);
            this.btnResetare.TabIndex = 2;
            this.btnResetare.Text = "Resetare";
            this.btnResetare.UseVisualStyleBackColor = false;
            this.btnResetare.Click += new System.EventHandler(this.btnResetare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.Color.White;
            this.btnActualizare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizare.Location = new System.Drawing.Point(280, 325);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(189, 49);
            this.btnActualizare.TabIndex = 2;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnUtilizatorInregistrare
            // 
            this.btnUtilizatorInregistrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUtilizatorInregistrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilizatorInregistrare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilizatorInregistrare.ForeColor = System.Drawing.Color.White;
            this.btnUtilizatorInregistrare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilizatorInregistrare.Location = new System.Drawing.Point(33, 325);
            this.btnUtilizatorInregistrare.Name = "btnUtilizatorInregistrare";
            this.btnUtilizatorInregistrare.Size = new System.Drawing.Size(189, 49);
            this.btnUtilizatorInregistrare.TabIndex = 2;
            this.btnUtilizatorInregistrare.Text = "Inregistrare";
            this.btnUtilizatorInregistrare.UseVisualStyleBackColor = false;
            this.btnUtilizatorInregistrare.Click += new System.EventHandler(this.btnUtilizatorInregistrare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(453, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilizatori Inregistrati";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.pozitiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUtilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // utilizatorIDDataGridViewTextBoxColumn
            // 
            this.utilizatorIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.HeaderText = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilizatorIDDataGridViewTextBoxColumn.Name = "utilizatorIDDataGridViewTextBoxColumn";
            this.utilizatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.utilizatorIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "Nume Utilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "Nume Utilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            this.numeUtilizatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pozitiaDataGridViewTextBoxColumn
            // 
            this.pozitiaDataGridViewTextBoxColumn.DataPropertyName = "Pozitia";
            this.pozitiaDataGridViewTextBoxColumn.HeaderText = "Pozitia";
            this.pozitiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pozitiaDataGridViewTextBoxColumn.Name = "pozitiaDataGridViewTextBoxColumn";
            this.pozitiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblUtilizatoriBindingSource
            // 
            this.tblUtilizatoriBindingSource.DataMember = "tblUtilizatori";
            this.tblUtilizatoriBindingSource.DataSource = this.sistemScolarDataSet2;
            // 
            // sistemScolarDataSet2
            // 
            this.sistemScolarDataSet2.DataSetName = "SistemScolarDataSet2";
            this.sistemScolarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozitie);
            this.groupBox1.Controls.Add(this.txtConfirmareParola);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.txtNumeUtilizator);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilizatori";
            // 
            // txtPozitie
            // 
            this.txtPozitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPozitie.Location = new System.Drawing.Point(169, 212);
            this.txtPozitie.Name = "txtPozitie";
            this.txtPozitie.Size = new System.Drawing.Size(211, 27);
            this.txtPozitie.TabIndex = 3;
            // 
            // txtConfirmareParola
            // 
            this.txtConfirmareParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmareParola.Location = new System.Drawing.Point(169, 157);
            this.txtConfirmareParola.Name = "txtConfirmareParola";
            this.txtConfirmareParola.Size = new System.Drawing.Size(211, 27);
            this.txtConfirmareParola.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(169, 99);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(211, 27);
            this.txtParola.TabIndex = 1;
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeUtilizator.Location = new System.Drawing.Point(169, 41);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(211, 27);
            this.txtNumeUtilizator.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pozitia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmare Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Utilizator";
            // 
            // tblUtilizatoriTableAdapter
            // 
            this.tblUtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // InregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 513);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "InregistrareUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inregistrare Utilizatori";
            this.Load += new System.EventHandler(this.InregistrareUtilizatori_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemScolarDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeUtilizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPozitie;
        private System.Windows.Forms.TextBox txtConfirmareParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnStergere;
        public System.Windows.Forms.Button btnResetare;
        public System.Windows.Forms.Button btnActualizare;
        public System.Windows.Forms.Button btnUtilizatorInregistrare;
        private SistemScolarDataSet2 sistemScolarDataSet2;
        private System.Windows.Forms.BindingSource tblUtilizatoriBindingSource;
        private SistemScolarDataSet2TableAdapters.tblUtilizatoriTableAdapter tblUtilizatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozitiaDataGridViewTextBoxColumn;
    }
}