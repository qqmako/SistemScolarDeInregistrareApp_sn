namespace SistemScolarDeInregistrareApp
{
    partial class FrmAfisareDateTaxa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAfisareDateTaxa));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautareDupaPrenume = new System.Windows.Forms.TextBox();
            this.dtgwAfisareDateTaxe = new System.Windows.Forms.DataGridView();
            this.btn_Excel_DateTaxa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAfisareDateTaxe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cautare dupa Prenume";
            // 
            // txtCautareDupaPrenume
            // 
            this.txtCautareDupaPrenume.Location = new System.Drawing.Point(40, 119);
            this.txtCautareDupaPrenume.Name = "txtCautareDupaPrenume";
            this.txtCautareDupaPrenume.Size = new System.Drawing.Size(171, 22);
            this.txtCautareDupaPrenume.TabIndex = 1;
            this.txtCautareDupaPrenume.TextChanged += new System.EventHandler(this.txtCautareDupaNume_TextChanged);
            // 
            // dtgwAfisareDateTaxe
            // 
            this.dtgwAfisareDateTaxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwAfisareDateTaxe.Location = new System.Drawing.Point(40, 173);
            this.dtgwAfisareDateTaxe.Name = "dtgwAfisareDateTaxe";
            this.dtgwAfisareDateTaxe.RowHeadersWidth = 51;
            this.dtgwAfisareDateTaxe.RowTemplate.Height = 24;
            this.dtgwAfisareDateTaxe.Size = new System.Drawing.Size(970, 296);
            this.dtgwAfisareDateTaxe.TabIndex = 2;
            this.dtgwAfisareDateTaxe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwAfisareDateTaxe_CellDoubleClick);
            // 
            // btn_Excel_DateTaxa
            // 
            this.btn_Excel_DateTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Excel_DateTaxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel_DateTaxa.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel_DateTaxa.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_DateTaxa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_DateTaxa.Image")));
            this.btn_Excel_DateTaxa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_DateTaxa.Location = new System.Drawing.Point(798, 104);
            this.btn_Excel_DateTaxa.Name = "btn_Excel_DateTaxa";
            this.btn_Excel_DateTaxa.Size = new System.Drawing.Size(212, 49);
            this.btn_Excel_DateTaxa.TabIndex = 4;
            this.btn_Excel_DateTaxa.Text = "Export Excel";
            this.btn_Excel_DateTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_DateTaxa.UseVisualStyleBackColor = false;
            this.btn_Excel_DateTaxa.Click += new System.EventHandler(this.btn_Excel_DateTaxa_Click);
            // 
            // FrmAfisareDateTaxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 506);
            this.Controls.Add(this.btn_Excel_DateTaxa);
            this.Controls.Add(this.dtgwAfisareDateTaxe);
            this.Controls.Add(this.txtCautareDupaPrenume);
            this.Controls.Add(this.label1);
            this.Name = "FrmAfisareDateTaxa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afisare Date Taxa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwAfisareDateTaxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCautareDupaPrenume;
        private System.Windows.Forms.DataGridView dtgwAfisareDateTaxe;
        public System.Windows.Forms.Button btn_Excel_DateTaxa;
    }
}