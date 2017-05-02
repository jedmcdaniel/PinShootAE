namespace PinShoot
{
    partial class Team
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.ddlTeamType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamId = new System.Windows.Forms.TextBox();
            this.btnSaveCreateNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtTeamNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlParticipant1 = new System.Windows.Forms.ComboBox();
            this.ddlParticipant2 = new System.Windows.Forms.ComboBox();
            this.ddlParticipant3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ddlTeamType
            // 
            this.ddlTeamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeamType.FormattingEnabled = true;
            this.ddlTeamType.Location = new System.Drawing.Point(113, 35);
            this.ddlTeamType.Name = "ddlTeamType";
            this.ddlTeamType.Size = new System.Drawing.Size(288, 21);
            this.ddlTeamType.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Team Type";
            // 
            // txtTeamId
            // 
            this.txtTeamId.Location = new System.Drawing.Point(94, 168);
            this.txtTeamId.Name = "txtTeamId";
            this.txtTeamId.Size = new System.Drawing.Size(46, 20);
            this.txtTeamId.TabIndex = 16;
            this.txtTeamId.Visible = false;
            // 
            // btnSaveCreateNew
            // 
            this.btnSaveCreateNew.Location = new System.Drawing.Point(140, 168);
            this.btnSaveCreateNew.Name = "btnSaveCreateNew";
            this.btnSaveCreateNew.Size = new System.Drawing.Size(99, 23);
            this.btnSaveCreateNew.TabIndex = 15;
            this.btnSaveCreateNew.Text = "Save Create &New";
            this.btnSaveCreateNew.UseVisualStyleBackColor = true;
            this.btnSaveCreateNew.Click += new System.EventHandler(this.btnSaveCreateNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(326, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(113, 143);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(56, 17);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtTeamNumber
            // 
            this.txtTeamNumber.Location = new System.Drawing.Point(113, 9);
            this.txtTeamNumber.Name = "txtTeamNumber";
            this.txtTeamNumber.Size = new System.Drawing.Size(56, 20);
            this.txtTeamNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Team Member";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Team Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Team Member";
            // 
            // ddlParticipant1
            // 
            this.ddlParticipant1.DisplayMember = "ParticipantName";
            this.ddlParticipant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParticipant1.FormattingEnabled = true;
            this.ddlParticipant1.Location = new System.Drawing.Point(113, 62);
            this.ddlParticipant1.Name = "ddlParticipant1";
            this.ddlParticipant1.Size = new System.Drawing.Size(288, 21);
            this.ddlParticipant1.TabIndex = 23;
            this.ddlParticipant1.ValueMember = "RecId";
            // 
            // ddlParticipant2
            // 
            this.ddlParticipant2.DisplayMember = "ParticipantName";
            this.ddlParticipant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParticipant2.FormattingEnabled = true;
            this.ddlParticipant2.Location = new System.Drawing.Point(113, 89);
            this.ddlParticipant2.Name = "ddlParticipant2";
            this.ddlParticipant2.Size = new System.Drawing.Size(288, 21);
            this.ddlParticipant2.TabIndex = 24;
            this.ddlParticipant2.ValueMember = "RecId";
            // 
            // ddlParticipant3
            // 
            this.ddlParticipant3.DisplayMember = "ParticipantName";
            this.ddlParticipant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParticipant3.FormattingEnabled = true;
            this.ddlParticipant3.Location = new System.Drawing.Point(113, 116);
            this.ddlParticipant3.Name = "ddlParticipant3";
            this.ddlParticipant3.Size = new System.Drawing.Size(288, 21);
            this.ddlParticipant3.TabIndex = 25;
            this.ddlParticipant3.ValueMember = "RecId";
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 206);
            this.Controls.Add(this.ddlParticipant3);
            this.Controls.Add(this.ddlParticipant2);
            this.Controls.Add(this.ddlParticipant1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ddlTeamType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamId);
            this.Controls.Add(this.btnSaveCreateNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtTeamNumber);
            this.Controls.Add(this.label1);
            this.Name = "Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Team_FormClosing);
            this.Load += new System.EventHandler(this.Team_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox ddlTeamType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamId;
        private System.Windows.Forms.Button btnSaveCreateNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtTeamNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlParticipant1;
        private System.Windows.Forms.ComboBox ddlParticipant2;
        private System.Windows.Forms.ComboBox ddlParticipant3;
    }
}