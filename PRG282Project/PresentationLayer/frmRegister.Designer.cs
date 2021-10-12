namespace PRG282Project.PresentationLayer
{
    partial class frmRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(21, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 18);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(21, 144);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(92, 18);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(95, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(171, 18);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Register a New User";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(186, 102);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(186, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(186, 190);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(165, 20);
            this.txtConfirm.TabIndex = 10;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Black;
            this.btnReg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(132, 234);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(111, 49);
            this.btnReg.TabIndex = 11;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(132, 289);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 48);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(385, 382);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnBack;
    }
}