namespace ManagerApp
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.button12.ForeColor = System.Drawing.Color.DarkGreen;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(77, 66);
            this.button12.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(977, 65);
            this.button12.TabIndex = 35;
            this.button12.Text = "Transactions Log";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(94, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Files location: ";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Roboto Black", 14F);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatus.Location = new System.Drawing.Point(94, 252);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(231, 29);
            this.labelStatus.TabIndex = 37;
            this.labelStatus.Text = "Last added logs on: ";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Roboto", 12F);
            this.labelLocation.Location = new System.Drawing.Point(120, 202);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(138, 24);
            this.labelLocation.TabIndex = 38;
            this.labelLocation.Text = "Files location: ";
            // 
            // buttonChange
            // 
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChange.Location = new System.Drawing.Point(290, 162);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(97, 27);
            this.buttonChange.TabIndex = 39;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 521);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonChange;
    }
}