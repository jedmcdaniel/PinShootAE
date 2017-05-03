namespace PinShoot
{
    partial class FivePinTimeEntry
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
            this.ddlParticipant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlEvent = new System.Windows.Forms.ComboBox();
            this.Event = new System.Windows.Forms.Label();
            this.btnSaveCreateNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.txtEntry6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTieBreaker = new System.Windows.Forms.Label();
            this.txtEntryId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlParticipant
            // 
            this.ddlParticipant.DisplayMember = "ParticipantName";
            this.ddlParticipant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParticipant.FormattingEnabled = true;
            this.ddlParticipant.Location = new System.Drawing.Point(95, 12);
            this.ddlParticipant.Name = "ddlParticipant";
            this.ddlParticipant.Size = new System.Drawing.Size(288, 21);
            this.ddlParticipant.TabIndex = 1;
            this.ddlParticipant.ValueMember = "RecId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Participant";
            // 
            // ddlEvent
            // 
            this.ddlEvent.DisplayMember = "ParticipantName";
            this.ddlEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEvent.FormattingEnabled = true;
            this.ddlEvent.Location = new System.Drawing.Point(95, 39);
            this.ddlEvent.Name = "ddlEvent";
            this.ddlEvent.Size = new System.Drawing.Size(288, 21);
            this.ddlEvent.TabIndex = 2;
            this.ddlEvent.ValueMember = "RecId";
            // 
            // Event
            // 
            this.Event.AutoSize = true;
            this.Event.Location = new System.Drawing.Point(39, 39);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(35, 13);
            this.Event.TabIndex = 27;
            this.Event.Text = "Event";
            // 
            // btnSaveCreateNew
            // 
            this.btnSaveCreateNew.Location = new System.Drawing.Point(121, 156);
            this.btnSaveCreateNew.Name = "btnSaveCreateNew";
            this.btnSaveCreateNew.Size = new System.Drawing.Size(99, 23);
            this.btnSaveCreateNew.TabIndex = 9;
            this.btnSaveCreateNew.Text = "Save Create &New";
            this.btnSaveCreateNew.UseVisualStyleBackColor = true;
            this.btnSaveCreateNew.Click += new System.EventHandler(this.btnSaveCreateNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(307, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Times";
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(94, 66);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(38, 20);
            this.txtEntry1.TabIndex = 3;
            this.txtEntry1.Leave += new System.EventHandler(this.txtEntry1_Leave);
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(138, 66);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(38, 20);
            this.txtEntry2.TabIndex = 4;
            this.txtEntry2.Leave += new System.EventHandler(this.txtEntry2_Leave);
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(182, 66);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(38, 20);
            this.txtEntry3.TabIndex = 5;
            this.txtEntry3.Leave += new System.EventHandler(this.txtEntry3_Leave);
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(226, 66);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(38, 20);
            this.txtEntry4.TabIndex = 6;
            this.txtEntry4.Leave += new System.EventHandler(this.txtEntry4_Leave);
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(270, 66);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(38, 20);
            this.txtEntry5.TabIndex = 7;
            this.txtEntry5.Leave += new System.EventHandler(this.txtEntry5_Leave);
            // 
            // txtEntry6
            // 
            this.txtEntry6.Location = new System.Drawing.Point(314, 66);
            this.txtEntry6.Name = "txtEntry6";
            this.txtEntry6.Size = new System.Drawing.Size(38, 20);
            this.txtEntry6.TabIndex = 8;
            this.txtEntry6.Leave += new System.EventHandler(this.txtEntry6_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(92, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 13);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tie Breaker";
            // 
            // lblTieBreaker
            // 
            this.lblTieBreaker.AutoSize = true;
            this.lblTieBreaker.Location = new System.Drawing.Point(92, 129);
            this.lblTieBreaker.Name = "lblTieBreaker";
            this.lblTieBreaker.Size = new System.Drawing.Size(22, 13);
            this.lblTieBreaker.TabIndex = 41;
            this.lblTieBreaker.Text = "0.0";
            // 
            // txtEntryId
            // 
            this.txtEntryId.Location = new System.Drawing.Point(262, 122);
            this.txtEntryId.Name = "txtEntryId";
            this.txtEntryId.Size = new System.Drawing.Size(46, 20);
            this.txtEntryId.TabIndex = 42;
            this.txtEntryId.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FivePinTimeEntry
            // 
            this.AcceptButton = this.btnSaveCreateNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(404, 189);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEntryId);
            this.Controls.Add(this.lblTieBreaker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEntry6);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry4);
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
            this.Name = "FivePinTimeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FivePinTimeEntry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FivePinTimeEntry_FormClosing);
            this.Load += new System.EventHandler(this.FivePinTimeEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlEvent;
        private System.Windows.Forms.Label Event;
        private System.Windows.Forms.Button btnSaveCreateNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.TextBox txtEntry6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTieBreaker;
        private System.Windows.Forms.TextBox txtEntryId;
        private System.Windows.Forms.Button btnDelete;
    }
}