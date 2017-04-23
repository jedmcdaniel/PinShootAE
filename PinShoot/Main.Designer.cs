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
            this.btnTimeEntry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParticipants
            // 
            this.btnParticipants.Location = new System.Drawing.Point(81, 66);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(106, 34);
            this.btnParticipants.TabIndex = 0;
            this.btnParticipants.Text = "Participants";
            this.btnParticipants.UseVisualStyleBackColor = true;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(81, 107);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(106, 30);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnTimeEntry
            // 
            this.btnTimeEntry.Location = new System.Drawing.Point(81, 144);
            this.btnTimeEntry.Name = "btnTimeEntry";
            this.btnTimeEntry.Size = new System.Drawing.Size(106, 34);
            this.btnTimeEntry.TabIndex = 2;
            this.btnTimeEntry.Text = "Time Entry";
            this.btnTimeEntry.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 372);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTimeEntry);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnParticipants);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnTimeEntry;
        private System.Windows.Forms.Button btnExit;
    }
}

