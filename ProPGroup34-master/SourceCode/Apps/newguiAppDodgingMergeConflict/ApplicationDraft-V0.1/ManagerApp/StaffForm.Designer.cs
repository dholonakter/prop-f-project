namespace ManagerApp
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationComboBx = new System.Windows.Forms.ComboBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Roboto", 10F);
            this.locationLbl.ForeColor = System.Drawing.Color.DimGray;
            this.locationLbl.Location = new System.Drawing.Point(74, 167);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(88, 20);
            this.locationLbl.TabIndex = 1;
            this.locationLbl.Text = "Select job:";
            // 
            // locationComboBx
            // 
            this.locationComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.locationComboBx.FormattingEnabled = true;
            this.locationComboBx.Location = new System.Drawing.Point(208, 159);
            this.locationComboBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(275, 28);
            this.locationComboBx.TabIndex = 2;
            this.locationComboBx.SelectedIndexChanged += new System.EventHandler(this.locationComboBx_SelectedIndexChanged);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(78, 206);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1176, 294);
            this.dataGridViewStaff.TabIndex = 70;
            // 
            // buttonLogs
            // 
            this.buttonLogs.BackColor = System.Drawing.Color.DimGray;
            this.buttonLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogs.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonLogs.ForeColor = System.Drawing.Color.White;
            this.buttonLogs.Location = new System.Drawing.Point(312, 528);
            this.buttonLogs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(211, 43);
            this.buttonLogs.TabIndex = 71;
            this.buttonLogs.Text = "View Entry Logs";
            this.buttonLogs.UseVisualStyleBackColor = false;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefresh.Location = new System.Drawing.Point(1140, 518);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(111, 43);
            this.buttonRefresh.TabIndex = 72;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.title.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(64, 65);
            this.title.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(1187, 65);
            this.title.TabIndex = 62;
            this.title.Text = "    Staff Status";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.title.UseVisualStyleBackColor = false;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonShowAll.ForeColor = System.Drawing.Color.White;
            this.buttonShowAll.Location = new System.Drawing.Point(78, 528);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(211, 43);
            this.buttonShowAll.TabIndex = 60;
            this.buttonShowAll.Text = "All Staff Members";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(1011, 518);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 43);
            this.buttonSave.TabIndex = 73;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 703);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLogs);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.title);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.locationLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox locationComboBx;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button title;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonSave;
    }
}