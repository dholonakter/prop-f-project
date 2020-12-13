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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(69, 116);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(1187, 65);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "    Visitors status";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1197, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 52);
            this.button7.TabIndex = 61;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
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
            this.homeBtn.Location = new System.Drawing.Point(1264, 15);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 52);
            this.homeBtn.TabIndex = 62;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Roboto", 12F);
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(79, 209);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(140, 24);
            this.searchLbl.TabIndex = 66;
            this.searchLbl.Text = "Search Visitor:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(519, 209);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(273, 22);
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
            this.buttonSearch.Location = new System.Drawing.Point(814, 209);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 22);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Location = new System.Drawing.Point(84, 635);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(146, 42);
            this.viewAllBtn.TabIndex = 70;
            this.viewAllBtn.Text = "All Visitors";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // LogsBtn
            // 
            this.LogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.LogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.LogsBtn.ForeColor = System.Drawing.Color.White;
            this.LogsBtn.Location = new System.Drawing.Point(559, 635);
            this.LogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Size = new System.Drawing.Size(186, 42);
            this.LogsBtn.TabIndex = 71;
            this.LogsBtn.Text = "Transaction logs";
            this.LogsBtn.UseVisualStyleBackColor = false;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // labelTotalVisitors
            // 
            this.labelTotalVisitors.AutoSize = true;
            this.labelTotalVisitors.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.labelTotalVisitors.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalVisitors.Location = new System.Drawing.Point(895, 547);
            this.labelTotalVisitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalVisitors.Name = "labelTotalVisitors";
            this.labelTotalVisitors.Size = new System.Drawing.Size(129, 24);
            this.labelTotalVisitors.TabIndex = 65;
            this.labelTotalVisitors.Text = "Total visitors:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.refreshBtn.Location = new System.Drawing.Point(762, 635);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(103, 42);
            this.refreshBtn.TabIndex = 68;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewVisitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVisitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVisitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(84, 249);
            this.dataGridViewVisitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowTemplate.Height = 24;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(781, 366);
            this.dataGridViewVisitor.TabIndex = 72;
            // 
            // chartVisitor
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVisitor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVisitor.Legends.Add(legend2);
            this.chartVisitor.Location = new System.Drawing.Point(888, 249);
            this.chartVisitor.Name = "chartVisitor";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Visitors";
            this.chartVisitor.Series.Add(series2);
            this.chartVisitor.Size = new System.Drawing.Size(368, 277);
            this.chartVisitor.TabIndex = 73;
            this.chartVisitor.Text = "chartVisitors";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.labelTotalBalance.ForeColor = System.Drawing.Color.DimGray;
            this.labelTotalBalance.Location = new System.Drawing.Point(894, 585);
            this.labelTotalBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(134, 24);
            this.labelTotalBalance.TabIndex = 76;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.nameRbtn.Location = new System.Drawing.Point(246, 209);
            this.nameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(75, 24);
            this.nameRbtn.TabIndex = 78;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // buttonPresent
            // 
            this.buttonPresent.BackColor = System.Drawing.Color.DimGray;
            this.buttonPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresent.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonPresent.ForeColor = System.Drawing.Color.White;
            this.buttonPresent.Location = new System.Drawing.Point(238, 635);
            this.buttonPresent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(167, 42);
            this.buttonPresent.TabIndex = 80;
            this.buttonPresent.Text = "Present visitors";
            this.buttonPresent.UseVisualStyleBackColor = false;
            this.buttonPresent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.tagRbtn.Location = new System.Drawing.Point(351, 209);
            this.tagRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(80, 24);
            this.tagRbtn.TabIndex = 79;
            this.tagRbtn.Text = "Tag nr.";
            this.tagRbtn.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.DimGray;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Location = new System.Drawing.Point(413, 635);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(138, 42);
            this.buttonLeft.TabIndex = 81;
            this.buttonLeft.Text = "Left visitors";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 732);
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
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VisitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button7;
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