namespace SistemScolarDeInregistrareApp
{
    partial class FrmAfisareDateElevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfisareDateElevi));
            this.GDAfisareElevi = new System.Windows.Forms.DataGridView();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excel_DateElevi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareElevi)).BeginInit();
            this.SuspendLayout();
            // 
            // GDAfisareElevi
            // 
            this.GDAfisareElevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDAfisareElevi.Location = new System.Drawing.Point(34, 164);
            this.GDAfisareElevi.Name = "GDAfisareElevi";
            this.GDAfisareElevi.RowHeadersWidth = 51;
            this.GDAfisareElevi.RowTemplate.Height = 24;
            this.GDAfisareElevi.Size = new System.Drawing.Size(1245, 372);
            this.GDAfisareElevi.TabIndex = 0;
            this.GDAfisareElevi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDAfisareElevi_CellDoubleClick);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(34, 114);
            this.txtCautare.Multiline = true;
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(312, 34);
            this.txtCautare.TabIndex = 1;
            this.txtCautare.TextChanged += new System.EventHandler(this.txtCautare_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cautare Dupa Prenume";
            // 
            // btn_Excel_DateElevi
            // 
            this.btn_Excel_DateElevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Excel_DateElevi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel_DateElevi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel_DateElevi.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_DateElevi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_DateElevi.Image")));
            this.btn_Excel_DateElevi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_DateElevi.Location = new System.Drawing.Point(1067, 99);
            this.btn_Excel_DateElevi.Name = "btn_Excel_DateElevi";
            this.btn_Excel_DateElevi.Size = new System.Drawing.Size(212, 49);
            this.btn_Excel_DateElevi.TabIndex = 3;
            this.btn_Excel_DateElevi.Text = "Export Excel";
            this.btn_Excel_DateElevi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_DateElevi.UseVisualStyleBackColor = false;
            this.btn_Excel_DateElevi.Click += new System.EventHandler(this.btn_Excel_DateElevi_Click);
            // 
            // FrmAfisareDateElevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 565);
            this.Controls.Add(this.btn_Excel_DateElevi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.GDAfisareElevi);
            this.Name = "FrmAfisareDateElevi";
            this.Text = "Afisare Date Elevi";
            this.Load += new System.EventHandler(this.FrmAfisareDateElevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareElevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GDAfisareElevi;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Excel_DateElevi;
    }
}