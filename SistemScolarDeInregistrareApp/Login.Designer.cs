namespace SistemScolarDeInregistrareApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLoginUtilizator = new System.Windows.Forms.Label();
            this.txtLoginUtilizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginParola = new System.Windows.Forms.TextBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkArataParola = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginUtilizator
            // 
            this.lblLoginUtilizator.AutoSize = true;
            this.lblLoginUtilizator.Location = new System.Drawing.Point(25, 238);
            this.lblLoginUtilizator.Name = "lblLoginUtilizator";
            this.lblLoginUtilizator.Size = new System.Drawing.Size(96, 25);
            this.lblLoginUtilizator.TabIndex = 4;
            this.lblLoginUtilizator.Text = "Utilizator";
            // 
            // txtLoginUtilizator
            // 
            this.txtLoginUtilizator.Location = new System.Drawing.Point(175, 240);
            this.txtLoginUtilizator.Name = "txtLoginUtilizator";
            this.txtLoginUtilizator.Size = new System.Drawing.Size(268, 30);
            this.txtLoginUtilizator.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parola";
            // 
            // txtLoginParola
            // 
            this.txtLoginParola.Location = new System.Drawing.Point(175, 292);
            this.txtLoginParola.Name = "txtLoginParola";
            this.txtLoginParola.Size = new System.Drawing.Size(268, 30);
            this.txtLoginParola.TabIndex = 1;
            this.txtLoginParola.UseSystemPasswordChar = true;
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.Red;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIesire.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.ForeColor = System.Drawing.Color.White;
            this.btnIesire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIesire.Location = new System.Drawing.Point(363, 482);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(111, 42);
            this.btnIesire.TabIndex = 2;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(196, 374);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkArataParola
            // 
            this.chkArataParola.AutoSize = true;
            this.chkArataParola.Location = new System.Drawing.Point(259, 328);
            this.chkArataParola.Name = "chkArataParola";
            this.chkArataParola.Size = new System.Drawing.Size(154, 29);
            this.chkArataParola.TabIndex = 4;
            this.chkArataParola.Text = "Arata Parola";
            this.chkArataParola.UseVisualStyleBackColor = true;
            this.chkArataParola.CheckedChanged += new System.EventHandler(this.chkArataParola_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkArataParola);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.txtLoginParola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginUtilizator);
            this.Controls.Add(this.lblLoginUtilizator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginUtilizator;
        private System.Windows.Forms.TextBox txtLoginUtilizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginParola;
        public System.Windows.Forms.Button btnIesire;
        public System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkArataParola;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}