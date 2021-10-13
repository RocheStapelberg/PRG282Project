namespace PRG282Project.PresentationLayer
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtsID = new System.Windows.Forms.TextBox();
            this.lblsID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPic = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbModule = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtMdesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblMheading = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtMcode = new System.Windows.Forms.TextBox();
            this.lblMname = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.gbModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.ForeColor = System.Drawing.Color.Red;
            this.lblHeading1.Location = new System.Drawing.Point(25, 9);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(202, 24);
            this.lblHeading1.TabIndex = 0;
            this.lblHeading1.Text = "Add a New Student";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtsID);
            this.gbDetails.Controls.Add(this.lblsID);
            this.gbDetails.Controls.Add(this.txtAddress);
            this.gbDetails.Controls.Add(this.lblAddress);
            this.gbDetails.Controls.Add(this.txtPhone);
            this.gbDetails.Controls.Add(this.lblNum);
            this.gbDetails.Controls.Add(this.cmbGender);
            this.gbDetails.Controls.Add(this.lblGen);
            this.gbDetails.Controls.Add(this.dtpDOB);
            this.gbDetails.Controls.Add(this.lblDOB);
            this.gbDetails.Controls.Add(this.txtSurname);
            this.gbDetails.Controls.Add(this.lblSurname);
            this.gbDetails.Controls.Add(this.txtName);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.lblPic);
            this.gbDetails.Controls.Add(this.btnUpload);
            this.gbDetails.Controls.Add(this.pbFoto);
            this.gbDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.ForeColor = System.Drawing.Color.Red;
            this.gbDetails.Location = new System.Drawing.Point(29, 67);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(250, 573);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Student Details";
            // 
            // txtsID
            // 
            this.txtsID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsID.ForeColor = System.Drawing.Color.Black;
            this.txtsID.Location = new System.Drawing.Point(107, 276);
            this.txtsID.Name = "txtsID";
            this.txtsID.Size = new System.Drawing.Size(134, 21);
            this.txtsID.TabIndex = 16;
            // 
            // lblsID
            // 
            this.lblsID.AutoSize = true;
            this.lblsID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsID.ForeColor = System.Drawing.Color.Red;
            this.lblsID.Location = new System.Drawing.Point(10, 279);
            this.lblsID.Name = "lblsID";
            this.lblsID.Size = new System.Drawing.Size(98, 12);
            this.lblsID.TabIndex = 15;
            this.lblsID.Text = "Student Number:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(11, 527);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 23);
            this.txtAddress.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Red;
            this.lblAddress.Location = new System.Drawing.Point(11, 509);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 15);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Physical Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(105, 489);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 21);
            this.txtPhone.TabIndex = 12;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Red;
            this.lblNum.Location = new System.Drawing.Point(11, 492);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 14);
            this.lblNum.TabIndex = 11;
            this.lblNum.Text = "Phone:";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(105, 445);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(134, 22);
            this.cmbGender.TabIndex = 10;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.ForeColor = System.Drawing.Color.Red;
            this.lblGen.Location = new System.Drawing.Point(11, 448);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(55, 14);
            this.lblGen.TabIndex = 9;
            this.lblGen.Text = "Gender:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(14, 410);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(225, 20);
            this.dtpDOB.TabIndex = 8;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Red;
            this.lblDOB.Location = new System.Drawing.Point(11, 392);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(97, 15);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(105, 352);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(134, 21);
            this.txtSurname.TabIndex = 6;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Red;
            this.lblSurname.Location = new System.Drawing.Point(11, 355);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 14);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(105, 310);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(8, 313);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 14);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.ForeColor = System.Drawing.Color.Red;
            this.lblPic.Location = new System.Drawing.Point(33, 37);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(152, 14);
            this.lblPic.TabIndex = 2;
            this.lblPic.Text = "Insert Student Foto Here:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Black;
            this.btnUpload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(36, 225);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(184, 34);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(36, 54);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(184, 164);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gbModule
            // 
            this.gbModule.Controls.Add(this.label1);
            this.gbModule.Controls.Add(this.txtLink);
            this.gbModule.Controls.Add(this.txtMdesc);
            this.gbModule.Controls.Add(this.lblDesc);
            this.gbModule.Controls.Add(this.lblMheading);
            this.gbModule.Controls.Add(this.txtMname);
            this.gbModule.Controls.Add(this.txtMcode);
            this.gbModule.Controls.Add(this.lblMname);
            this.gbModule.Controls.Add(this.lblCode);
            this.gbModule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModule.ForeColor = System.Drawing.Color.Yellow;
            this.gbModule.Location = new System.Drawing.Point(298, 140);
            this.gbModule.Name = "gbModule";
            this.gbModule.Size = new System.Drawing.Size(223, 269);
            this.gbModule.TabIndex = 2;
            this.gbModule.TabStop = false;
            this.gbModule.Text = "Module Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(6, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Link";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.Black;
            this.txtLink.Location = new System.Drawing.Point(9, 220);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(197, 21);
            this.txtLink.TabIndex = 22;
            // 
            // txtMdesc
            // 
            this.txtMdesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdesc.ForeColor = System.Drawing.Color.Black;
            this.txtMdesc.Location = new System.Drawing.Point(9, 165);
            this.txtMdesc.Name = "txtMdesc";
            this.txtMdesc.Size = new System.Drawing.Size(197, 21);
            this.txtMdesc.TabIndex = 21;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Yellow;
            this.lblDesc.Location = new System.Drawing.Point(6, 141);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 14);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Description:";
            // 
            // lblMheading
            // 
            this.lblMheading.AutoSize = true;
            this.lblMheading.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMheading.ForeColor = System.Drawing.Color.Yellow;
            this.lblMheading.Location = new System.Drawing.Point(5, 22);
            this.lblMheading.Name = "lblMheading";
            this.lblMheading.Size = new System.Drawing.Size(111, 14);
            this.lblMheading.TabIndex = 19;
            this.lblMheading.Text = "Enter Module info:";
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.ForeColor = System.Drawing.Color.Black;
            this.txtMname.Location = new System.Drawing.Point(76, 95);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(130, 21);
            this.txtMname.TabIndex = 18;
            // 
            // txtMcode
            // 
            this.txtMcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMcode.ForeColor = System.Drawing.Color.Black;
            this.txtMcode.Location = new System.Drawing.Point(76, 54);
            this.txtMcode.Name = "txtMcode";
            this.txtMcode.Size = new System.Drawing.Size(80, 21);
            this.txtMcode.TabIndex = 16;
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMname.ForeColor = System.Drawing.Color.Yellow;
            this.lblMname.Location = new System.Drawing.Point(6, 98);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(45, 14);
            this.lblMname.TabIndex = 17;
            this.lblMname.Text = "Name:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Yellow;
            this.lblCode.Location = new System.Drawing.Point(6, 57);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 14);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "Code:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(298, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 45);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Student and Module info";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(298, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(223, 47);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear All Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(408, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 50);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(306, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 50);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(561, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbModule);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblHeading1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStudent";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.gbModule.ResumeLayout(false);
            this.gbModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.GroupBox gbModule;
        private System.Windows.Forms.TextBox txtMdesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblMheading;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtMcode;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsID;
        private System.Windows.Forms.Label lblsID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
    }
}