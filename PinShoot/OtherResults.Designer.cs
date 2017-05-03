namespace PinShoot
{
    partial class OtherResults
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
            this.ddlEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrdFivePinResults = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.RecId = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieBreaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFivePinResults)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlEvent
            // 
            this.ddlEvent.DisplayMember = "ParticipantName";
            this.ddlEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEvent.FormattingEnabled = true;
            this.ddlEvent.Location = new System.Drawing.Point(53, 5);
            this.ddlEvent.Name = "ddlEvent";
            this.ddlEvent.Size = new System.Drawing.Size(288, 21);
            this.ddlEvent.TabIndex = 11;
            this.ddlEvent.ValueMember = "RecId";
            this.ddlEvent.SelectedIndexChanged += new System.EventHandler(this.ddlEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event";
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
            this.BestTime,
            this.TieBreaker,
            this.Time1,
            this.Time2,
            this.Time3});
            this.dtgrdFivePinResults.Location = new System.Drawing.Point(12, 32);
            this.dtgrdFivePinResults.Name = "dtgrdFivePinResults";
            this.dtgrdFivePinResults.ReadOnly = true;
            this.dtgrdFivePinResults.Size = new System.Drawing.Size(998, 647);
            this.dtgrdFivePinResults.TabIndex = 9;
            this.dtgrdFivePinResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdFivePinResults_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(855, 685);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(29, 685);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create &New";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(936, 685);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RecId
            // 
            this.RecId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RecId.DataPropertyName = "RecId";
            this.RecId.HeaderText = "Edit";
            this.RecId.Name = "RecId";
            this.RecId.ReadOnly = true;
            this.RecId.Width = 31;
            // 
            // EventName
            // 
            this.EventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 91;
            // 
            // Participant
            // 
            this.Participant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Participant.DataPropertyName = "ParticipantName";
            this.Participant.HeaderText = "Participant";
            this.Participant.Name = "Participant";
            this.Participant.ReadOnly = true;
            this.Participant.Width = 82;
            // 
            // BestTime
            // 
            this.BestTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BestTime.DataPropertyName = "BestTime";
            this.BestTime.HeaderText = "Best Time";
            this.BestTime.Name = "BestTime";
            this.BestTime.ReadOnly = true;
            this.BestTime.Width = 79;
            // 
            // TieBreaker
            // 
            this.TieBreaker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TieBreaker.DataPropertyName = "TieBreaker";
            this.TieBreaker.HeaderText = "Tie Breaker";
            this.TieBreaker.Name = "TieBreaker";
            this.TieBreaker.ReadOnly = true;
            this.TieBreaker.Width = 87;
            // 
            // Time1
            // 
            this.Time1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time1.DataPropertyName = "Time1";
            this.Time1.HeaderText = "Time 1";
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            this.Time1.Width = 64;
            // 
            // Time2
            // 
            this.Time2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time2.DataPropertyName = "Time2";
            this.Time2.HeaderText = "Time 2";
            this.Time2.Name = "Time2";
            this.Time2.ReadOnly = true;
            this.Time2.Width = 64;
            // 
            // Time3
            // 
            this.Time3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time3.DataPropertyName = "Time3";
            this.Time3.HeaderText = "Time 3";
            this.Time3.Name = "Time3";
            this.Time3.ReadOnly = true;
            this.Time3.Width = 64;
            // 
            // OtherResults
            // 
            this.AcceptButton = this.btnCreateNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1036, 719);
            this.Controls.Add(this.ddlEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrdFivePinResults);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnClose);
            this.Name = "OtherResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtherResults";
            this.Load += new System.EventHandler(this.OtherResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdFivePinResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrdFivePinResults;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewButtonColumn RecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participant;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieBreaker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time3;
    }
}