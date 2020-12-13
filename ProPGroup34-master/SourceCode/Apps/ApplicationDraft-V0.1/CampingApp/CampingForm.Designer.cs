namespace CampingApp
{
    partial class CampingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.btnClearAllCheckIn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbxCheckInMessage = new System.Windows.Forms.ListBox();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.statusIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnClearAllMonitor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMonitorMessage = new System.Windows.Forms.ListBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.dataGridViewCamp = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxResrvID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.btnClearCheckoutMessage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxCheckoutMessage = new System.Windows.Forms.ListBox();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 640);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(166, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 758);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBtn.Image")));
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(11, 181);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(155, 54);
            this.checkoutBtn.TabIndex = 14;
            this.checkoutBtn.Text = "  Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // checkinBtn
            // 
            this.checkinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.White;
            this.checkinBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBtn.Image")));
            this.checkinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBtn.Location = new System.Drawing.Point(11, 89);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(155, 54);
            this.checkinBtn.TabIndex = 12;
            this.checkinBtn.Text = "Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(11, 271);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(155, 54);
            this.monitorBtn.TabIndex = 13;
            this.monitorBtn.Text = "    Monitoring";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.btnClearAllCheckIn);
            this.checkinPanel.Controls.Add(this.groupBox3);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.statusIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.buttonPay);
            this.checkinPanel.Location = new System.Drawing.Point(161, 0);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1105, 687);
            this.checkinPanel.TabIndex = 5;
            // 
            // btnClearAllCheckIn
            // 
            this.btnClearAllCheckIn.Location = new System.Drawing.Point(276, 593);
            this.btnClearAllCheckIn.Name = "btnClearAllCheckIn";
            this.btnClearAllCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllCheckIn.TabIndex = 29;
            this.btnClearAllCheckIn.Text = "ClearAll";
            this.btnClearAllCheckIn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbxCheckInMessage);
            this.groupBox3.Location = new System.Drawing.Point(58, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 125);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LogMessage";
            // 
            // lbxCheckInMessage
            // 
            this.lbxCheckInMessage.FormattingEnabled = true;
            this.lbxCheckInMessage.Location = new System.Drawing.Point(21, 19);
            this.lbxCheckInMessage.Name = "lbxCheckInMessage";
            this.lbxCheckInMessage.Size = new System.Drawing.Size(567, 82);
            this.lbxCheckInMessage.TabIndex = 0;
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckIn.ForeColor = System.Drawing.Color.DimGray;
            this.lbCheckIn.Location = new System.Drawing.Point(248, 137);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(132, 23);
            this.lbCheckIn.TabIndex = 27;
            this.lbCheckIn.Text = "Tag Number";
            // 
            // statusIn
            // 
            this.statusIn.BackColor = System.Drawing.Color.White;
            this.statusIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusIn.ForeColor = System.Drawing.Color.DimGray;
            this.statusIn.Image = ((System.Drawing.Image)(resources.GetObject("statusIn.Image")));
            this.statusIn.Location = new System.Drawing.Point(166, 275);
            this.statusIn.Name = "statusIn";
            this.statusIn.Size = new System.Drawing.Size(33, 25);
            this.statusIn.TabIndex = 26;
            this.statusIn.Text = "      ";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(66, 276);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(95, 23);
            this.labelStatusIn.TabIndex = 25;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(69, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 124);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPay.Location = new System.Drawing.Point(70, 306);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(130, 34);
            this.buttonPay.TabIndex = 10;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.btnClearAllMonitor);
            this.searchPanel.Controls.Add(this.groupBox1);
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.buttonSaveChanges);
            this.searchPanel.Controls.Add(this.dataGridViewCamp);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Controls.Add(this.textBoxResrvID);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Location = new System.Drawing.Point(183, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1476, 687);
            this.searchPanel.TabIndex = 6;
            // 
            // btnClearAllMonitor
            // 
            this.btnClearAllMonitor.Location = new System.Drawing.Point(254, 610);
            this.btnClearAllMonitor.Name = "btnClearAllMonitor";
            this.btnClearAllMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllMonitor.TabIndex = 30;
            this.btnClearAllMonitor.Text = "ClearAll";
            this.btnClearAllMonitor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMonitorMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogMessage";
            // 
            // lbMonitorMessage
            // 
            this.lbMonitorMessage.FormattingEnabled = true;
            this.lbMonitorMessage.Location = new System.Drawing.Point(15, 19);
            this.lbMonitorMessage.Name = "lbMonitorMessage";
            this.lbMonitorMessage.Size = new System.Drawing.Size(798, 69);
            this.lbMonitorMessage.TabIndex = 0;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(33, 106);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 22);
            this.labelMonitor.TabIndex = 28;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(127, 203);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(61, 23);
            this.buttonSaveChanges.TabIndex = 18;
            this.buttonSaveChanges.Text = "Save";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // dataGridViewCamp
            // 
            this.dataGridViewCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamp.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCamp.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCamp.Name = "dataGridViewCamp";
            this.dataGridViewCamp.RowTemplate.Height = 24;
            this.dataGridViewCamp.Size = new System.Drawing.Size(938, 266);
            this.dataGridViewCamp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Monitor";
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
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(235, 65);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(27, 30);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxResrvID
            // 
            this.textBoxResrvID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResrvID.Location = new System.Drawing.Point(37, 69);
            this.textBoxResrvID.Name = "textBoxResrvID";
            this.textBoxResrvID.Size = new System.Drawing.Size(188, 22);
            this.textBoxResrvID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(32, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enter Reservation ID ";
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.btnClearCheckoutMessage);
            this.checkoutPanel.Controls.Add(this.groupBox2);
            this.checkoutPanel.Controls.Add(this.lbCheckOut);
            this.checkoutPanel.Controls.Add(this.label6);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Controls.Add(this.pictureBox1);
            this.checkoutPanel.Location = new System.Drawing.Point(166, 12);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1105, 687);
            this.checkoutPanel.TabIndex = 7;
            // 
            // btnClearCheckoutMessage
            // 
            this.btnClearCheckoutMessage.Location = new System.Drawing.Point(386, 601);
            this.btnClearCheckoutMessage.Name = "btnClearCheckoutMessage";
            this.btnClearCheckoutMessage.Size = new System.Drawing.Size(75, 23);
            this.btnClearCheckoutMessage.TabIndex = 38;
            this.btnClearCheckoutMessage.Text = "ClearAll";
            this.btnClearCheckoutMessage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxCheckoutMessage);
            this.groupBox2.Location = new System.Drawing.Point(164, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 116);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LogMessage";
            // 
            // lbxCheckoutMessage
            // 
            this.lbxCheckoutMessage.FormattingEnabled = true;
            this.lbxCheckoutMessage.Location = new System.Drawing.Point(18, 19);
            this.lbxCheckoutMessage.Name = "lbxCheckoutMessage";
            this.lbxCheckoutMessage.Size = new System.Drawing.Size(547, 82);
            this.lbxCheckoutMessage.TabIndex = 0;
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckOut.ForeColor = System.Drawing.Color.DimGray;
            this.lbCheckOut.Location = new System.Drawing.Point(329, 246);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(132, 23);
            this.lbCheckOut.TabIndex = 36;
            this.lbCheckOut.Text = "Tag Number";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(268, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "      ";
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(167, 385);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(95, 23);
            this.labelStatusOut.TabIndex = 34;
            this.labelStatusOut.Text = "STATUS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(170, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 124);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 10);
            this.panel2.TabIndex = 1;
            // 
            // CampingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CampingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CampingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamp)).EndInit();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Label statusIn;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridView dataGridViewCamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxResrvID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearAllCheckIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxCheckInMessage;
        private System.Windows.Forms.Button btnClearAllMonitor;
        private System.Windows.Forms.ListBox lbMonitorMessage;
        private System.Windows.Forms.Button btnClearCheckoutMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxCheckoutMessage;
    }
}

