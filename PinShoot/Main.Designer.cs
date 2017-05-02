namespace PinShoot
{
    partial class Main
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
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnPinTimeEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.bubtnTeamTimeEntrytton1 = new System.Windows.Forms.Button();
            this.btnOtherTimeEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(81, 12);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(106, 34);
            this.btnParticipants.TabIndex = 0;
            this.btnParticipants.Text = "&Participants";
            this.btnParticipants.UseVisualStyleBackColor = true;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(81, 70);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(106, 30);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "&Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnPinTimeEntry
            // 
            this.btnPinTimeEntry.Location = new System.Drawing.Point(81, 121);
            this.btnPinTimeEntry.Name = "btnPinTimeEntry";
            this.btnPinTimeEntry.Size = new System.Drawing.Size(106, 34);
            this.btnPinTimeEntry.TabIndex = 2;
            this.btnPinTimeEntry.Text = "5 &Pin Results";
            this.btnPinTimeEntry.UseVisualStyleBackColor = true;
            this.btnPinTimeEntry.Click += new System.EventHandler(this.btnPinTimeEntry_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(81, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(81, 43);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(106, 30);
            this.btnTeams.TabIndex = 4;
            this.btnTeams.Text = "&Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // bubtnTeamTimeEntrytton1
            // 
            this.bubtnTeamTimeEntrytton1.Location = new System.Drawing.Point(81, 180);
            this.bubtnTeamTimeEntrytton1.Name = "bubtnTeamTimeEntrytton1";
            this.bubtnTeamTimeEntrytton1.Size = new System.Drawing.Size(106, 36);
            this.bubtnTeamTimeEntrytton1.TabIndex = 6;
            this.bubtnTeamTimeEntrytton1.Text = "Tea&m Time Entry";
            this.bubtnTeamTimeEntrytton1.UseVisualStyleBackColor = true;
            // 
            // btnOtherTimeEntry
            // 
            this.btnOtherTimeEntry.Location = new System.Drawing.Point(81, 151);
            this.btnOtherTimeEntry.Name = "btnOtherTimeEntry";
            this.btnOtherTimeEntry.Size = new System.Drawing.Size(106, 33);
            this.btnOtherTimeEntry.TabIndex = 7;
            this.btnOtherTimeEntry.Text = "&Other Time Entry";
            this.btnOtherTimeEntry.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 313);
            this.Controls.Add(this.btnOtherTimeEntry);
            this.Controls.Add(this.bubtnTeamTimeEntrytton1);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPinTimeEntry);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnParticipants);
            this.Name = "Main";
            this.Text = "Pin Shoot";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnPinTimeEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button bubtnTeamTimeEntrytton1;
        private System.Windows.Forms.Button btnOtherTimeEntry;
    }
}

