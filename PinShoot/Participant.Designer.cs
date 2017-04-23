namespace PinShoot
{
    partial class frmParticipant
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtStreetAddress2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlUSPSA = new System.Windows.Forms.ComboBox();
            this.ddlSCClass = new System.Windows.Forms.ComboBox();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSaveAndCreateNew = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 13);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(201, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // ddlGender
            // 
            this.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.Location = new System.Drawing.Point(156, 65);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(200, 21);
            this.ddlGender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Street Address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(157, 92);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(200, 20);
            this.txtStreetAddress.TabIndex = 8;
            // 
            // txtStreetAddress2
            // 
            this.txtStreetAddress2.Location = new System.Drawing.Point(157, 118);
            this.txtStreetAddress2.Name = "txtStreetAddress2";
            this.txtStreetAddress2.Size = new System.Drawing.Size(200, 20);
            this.txtStreetAddress2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "USPSA Member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Second Chance Shot Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(156, 144);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 20);
            this.txtCity.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(156, 170);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(44, 20);
            this.txtState.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(156, 196);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 248);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Department/Club Affilliation";
            // 
            // ddlUSPSA
            // 
            this.ddlUSPSA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUSPSA.FormattingEnabled = true;
            this.ddlUSPSA.Location = new System.Drawing.Point(157, 300);
            this.ddlUSPSA.Name = "ddlUSPSA";
            this.ddlUSPSA.Size = new System.Drawing.Size(200, 21);
            this.ddlUSPSA.TabIndex = 23;
            // 
            // ddlSCClass
            // 
            this.ddlSCClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSCClass.FormattingEnabled = true;
            this.ddlSCClass.Location = new System.Drawing.Point(157, 327);
            this.ddlSCClass.Name = "ddlSCClass";
            this.ddlSCClass.Size = new System.Drawing.Size(200, 21);
            this.ddlSCClass.TabIndex = 24;
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(157, 274);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(196, 20);
            this.txtClub.TabIndex = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(157, 355);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(56, 17);
            this.chkIsActive.TabIndex = 27;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSaveAndCreateNew
            // 
            this.btnSaveAndCreateNew.Location = new System.Drawing.Point(15, 385);
            this.btnSaveAndCreateNew.Name = "btnSaveAndCreateNew";
            this.btnSaveAndCreateNew.Size = new System.Drawing.Size(113, 23);
            this.btnSaveAndCreateNew.TabIndex = 28;
            this.btnSaveAndCreateNew.Text = "Save Create New";
            this.btnSaveAndCreateNew.UseVisualStyleBackColor = true;
            this.btnSaveAndCreateNew.Click += new System.EventHandler(this.btnSaveAndCreateNew_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(256, 359);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 29;
            // 
            // frmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 415);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSaveAndCreateNew);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.ddlSCClass);
            this.Controls.Add(this.ddlUSPSA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStreetAddress2);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddlGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmParticipant";
            this.Text = "Participant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParticipant_FormClosing);
            this.Load += new System.EventHandler(this.frmParticipant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtStreetAddress2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddlUSPSA;
        private System.Windows.Forms.ComboBox ddlSCClass;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSaveAndCreateNew;
        private System.Windows.Forms.TextBox txtID;
    }
}