namespace CampEntranceApp
{
    partial class CampEntrance
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRFIDCode = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxLogMessage = new System.Windows.Forms.ListBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timerResetControls = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(48, 137);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(85, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(179, 136);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(85, 23);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lastname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblRFIDCode);
            this.groupBox1.Controls.Add(this.lbLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 249);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CheckIn/Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "RFIDCode:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(47, 67);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(55, 13);
            this.lastname.TabIndex = 7;
            this.lastname.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FirstName";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(176, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "...........................";
            // 
            // lblRFIDCode
            // 
            this.lblRFIDCode.AutoSize = true;
            this.lblRFIDCode.Location = new System.Drawing.Point(178, 93);
            this.lblRFIDCode.Name = "lblRFIDCode";
            this.lblRFIDCode.Size = new System.Drawing.Size(88, 13);
            this.lblRFIDCode.TabIndex = 2;
            this.lblRFIDCode.Text = "...........................";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(176, 67);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(88, 13);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "...........................";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(176, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "...........................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // lbxLogMessage
            // 
            this.lbxLogMessage.FormattingEnabled = true;
            this.lbxLogMessage.Location = new System.Drawing.Point(32, 19);
            this.lbxLogMessage.Name = "lbxLogMessage";
            this.lbxLogMessage.Size = new System.Drawing.Size(516, 121);
            this.lbxLogMessage.TabIndex = 13;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(207, 156);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(117, 23);
            this.btnClearLogs.TabIndex = 7;
            this.btnClearLogs.Text = "ClearLogs";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxLogMessage);
            this.groupBox3.Controls.Add(this.btnClearLogs);
            this.groupBox3.Location = new System.Drawing.Point(2, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 197);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LogMessage";
            // 
            // timerResetControls
            // 
            this.timerResetControls.Interval = 3000;
            this.timerResetControls.Tick += new System.EventHandler(this.timerResetControls_Tick);
            // 
            // CampEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "CampEntrance";
            this.Text = "CampEntranceForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRFIDCode;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxLogMessage;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timerResetControls;
    }
}

