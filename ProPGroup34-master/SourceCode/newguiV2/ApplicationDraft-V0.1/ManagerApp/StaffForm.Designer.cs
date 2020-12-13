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
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLbl.ForeColor = System.Drawing.Color.DimGray;
            this.locationLbl.Location = new System.Drawing.Point(44, 136);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(89, 21);
            this.locationLbl.TabIndex = 1;
            this.locationLbl.Text = "Select job:";
            // 
            // locationComboBx
            // 
            this.locationComboBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBx.FormattingEnabled = true;
            this.locationComboBx.Location = new System.Drawing.Point(137, 133);
            this.locationComboBx.Margin = new System.Windows.Forms.Padding(2);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(207, 29);
            this.locationComboBx.TabIndex = 2;
            this.locationComboBx.SelectedIndexChanged += new System.EventHandler(this.locationComboBx_SelectedIndexChanged);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(48, 177);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.ReadOnly = true;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(890, 314);
            this.dataGridViewStaff.TabIndex = 70;
            // 
            // buttonLogs
            // 
            this.buttonLogs.BackColor = System.Drawing.Color.DimGray;
            this.buttonLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogs.ForeColor = System.Drawing.Color.White;
            this.buttonLogs.Location = new System.Drawing.Point(212, 507);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(158, 35);
            this.buttonLogs.TabIndex = 71;
            this.buttonLogs.Text = "View Entry Logs";
            this.buttonLogs.UseVisualStyleBackColor = false;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.Location = new System.Drawing.Point(855, 507);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(83, 35);
            this.buttonRefresh.TabIndex = 72;
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
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(48, 53);
            this.title.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.title.Size = new System.Drawing.Size(890, 53);
            this.title.TabIndex = 62;
            this.title.Text = "    STAFF STATUS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.title.UseVisualStyleBackColor = false;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.White;
            this.buttonShowAll.Location = new System.Drawing.Point(48, 507);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(158, 35);
            this.buttonShowAll.TabIndex = 60;
            this.buttonShowAll.Text = "All Staff Members";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(949, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 74;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonLogs);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.title);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.locationLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button homeBtn;
    }
}