namespace RentalApp
{
    partial class RentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.currentBtn = new System.Windows.Forms.Button();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.personNrRbtn = new System.Windows.Forms.RadioButton();
            this.personNameRbtn = new System.Windows.Forms.RadioButton();
            this.itemNrRbtn = new System.Windows.Forms.RadioButton();
            this.itemNameRbtn = new System.Windows.Forms.RadioButton();
            this.searchLbl = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.borrowPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelMessageB = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelBorrowInfo = new System.Windows.Forms.Label();
            this.labelVisitorB = new System.Windows.Forms.Label();
            this.loanInfoLbx = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelInfoR = new System.Windows.Forms.Label();
            this.labelMessageR = new System.Windows.Forms.Label();
            this.returnLbx = new System.Windows.Forms.ListBox();
            this.returnPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVisitorR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.borrowPanel.SuspendLayout();
            this.returnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.borrowBtn);
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 788);
            this.panel1.TabIndex = 0;
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
            this.homeBtn.Location = new System.Drawing.Point(3, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 53;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(12, 289);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 74);
            this.monitorBtn.TabIndex = 22;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(10, 74);
            this.sideHighlight.TabIndex = 14;
            // 
            // borrowBtn
            // 
            this.borrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.borrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowBtn.Image")));
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(12, 89);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(155, 74);
            this.borrowBtn.TabIndex = 20;
            this.borrowBtn.Text = "Loaning";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(12, 189);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(155, 74);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "   Returning";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 8);
            this.panel2.TabIndex = 1;
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.label8);
            this.startPanel.Controls.Add(this.currentBtn);
            this.startPanel.Controls.Add(this.viewAllBtn);
            this.startPanel.Controls.Add(this.viewLogsBtn);
            this.startPanel.Controls.Add(this.logsInfoLbx);
            this.startPanel.Controls.Add(this.personNrRbtn);
            this.startPanel.Controls.Add(this.personNameRbtn);
            this.startPanel.Controls.Add(this.itemNrRbtn);
            this.startPanel.Controls.Add(this.itemNameRbtn);
            this.startPanel.Controls.Add(this.searchLbl);
            this.startPanel.Controls.Add(this.textBoxSearch);
            this.startPanel.Controls.Add(this.buttonSearch);
            this.startPanel.Location = new System.Drawing.Point(184, 57);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1398, 846);
            this.startPanel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(85, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 45);
            this.label8.TabIndex = 67;
            this.label8.Text = "RENTAL LOGS";
            // 
            // currentBtn
            // 
            this.currentBtn.BackColor = System.Drawing.Color.DimGray;
            this.currentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.currentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.currentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBtn.ForeColor = System.Drawing.Color.White;
            this.currentBtn.Location = new System.Drawing.Point(525, 587);
            this.currentBtn.Name = "currentBtn";
            this.currentBtn.Size = new System.Drawing.Size(194, 54);
            this.currentBtn.TabIndex = 55;
            this.currentBtn.Text = "Currently Loaning";
            this.currentBtn.UseVisualStyleBackColor = false;
            this.currentBtn.Click += new System.EventHandler(this.currentBtn_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewAllBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.viewAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Location = new System.Drawing.Point(93, 587);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(194, 54);
            this.viewAllBtn.TabIndex = 56;
            this.viewAllBtn.Text = "View All Items";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewLogsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.viewLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogsBtn.ForeColor = System.Drawing.Color.White;
            this.viewLogsBtn.Location = new System.Drawing.Point(308, 587);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(194, 54);
            this.viewLogsBtn.TabIndex = 57;
            this.viewLogsBtn.Text = "View Item\'s History";
            this.viewLogsBtn.UseVisualStyleBackColor = false;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 16;
            this.logsInfoLbx.Location = new System.Drawing.Point(93, 211);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(932, 340);
            this.logsInfoLbx.TabIndex = 53;
            // 
            // personNrRbtn
            // 
            this.personNrRbtn.AutoSize = true;
            this.personNrRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNrRbtn.Location = new System.Drawing.Point(516, 148);
            this.personNrRbtn.Name = "personNrRbtn";
            this.personNrRbtn.Size = new System.Drawing.Size(106, 25);
            this.personNrRbtn.TabIndex = 51;
            this.personNrRbtn.TabStop = true;
            this.personNrRbtn.Text = "Visitor\'s Nr";
            this.personNrRbtn.UseVisualStyleBackColor = true;
            // 
            // personNameRbtn
            // 
            this.personNameRbtn.AutoSize = true;
            this.personNameRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameRbtn.Location = new System.Drawing.Point(380, 148);
            this.personNameRbtn.Name = "personNameRbtn";
            this.personNameRbtn.Size = new System.Drawing.Size(130, 25);
            this.personNameRbtn.TabIndex = 52;
            this.personNameRbtn.TabStop = true;
            this.personNameRbtn.Text = "Visitor\'s Name";
            this.personNameRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNrRbtn
            // 
            this.itemNrRbtn.AutoSize = true;
            this.itemNrRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNrRbtn.Location = new System.Drawing.Point(282, 148);
            this.itemNrRbtn.Name = "itemNrRbtn";
            this.itemNrRbtn.Size = new System.Drawing.Size(92, 25);
            this.itemNrRbtn.TabIndex = 51;
            this.itemNrRbtn.TabStop = true;
            this.itemNrRbtn.Text = "Item\'s Nr";
            this.itemNrRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNameRbtn
            // 
            this.itemNameRbtn.AutoSize = true;
            this.itemNameRbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameRbtn.Location = new System.Drawing.Point(160, 148);
            this.itemNameRbtn.Name = "itemNameRbtn";
            this.itemNameRbtn.Size = new System.Drawing.Size(116, 25);
            this.itemNameRbtn.TabIndex = 52;
            this.itemNameRbtn.TabStop = true;
            this.itemNameRbtn.Text = "Item\'s Name";
            this.itemNameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(89, 148);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(65, 21);
            this.searchLbl.TabIndex = 50;
            this.searchLbl.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(627, 144);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(338, 33);
            this.textBoxSearch.TabIndex = 47;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(970, 144);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(55, 33);
            this.buttonSearch.TabIndex = 45;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // borrowPanel
            // 
            this.borrowPanel.Controls.Add(this.label7);
            this.borrowPanel.Controls.Add(this.label2);
            this.borrowPanel.Controls.Add(this.label1);
            this.borrowPanel.Controls.Add(this.returnDatePicker);
            this.borrowPanel.Controls.Add(this.labelMessageB);
            this.borrowPanel.Controls.Add(this.buttonConfirm);
            this.borrowPanel.Controls.Add(this.buttonRemove);
            this.borrowPanel.Controls.Add(this.labelBorrowInfo);
            this.borrowPanel.Controls.Add(this.labelVisitorB);
            this.borrowPanel.Controls.Add(this.loanInfoLbx);
            this.borrowPanel.Location = new System.Drawing.Point(184, 59);
            this.borrowPanel.Name = "borrowPanel";
            this.borrowPanel.Size = new System.Drawing.Size(1404, 790);
            this.borrowPanel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(82, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 45);
            this.label7.TabIndex = 67;
            this.label7.Text = "LOANING ITEMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(85, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pick Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(822, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Scan Items";
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDatePicker.Location = new System.Drawing.Point(256, 213);
            this.returnDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(188, 29);
            this.returnDatePicker.TabIndex = 52;
            this.returnDatePicker.ValueChanged += new System.EventHandler(this.returnDatePicker_ValueChanged);
            // 
            // labelMessageB
            // 
            this.labelMessageB.AutoSize = true;
            this.labelMessageB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageB.ForeColor = System.Drawing.Color.Red;
            this.labelMessageB.Location = new System.Drawing.Point(823, 294);
            this.labelMessageB.Name = "labelMessageB";
            this.labelMessageB.Size = new System.Drawing.Size(71, 21);
            this.labelMessageB.TabIndex = 51;
            this.labelMessageB.Text = "Message";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Green;
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(987, 588);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(146, 51);
            this.buttonConfirm.TabIndex = 47;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.DimGray;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(827, 588);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(146, 51);
            this.buttonRemove.TabIndex = 46;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelBorrowInfo
            // 
            this.labelBorrowInfo.AutoSize = true;
            this.labelBorrowInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrowInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelBorrowInfo.Location = new System.Drawing.Point(85, 147);
            this.labelBorrowInfo.Name = "labelBorrowInfo";
            this.labelBorrowInfo.Size = new System.Drawing.Size(117, 25);
            this.labelBorrowInfo.TabIndex = 30;
            this.labelBorrowInfo.Text = "Scan Visitor";
            // 
            // labelVisitorB
            // 
            this.labelVisitorB.AutoSize = true;
            this.labelVisitorB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorB.ForeColor = System.Drawing.Color.Black;
            this.labelVisitorB.Location = new System.Drawing.Point(86, 177);
            this.labelVisitorB.Name = "labelVisitorB";
            this.labelVisitorB.Size = new System.Drawing.Size(84, 21);
            this.labelVisitorB.TabIndex = 26;
            this.labelVisitorB.Text = "visitor info";
            // 
            // loanInfoLbx
            // 
            this.loanInfoLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanInfoLbx.FormattingEnabled = true;
            this.loanInfoLbx.ItemHeight = 21;
            this.loanInfoLbx.Location = new System.Drawing.Point(90, 257);
            this.loanInfoLbx.Name = "loanInfoLbx";
            this.loanInfoLbx.Size = new System.Drawing.Size(726, 382);
            this.loanInfoLbx.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(87, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Scan Items";
            // 
            // labelInfoR
            // 
            this.labelInfoR.AutoSize = true;
            this.labelInfoR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoR.ForeColor = System.Drawing.Color.Black;
            this.labelInfoR.Location = new System.Drawing.Point(682, 267);
            this.labelInfoR.Name = "labelInfoR";
            this.labelInfoR.Size = new System.Drawing.Size(37, 21);
            this.labelInfoR.TabIndex = 63;
            this.labelInfoR.Text = "Info";
            // 
            // labelMessageR
            // 
            this.labelMessageR.AutoSize = true;
            this.labelMessageR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageR.ForeColor = System.Drawing.Color.Red;
            this.labelMessageR.Location = new System.Drawing.Point(87, 229);
            this.labelMessageR.Name = "labelMessageR";
            this.labelMessageR.Size = new System.Drawing.Size(71, 21);
            this.labelMessageR.TabIndex = 60;
            this.labelMessageR.Text = "Message";
            // 
            // returnLbx
            // 
            this.returnLbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLbx.FormattingEnabled = true;
            this.returnLbx.ItemHeight = 21;
            this.returnLbx.Location = new System.Drawing.Point(90, 267);
            this.returnLbx.Name = "returnLbx";
            this.returnLbx.Size = new System.Drawing.Size(569, 340);
            this.returnLbx.TabIndex = 40;
            // 
            // returnPanel
            // 
            this.returnPanel.Controls.Add(this.label5);
            this.returnPanel.Controls.Add(this.labelVisitorR);
            this.returnPanel.Controls.Add(this.label3);
            this.returnPanel.Controls.Add(this.labelInfoR);
            this.returnPanel.Controls.Add(this.labelMessageR);
            this.returnPanel.Controls.Add(this.label6);
            this.returnPanel.Controls.Add(this.returnLbx);
            this.returnPanel.Location = new System.Drawing.Point(184, 57);
            this.returnPanel.Name = "returnPanel";
            this.returnPanel.Size = new System.Drawing.Size(1401, 846);
            this.returnPanel.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(83, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 45);
            this.label5.TabIndex = 66;
            this.label5.Text = "RETURNING ITEMS";
            // 
            // labelVisitorR
            // 
            this.labelVisitorR.AutoSize = true;
            this.labelVisitorR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorR.ForeColor = System.Drawing.Color.Black;
            this.labelVisitorR.Location = new System.Drawing.Point(87, 165);
            this.labelVisitorR.Name = "labelVisitorR";
            this.labelVisitorR.Size = new System.Drawing.Size(84, 21);
            this.labelVisitorR.TabIndex = 65;
            this.labelVisitorR.Text = "visitor info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(87, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Scan Visitor";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.ForeColor = System.Drawing.Color.DimGray;
            this.labelShopName.Location = new System.Drawing.Point(189, 11);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(146, 32);
            this.labelShopName.TabIndex = 31;
            this.labelShopName.Text = "Shop Name";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 788);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.returnPanel);
            this.Controls.Add(this.borrowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalForm_FormClosed);
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.borrowPanel.ResumeLayout(false);
            this.borrowPanel.PerformLayout();
            this.returnPanel.ResumeLayout(false);
            this.returnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Panel borrowPanel;
        private System.Windows.Forms.Panel returnPanel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.ListBox loanInfoLbx;
        private System.Windows.Forms.Label labelBorrowInfo;
        private System.Windows.Forms.ListBox returnLbx;
        private System.Windows.Forms.Button currentBtn;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton personNameRbtn;
        private System.Windows.Forms.RadioButton itemNrRbtn;
        private System.Windows.Forms.RadioButton itemNameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelMessageB;
        private System.Windows.Forms.Label labelMessageR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVisitorB;
        private System.Windows.Forms.Label labelInfoR;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVisitorR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton personNrRbtn;
        private System.Windows.Forms.Button homeBtn;
    }
}

