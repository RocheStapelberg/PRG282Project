
namespace PRG282Project.PresentationLayer
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbBClogo = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBClogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.lblLine2);
            this.pnlLeft.Controls.Add(this.lblLine1);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Controls.Add(this.pbBClogo);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(272, 541);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine2.ForeColor = System.Drawing.Color.Red;
            this.lblLine2.Location = new System.Drawing.Point(-62, 427);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(417, 42);
            this.lblLine2.TabIndex = 3;
            this.lblLine2.Text = "___________________";
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine1.ForeColor = System.Drawing.Color.Red;
            this.lblLine1.Location = new System.Drawing.Point(-7, 436);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(417, 42);
            this.lblLine1.TabIndex = 2;
            this.lblLine1.Text = "___________________";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(266, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 538);
            this.panel2.TabIndex = 1;
            // 
            // pbBClogo
            // 
            this.pbBClogo.BackColor = System.Drawing.Color.Black;
            this.pbBClogo.Image = ((System.Drawing.Image)(resources.GetObject("pbBClogo.Image")));
            this.pbBClogo.Location = new System.Drawing.Point(16, 19);
            this.pbBClogo.Name = "pbBClogo";
            this.pbBClogo.Size = new System.Drawing.Size(253, 207);
            this.pbBClogo.TabIndex = 0;
            this.pbBClogo.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Black;
            this.btnLogIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Red;
            this.btnLogIn.Location = new System.Drawing.Point(460, 348);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(129, 59);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Red;
            this.btnRegister.Location = new System.Drawing.Point(460, 418);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(129, 59);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(331, 198);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 18);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Red;
            this.lblPass.Location = new System.Drawing.Point(331, 259);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(92, 18);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(460, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(460, 199);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Red;
            this.lblHeading.Location = new System.Drawing.Point(288, 48);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(338, 22);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Hi There! Please tell us who you are:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(665, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(777, 531);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBClogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbBClogo;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnExit;
    }
}