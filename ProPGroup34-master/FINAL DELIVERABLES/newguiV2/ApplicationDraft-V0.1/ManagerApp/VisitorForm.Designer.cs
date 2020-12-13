namespace ManagerApp
{
    partial class VisitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSave = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.searchLbl = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.LogsBtn = new System.Windows.Forms.Button();
            this.labelTotalVisitors = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            this.chartVisitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.buttonPresent = new System.Windows.Forms.Button();
            this.tagRbtn = new System.Windows.Forms.RadioButton();
            this.buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(52, 61);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(890, 53);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "    VISITOR STATUS";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
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
            this.homeBtn.Location = new System.Drawing.Point(948, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 62;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(48, 144);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(98, 17);
            this.searchLbl.TabIndex = 66;
            this.searchLbl.Text = "Search Visitor:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(342, 141);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 29);
            this.textBoxSearch.TabIndex = 64;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(599, 141);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(38, 29);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Location = new System.Drawing.Point(52, 493);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(110, 34);
            this.viewAllBtn.TabIndex = 70;
            this.viewAllBtn.Text = "All Visitors";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // LogsBtn
            // 
            this.LogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.LogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsBtn.ForeColor = System.Drawing.Color.White;
            this.LogsBtn.Location = new System.Drawing.Point(408, 493);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Size = new System.Drawing.Size(140, 34);
            this.LogsBtn.TabIndex = 71;
            this.LogsBtn.Text = "Transaction logs";
            this.LogsBtn.UseVisualStyleBackColor = false;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // labelTotalVisitors
            // 
            this.labelTotalVisitors.AutoSize = true;
            this.labelTotalVisitors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVisitors.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalVisitors.Location = new System.Drawing.Point(663, 425);
            this.labelTotalVisitors.Name = "labelTotalVisitors";
            this.labelTotalVisitors.Size = new System.Drawing.Size(99, 21);
            this.labelTotalVisitors.TabIndex = 65;
            this.labelTotalVisitors.Text = "Total visitors:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(561, 493);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(77, 34);
            this.refreshBtn.TabIndex = 68;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewVisitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVisitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVisitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(52, 179);
            this.dataGridViewVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.ReadOnly = true;
            this.dataGridViewVisitor.RowTemplate.Height = 24;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(586, 297);
            this.dataGridViewVisitor.TabIndex = 72;
            // 
            // chartVisitor
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVisitor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVisitor.Legends.Add(legend1);
            this.chartVisitor.Location = new System.Drawing.Point(666, 179);
            this.chartVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.chartVisitor.Name = "chartVisitor";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Visitors";
            this.chartVisitor.Series.Add(series1);
            this.chartVisitor.Size = new System.Drawing.Size(276, 225);
            this.chartVisitor.TabIndex = 73;
            this.chartVisitor.Text = "chartVisitors";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBalance.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalBalance.Location = new System.Drawing.Point(662, 456);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(102, 21);
            this.labelTotalBalance.TabIndex = 76;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRbtn.Location = new System.Drawing.Point(173, 144);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(61, 21);
            this.nameRbtn.TabIndex = 78;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // buttonPresent
            // 
            this.buttonPresent.BackColor = System.Drawing.Color.DimGray;
            this.buttonPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresent.ForeColor = System.Drawing.Color.White;
            this.buttonPresent.Location = new System.Drawing.Point(167, 493);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(125, 34);
            this.buttonPresent.TabIndex = 80;
            this.buttonPresent.Text = "Present visitors";
            this.buttonPresent.UseVisualStyleBackColor = false;
            this.buttonPresent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagRbtn.Location = new System.Drawing.Point(252, 144);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(66, 21);
            this.tagRbtn.TabIndex = 79;
            this.tagRbtn.Text = "Tag nr.";
            this.tagRbtn.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.DimGray;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Location = new System.Drawing.Point(299, 493);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(104, 34);
            this.buttonLeft.TabIndex = 81;
            this.buttonLeft.Text = "Left visitors";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonPresent);
            this.Controls.Add(this.tagRbtn);
            this.Controls.Add(this.nameRbtn);
            this.Controls.Add(this.labelTotalBalance);
            this.Controls.Add(this.chartVisitor);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.LogsBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.labelTotalVisitors);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VisitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button LogsBtn;
        private System.Windows.Forms.Label labelTotalVisitors;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisitor;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Button buttonPresent;
        private System.Windows.Forms.RadioButton tagRbtn;
        private System.Windows.Forms.Button buttonLeft;
    }
}