namespace PinShoot
{
    partial class ParticpantList
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgParticipantList = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USPSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentAffiliation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(824, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgParticipantList
            // 
            this.dtgParticipantList.AllowUserToAddRows = false;
            this.dtgParticipantList.AllowUserToDeleteRows = false;
            this.dtgParticipantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParticipantList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.USPSA,
            this.SCClass,
            this.Phone,
            this.DepartmentAffiliation,
            this.Email,
            this.IsActive});
            this.dtgParticipantList.Location = new System.Drawing.Point(12, 12);
            this.dtgParticipantList.Name = "dtgParticipantList";
            this.dtgParticipantList.ReadOnly = true;
            this.dtgParticipantList.Size = new System.Drawing.Size(887, 480);
            this.dtgParticipantList.TabIndex = 1;
            this.dtgParticipantList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgParticipantList_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "RecId";
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FirstName.Width = 63;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 83;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // USPSA
            // 
            this.USPSA.DataPropertyName = "USPSAClass";
            this.USPSA.HeaderText = "USPSA";
            this.USPSA.Name = "USPSA";
            this.USPSA.ReadOnly = true;
            // 
            // SCClass
            // 
            this.SCClass.DataPropertyName = "ScClass";
            this.SCClass.HeaderText = "SC Class";
            this.SCClass.Name = "SCClass";
            this.SCClass.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // DepartmentAffiliation
            // 
            this.DepartmentAffiliation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DepartmentAffiliation.DataPropertyName = "DepartmentAffiliation";
            this.DepartmentAffiliation.HeaderText = "Department Affiliation";
            this.DepartmentAffiliation.Name = "DepartmentAffiliation";
            this.DepartmentAffiliation.ReadOnly = true;
            this.DepartmentAffiliation.Width = 121;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(29, 511);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ParticpantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 546);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtgParticipantList);
            this.Controls.Add(this.btnClose);
            this.Name = "ParticpantList";
            this.Text = "Particpant List";
            this.Load += new System.EventHandler(this.ParticpantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgParticipantList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgParticipantList;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn USPSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentAffiliation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.Button btnCreate;
    }
}