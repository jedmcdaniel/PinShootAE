namespace PinShoot
{
    partial class TeamList
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
            this.dtgrdTeamList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeamNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participant2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participant3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdTeamList
            // 
            this.dtgrdTeamList.AllowUserToAddRows = false;
            this.dtgrdTeamList.AllowUserToDeleteRows = false;
            this.dtgrdTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.TeamNumber,
            this.TeamType,
            this.Participant1,
            this.Participant2,
            this.Participant3,
            this.IsActive});
            this.dtgrdTeamList.Location = new System.Drawing.Point(12, 12);
            this.dtgrdTeamList.MultiSelect = false;
            this.dtgrdTeamList.Name = "dtgrdTeamList";
            this.dtgrdTeamList.ReadOnly = true;
            this.dtgrdTeamList.Size = new System.Drawing.Size(949, 328);
            this.dtgrdTeamList.TabIndex = 0;
            this.dtgrdTeamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdTeamList_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(886, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(12, 349);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "Create &New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "RecId";
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // TeamNumber
            // 
            this.TeamNumber.DataPropertyName = "TeamNumber";
            this.TeamNumber.HeaderText = "Team Number";
            this.TeamNumber.Name = "TeamNumber";
            this.TeamNumber.ReadOnly = true;
            // 
            // TeamType
            // 
            this.TeamType.DataPropertyName = "TeamType";
            this.TeamType.HeaderText = "Type";
            this.TeamType.Name = "TeamType";
            this.TeamType.ReadOnly = true;
            // 
            // Participant1
            // 
            this.Participant1.DataPropertyName = "Participant1";
            this.Participant1.HeaderText = "Participant 1";
            this.Participant1.Name = "Participant1";
            this.Participant1.ReadOnly = true;
            // 
            // Participant2
            // 
            this.Participant2.DataPropertyName = "Participant2";
            this.Participant2.HeaderText = "Participant 2";
            this.Participant2.Name = "Participant2";
            this.Participant2.ReadOnly = true;
            // 
            // Participant3
            // 
            this.Participant3.DataPropertyName = "Participant3";
            this.Participant3.HeaderText = "Participant 3";
            this.Participant3.Name = "Participant3";
            this.Participant3.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.FalseValue = "";
            this.IsActive.HeaderText = "Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.TrueValue = "";
            // 
            // TeamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 384);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgrdTeamList);
            this.Name = "TeamList";
            this.Text = "TeamList";
            this.Load += new System.EventHandler(this.TeamList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdTeamList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdTeamList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participant1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participant2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participant3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}