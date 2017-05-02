namespace PinShoot
{
    partial class FivePinResults
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
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtgrdFivePinResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlEvent = new System.Windows.Forms.ComboBox();
            this.RecId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieBreaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFivePinResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(936, 683);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(29, 683);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Create &New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(855, 683);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dtgrdFivePinResults
            // 
            this.dtgrdFivePinResults.AllowUserToAddRows = false;
            this.dtgrdFivePinResults.AllowUserToDeleteRows = false;
            this.dtgrdFivePinResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdFivePinResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecId,
            this.EventName,
            this.Participant,
            this.TotalTime,
            this.TieBreaker,
            this.Time1,
            this.Time2,
            this.Time3,
            this.Time4,
            this.Time5,
            this.Time6});
            this.dtgrdFivePinResults.Location = new System.Drawing.Point(12, 30);
            this.dtgrdFivePinResults.Name = "dtgrdFivePinResults";
            this.dtgrdFivePinResults.ReadOnly = true;
            this.dtgrdFivePinResults.Size = new System.Drawing.Size(998, 647);
            this.dtgrdFivePinResults.TabIndex = 3;
            this.dtgrdFivePinResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdFivePinResults_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event";
            // 
            // ddlEvent
            // 
            this.ddlEvent.DisplayMember = "ParticipantName";
            this.ddlEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEvent.FormattingEnabled = true;
            this.ddlEvent.Location = new System.Drawing.Point(53, 3);
            this.ddlEvent.Name = "ddlEvent";
            this.ddlEvent.Size = new System.Drawing.Size(288, 21);
            this.ddlEvent.TabIndex = 5;
            this.ddlEvent.ValueMember = "RecId";
            this.ddlEvent.SelectedIndexChanged += new System.EventHandler(this.ddlEvent_SelectedIndexChanged);
            // 
            // RecId
            // 
            this.RecId.DataPropertyName = "RecId";
            this.RecId.HeaderText = "Edit";
            this.RecId.Name = "RecId";
            this.RecId.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // Participant
            // 
            this.Participant.DataPropertyName = "ParticipantName";
            this.Participant.HeaderText = "Participant";
            this.Participant.Name = "Participant";
            this.Participant.ReadOnly = true;
            // 
            // TotalTime
            // 
            this.TotalTime.DataPropertyName = "TotalTime";
            this.TotalTime.HeaderText = "Total Time";
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            // 
            // TieBreaker
            // 
            this.TieBreaker.DataPropertyName = "TieBreaker";
            this.TieBreaker.HeaderText = "Tie Breaker";
            this.TieBreaker.Name = "TieBreaker";
            this.TieBreaker.ReadOnly = true;
            // 
            // Time1
            // 
            this.Time1.DataPropertyName = "Time1";
            this.Time1.HeaderText = "Time 1";
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            // 
            // Time2
            // 
            this.Time2.DataPropertyName = "Time2";
            this.Time2.HeaderText = "Time 2";
            this.Time2.Name = "Time2";
            this.Time2.ReadOnly = true;
            // 
            // Time3
            // 
            this.Time3.DataPropertyName = "Time3";
            this.Time3.HeaderText = "Time 3";
            this.Time3.Name = "Time3";
            this.Time3.ReadOnly = true;
            // 
            // Time4
            // 
            this.Time4.DataPropertyName = "Time4";
            this.Time4.HeaderText = "Time 4";
            this.Time4.Name = "Time4";
            this.Time4.ReadOnly = true;
            // 
            // Time5
            // 
            this.Time5.DataPropertyName = "Time5";
            this.Time5.HeaderText = "Time 5";
            this.Time5.Name = "Time5";
            this.Time5.ReadOnly = true;
            // 
            // Time6
            // 
            this.Time6.DataPropertyName = "Time6";
            this.Time6.HeaderText = "Time 6";
            this.Time6.Name = "Time6";
            this.Time6.ReadOnly = true;
            // 
            // FivePinResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 718);
            this.Controls.Add(this.ddlEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrdFivePinResults);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnClose);
            this.Name = "FivePinResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FivePinResults";
            this.Load += new System.EventHandler(this.FivePinResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFivePinResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dtgrdFivePinResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlEvent;
        private System.Windows.Forms.DataGridViewButtonColumn RecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participant;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieBreaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time6;
    }
}