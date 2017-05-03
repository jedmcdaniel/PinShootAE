namespace PinShoot
{
    partial class OtherTimeEntry
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
            this.txtEntryId = new System.Windows.Forms.TextBox();
            this.lblTieBreaker = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCreateNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Label();
            this.ddlEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlParticipant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEntryId
            // 
            this.txtEntryId.Location = new System.Drawing.Point(263, 122);
            this.txtEntryId.Name = "txtEntryId";
            this.txtEntryId.Size = new System.Drawing.Size(46, 20);
            this.txtEntryId.TabIndex = 62;
            this.txtEntryId.Visible = false;
            // 
            // lblTieBreaker
            // 
            this.lblTieBreaker.AutoSize = true;
            this.lblTieBreaker.Location = new System.Drawing.Point(93, 129);
            this.lblTieBreaker.Name = "lblTieBreaker";
            this.lblTieBreaker.Size = new System.Drawing.Size(22, 13);
            this.lblTieBreaker.TabIndex = 61;
            this.lblTieBreaker.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tie Breaker";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Location = new System.Drawing.Point(93, 100);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(22, 13);
            this.lblBest.TabIndex = 59;
            this.lblBest.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Best Time";
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(183, 66);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(38, 20);
            this.txtEntry3.TabIndex = 48;
            this.txtEntry3.Leave += new System.EventHandler(this.txtEntry3_Leave);
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(139, 66);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(38, 20);
            this.txtEntry2.TabIndex = 47;
            this.txtEntry2.Leave += new System.EventHandler(this.txtEntry2_Leave);
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(95, 66);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(38, 20);
            this.txtEntry1.TabIndex = 46;
            this.txtEntry1.Leave += new System.EventHandler(this.txtEntry1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Times";
            // 
            // btnSaveCreateNew
            // 
            this.btnSaveCreateNew.Location = new System.Drawing.Point(122, 156);
            this.btnSaveCreateNew.Name = "btnSaveCreateNew";
            this.btnSaveCreateNew.Size = new System.Drawing.Size(99, 23);
            this.btnSaveCreateNew.TabIndex = 52;
            this.btnSaveCreateNew.Text = "Save Create &New";
            this.btnSaveCreateNew.UseVisualStyleBackColor = true;
            this.btnSaveCreateNew.Click += new System.EventHandler(this.btnSaveCreateNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Location = new System.Drawing.Point(40, 39);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(35, 13);
            this.Event.TabIndex = 54;
            this.Event.Text = "Event";
            // 
            // ddlEvent
            // 
            this.ddlEvent.DisplayMember = "ParticipantName";
            this.ddlEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEvent.FormattingEnabled = true;
            this.ddlEvent.Location = new System.Drawing.Point(96, 39);
            this.ddlEvent.Name = "ddlEvent";
            this.ddlEvent.Size = new System.Drawing.Size(288, 21);
            this.ddlEvent.TabIndex = 45;
            this.ddlEvent.ValueMember = "RecId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Participant";
            // 
            // ddlParticipant
            // 
            this.ddlParticipant.DisplayMember = "ParticipantName";
            this.ddlParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParticipant.FormattingEnabled = true;
            this.ddlParticipant.Location = new System.Drawing.Point(96, 12);
            this.ddlParticipant.Name = "ddlParticipant";
            this.ddlParticipant.Size = new System.Drawing.Size(288, 21);
            this.ddlParticipant.TabIndex = 44;
            this.ddlParticipant.ValueMember = "RecId";
            // 
            // OtherTimeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 197);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEntryId);
            this.Controls.Add(this.lblTieBreaker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveCreateNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.ddlEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlParticipant);
            this.Name = "OtherTimeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtherTimeEntry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherTimeEntry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEntryId;
        private System.Windows.Forms.Label lblTieBreaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveCreateNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.ComboBox ddlEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlParticipant;
    }
}