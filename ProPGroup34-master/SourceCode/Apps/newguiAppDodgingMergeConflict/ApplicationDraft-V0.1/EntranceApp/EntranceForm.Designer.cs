namespace EntranceApp
{
    partial class EntranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkinBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.monitorBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkinPanel = new System.Windows.Forms.Panel();
            this.labelEntrance = new System.Windows.Forms.Label();
            this.checkinOverrideBtn = new System.Windows.Forms.Button();
            this.checkinInfoLbx = new System.Windows.Forms.ListBox();
            this.checkinMessageLbl = new System.Windows.Forms.Label();
            this.checkinStatusLbl = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.labelStatusIn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonStartWC = new System.Windows.Forms.Button();
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.checkoutOverrideBtn = new System.Windows.Forms.Button();
            this.checkoutDetailsBtn = new System.Windows.Forms.Button();
            this.checkoutInfoLbx = new System.Windows.Forms.ListBox();
            this.checkoutMessageLbl = new System.Windows.Forms.Label();
            this.checkoutStatusLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelStatusOut = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.tagRbtn = new System.Windows.Forms.RadioButton();
            this.checkoutLogsBtn = new System.Windows.Forms.Button();
            this.checkinLogsBtn = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.ticketRbtn = new System.Windows.Forms.RadioButton();
            this.nameRbtn = new System.Windows.Forms.RadioButton();
            this.searchLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.webCamTimer = new System.Windows.Forms.Timer(this.components);
            this.userDetailsBtn = new System.Windows.Forms.Button();
            this.checkinHistoryBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.checkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            this.checkoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.checkinBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.monitorBtn);
            this.panel1.Controls.Add(this.checkoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 788);
            this.panel1.TabIndex = 0;
            // 
            // checkinBtn
            // 
            this.checkinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinBtn.ForeColor = System.Drawing.Color.White;
            this.checkinBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkinBtn.Image")));
            this.checkinBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinBtn.Location = new System.Drawing.Point(15, 110);
            this.checkinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkinBtn.Name = "checkinBtn";
            this.checkinBtn.Size = new System.Drawing.Size(207, 91);
            this.checkinBtn.TabIndex = 9;
            this.checkinBtn.Text = " Check In";
            this.checkinBtn.UseVisualStyleBackColor = true;
            this.checkinBtn.Click += new System.EventHandler(this.checkinBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 110);
            this.sideHighlight.Margin = new System.Windows.Forms.Padding(4);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(13, 91);
            this.sideHighlight.TabIndex = 14;
            // 
            // monitorBtn
            // 
            this.monitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.monitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.monitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorBtn.ForeColor = System.Drawing.Color.White;
            this.monitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("monitorBtn.Image")));
            this.monitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monitorBtn.Location = new System.Drawing.Point(15, 364);
            this.monitorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.monitorBtn.Name = "monitorBtn";
            this.monitorBtn.Size = new System.Drawing.Size(207, 91);
            this.monitorBtn.TabIndex = 10;
            this.monitorBtn.Text = "Logs";
            this.monitorBtn.UseVisualStyleBackColor = true;
            this.monitorBtn.Click += new System.EventHandler(this.monitorBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.checkoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("checkoutBtn.Image")));
            this.checkoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutBtn.Location = new System.Drawing.Point(15, 235);
            this.checkoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(207, 91);
            this.checkoutBtn.TabIndex = 11;
            this.checkoutBtn.Text = "    Check Out";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 12);
            this.panel2.TabIndex = 1;
            // 
            // checkinPanel
            // 
            this.checkinPanel.Controls.Add(this.checkinHistoryBtn);
            this.checkinPanel.Controls.Add(this.userDetailsBtn);
            this.checkinPanel.Controls.Add(this.labelEntrance);
            this.checkinPanel.Controls.Add(this.checkinOverrideBtn);
            this.checkinPanel.Controls.Add(this.checkinInfoLbx);
            this.checkinPanel.Controls.Add(this.checkinMessageLbl);
            this.checkinPanel.Controls.Add(this.checkinStatusLbl);
            this.checkinPanel.Controls.Add(this.lbCheckIn);
            this.checkinPanel.Controls.Add(this.labelStatusIn);
            this.checkinPanel.Controls.Add(this.pictureBox2);
            this.checkinPanel.Controls.Add(this.buttonStartWC);
            this.checkinPanel.Controls.Add(this.pictureBoxSource);
            this.checkinPanel.Location = new System.Drawing.Point(235, 20);
            this.checkinPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkinPanel.Name = "checkinPanel";
            this.checkinPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkinPanel.TabIndex = 3;
            // 
            // labelEntrance
            // 
            this.labelEntrance.AutoSize = true;
            this.labelEntrance.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEntrance.Location = new System.Drawing.Point(46, 44);
            this.labelEntrance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntrance.Name = "labelEntrance";
            this.labelEntrance.Size = new System.Drawing.Size(237, 46);
            this.labelEntrance.TabIndex = 62;
            this.labelEntrance.Text = "ENTRANCE";
            // 
            // checkinOverrideBtn
            // 
            this.checkinOverrideBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinOverrideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinOverrideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinOverrideBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkinOverrideBtn.ForeColor = System.Drawing.Color.White;
            this.checkinOverrideBtn.Location = new System.Drawing.Point(793, 661);
            this.checkinOverrideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkinOverrideBtn.Name = "checkinOverrideBtn";
            this.checkinOverrideBtn.Size = new System.Drawing.Size(231, 64);
            this.checkinOverrideBtn.TabIndex = 58;
            this.checkinOverrideBtn.Text = "Override";
            this.checkinOverrideBtn.UseVisualStyleBackColor = false;
            this.checkinOverrideBtn.Click += new System.EventHandler(this.checkinOverrideBtn_Click);
            // 
            // checkinInfoLbx
            // 
            this.checkinInfoLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinInfoLbx.FormattingEnabled = true;
            this.checkinInfoLbx.ItemHeight = 25;
            this.checkinInfoLbx.Location = new System.Drawing.Point(53, 504);
            this.checkinInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.checkinInfoLbx.Name = "checkinInfoLbx";
            this.checkinInfoLbx.Size = new System.Drawing.Size(718, 229);
            this.checkinInfoLbx.TabIndex = 57;
            // 
            // checkinMessageLbl
            // 
            this.checkinMessageLbl.AutoSize = true;
            this.checkinMessageLbl.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkinMessageLbl.ForeColor = System.Drawing.Color.Gray;
            this.checkinMessageLbl.Location = new System.Drawing.Point(411, 328);
            this.checkinMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinMessageLbl.Name = "checkinMessageLbl";
            this.checkinMessageLbl.Size = new System.Drawing.Size(106, 24);
            this.checkinMessageLbl.TabIndex = 55;
            this.checkinMessageLbl.Text = "(message)";
            // 
            // checkinStatusLbl
            // 
            this.checkinStatusLbl.AutoSize = true;
            this.checkinStatusLbl.Font = new System.Drawing.Font("Roboto Black", 16F);
            this.checkinStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkinStatusLbl.Location = new System.Drawing.Point(544, 276);
            this.checkinStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinStatusLbl.Name = "checkinStatusLbl";
            this.checkinStatusLbl.Size = new System.Drawing.Size(135, 33);
            this.checkinStatusLbl.TabIndex = 56;
            this.checkinStatusLbl.Text = "(OK/NOK)";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbCheckIn.ForeColor = System.Drawing.Color.DimGray;
            this.lbCheckIn.Location = new System.Drawing.Point(622, 116);
            this.lbCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(104, 24);
            this.lbCheckIn.TabIndex = 37;
            this.lbCheckIn.Text = "Ticket info";
            // 
            // labelStatusIn
            // 
            this.labelStatusIn.AutoSize = true;
            this.labelStatusIn.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelStatusIn.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusIn.Location = new System.Drawing.Point(409, 280);
            this.labelStatusIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusIn.Name = "labelStatusIn";
            this.labelStatusIn.Size = new System.Drawing.Size(112, 33);
            this.labelStatusIn.TabIndex = 20;
            this.labelStatusIn.Text = "STATUS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(407, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 153);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // buttonStartWC
            // 
            this.buttonStartWC.BackColor = System.Drawing.Color.DimGray;
            this.buttonStartWC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartWC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartWC.Font = new System.Drawing.Font("Roboto", 12F);
            this.buttonStartWC.ForeColor = System.Drawing.Color.White;
            this.buttonStartWC.Location = new System.Drawing.Point(53, 374);
            this.buttonStartWC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartWC.Name = "buttonStartWC";
            this.buttonStartWC.Size = new System.Drawing.Size(284, 64);
            this.buttonStartWC.TabIndex = 3;
            this.buttonStartWC.Text = "Start QR Scanner";
            this.buttonStartWC.UseVisualStyleBackColor = false;
            this.buttonStartWC.Click += new System.EventHandler(this.buttonStartWC_Click);
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(53, 108);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(284, 244);
            this.pictureBoxSource.TabIndex = 2;
            this.pictureBoxSource.TabStop = false;
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Controls.Add(this.labelExit);
            this.checkoutPanel.Controls.Add(this.checkoutOverrideBtn);
            this.checkoutPanel.Controls.Add(this.checkoutDetailsBtn);
            this.checkoutPanel.Controls.Add(this.checkoutInfoLbx);
            this.checkoutPanel.Controls.Add(this.checkoutMessageLbl);
            this.checkoutPanel.Controls.Add(this.checkoutStatusLbl);
            this.checkoutPanel.Controls.Add(this.pictureBox3);
            this.checkoutPanel.Controls.Add(this.labelStatusOut);
            this.checkoutPanel.Location = new System.Drawing.Point(235, 20);
            this.checkoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(1473, 846);
            this.checkoutPanel.TabIndex = 4;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.DarkRed;
            this.labelExit.Location = new System.Drawing.Point(56, 67);
            this.labelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(114, 46);
            this.labelExit.TabIndex = 63;
            this.labelExit.Text = "EXIT";
            // 
            // checkoutOverrideBtn
            // 
            this.checkoutOverrideBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutOverrideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutOverrideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutOverrideBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutOverrideBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutOverrideBtn.Location = new System.Drawing.Point(655, 232);
            this.checkoutOverrideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutOverrideBtn.Name = "checkoutOverrideBtn";
            this.checkoutOverrideBtn.Size = new System.Drawing.Size(220, 58);
            this.checkoutOverrideBtn.TabIndex = 47;
            this.checkoutOverrideBtn.Text = "Override";
            this.checkoutOverrideBtn.UseVisualStyleBackColor = false;
            this.checkoutOverrideBtn.Click += new System.EventHandler(this.checkoutOverrideBtn_Click);
            // 
            // checkoutDetailsBtn
            // 
            this.checkoutDetailsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutDetailsBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutDetailsBtn.Location = new System.Drawing.Point(403, 232);
            this.checkoutDetailsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutDetailsBtn.Name = "checkoutDetailsBtn";
            this.checkoutDetailsBtn.Size = new System.Drawing.Size(232, 58);
            this.checkoutDetailsBtn.TabIndex = 49;
            this.checkoutDetailsBtn.Text = "Visitor details";
            this.checkoutDetailsBtn.UseVisualStyleBackColor = false;
            this.checkoutDetailsBtn.Click += new System.EventHandler(this.checkoutDetailsBtn_Click);
            // 
            // checkoutInfoLbx
            // 
            this.checkoutInfoLbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutInfoLbx.FormattingEnabled = true;
            this.checkoutInfoLbx.ItemHeight = 25;
            this.checkoutInfoLbx.Location = new System.Drawing.Point(63, 313);
            this.checkoutInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutInfoLbx.Name = "checkoutInfoLbx";
            this.checkoutInfoLbx.Size = new System.Drawing.Size(932, 354);
            this.checkoutInfoLbx.TabIndex = 46;
            // 
            // checkoutMessageLbl
            // 
            this.checkoutMessageLbl.AutoSize = true;
            this.checkoutMessageLbl.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutMessageLbl.ForeColor = System.Drawing.Color.Gray;
            this.checkoutMessageLbl.Location = new System.Drawing.Point(410, 184);
            this.checkoutMessageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutMessageLbl.Name = "checkoutMessageLbl";
            this.checkoutMessageLbl.Size = new System.Drawing.Size(106, 24);
            this.checkoutMessageLbl.TabIndex = 43;
            this.checkoutMessageLbl.Text = "(message)";
            // 
            // checkoutStatusLbl
            // 
            this.checkoutStatusLbl.AutoSize = true;
            this.checkoutStatusLbl.Font = new System.Drawing.Font("Roboto Black", 16F);
            this.checkoutStatusLbl.ForeColor = System.Drawing.Color.DimGray;
            this.checkoutStatusLbl.Location = new System.Drawing.Point(557, 146);
            this.checkoutStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkoutStatusLbl.Name = "checkoutStatusLbl";
            this.checkoutStatusLbl.Size = new System.Drawing.Size(135, 33);
            this.checkoutStatusLbl.TabIndex = 44;
            this.checkoutStatusLbl.Text = "(OK/NOK)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(206, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 153);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // labelStatusOut
            // 
            this.labelStatusOut.AutoSize = true;
            this.labelStatusOut.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelStatusOut.ForeColor = System.Drawing.Color.DimGray;
            this.labelStatusOut.Location = new System.Drawing.Point(410, 144);
            this.labelStatusOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusOut.Name = "labelStatusOut";
            this.labelStatusOut.Size = new System.Drawing.Size(112, 33);
            this.labelStatusOut.TabIndex = 2;
            this.labelStatusOut.Text = "STATUS";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.tagRbtn);
            this.searchPanel.Controls.Add(this.checkoutLogsBtn);
            this.searchPanel.Controls.Add(this.checkinLogsBtn);
            this.searchPanel.Controls.Add(this.viewLogsBtn);
            this.searchPanel.Controls.Add(this.logsInfoLbx);
            this.searchPanel.Controls.Add(this.ticketRbtn);
            this.searchPanel.Controls.Add(this.nameRbtn);
            this.searchPanel.Controls.Add(this.searchLbl);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.textBoxSearch);
            this.searchPanel.Controls.Add(this.labelMonitor);
            this.searchPanel.Controls.Add(this.buttonSearch);
            this.searchPanel.Location = new System.Drawing.Point(235, 20);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1473, 846);
            this.searchPanel.TabIndex = 5;
            // 
            // tagRbtn
            // 
            this.tagRbtn.AutoSize = true;
            this.tagRbtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.tagRbtn.Location = new System.Drawing.Point(416, 136);
            this.tagRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.tagRbtn.Name = "tagRbtn";
            this.tagRbtn.Size = new System.Drawing.Size(90, 28);
            this.tagRbtn.TabIndex = 45;
            this.tagRbtn.TabStop = true;
            this.tagRbtn.Text = "Tag Nr";
            this.tagRbtn.UseVisualStyleBackColor = true;
            // 
            // checkoutLogsBtn
            // 
            this.checkoutLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutLogsBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkoutLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutLogsBtn.Location = new System.Drawing.Point(662, 646);
            this.checkoutLogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkoutLogsBtn.Name = "checkoutLogsBtn";
            this.checkoutLogsBtn.Size = new System.Drawing.Size(241, 49);
            this.checkoutLogsBtn.TabIndex = 42;
            this.checkoutLogsBtn.Text = "Checked Out";
            this.checkoutLogsBtn.UseVisualStyleBackColor = false;
            this.checkoutLogsBtn.Click += new System.EventHandler(this.checkoutLogsBtn_Click);
            // 
            // checkinLogsBtn
            // 
            this.checkinLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinLogsBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkinLogsBtn.ForeColor = System.Drawing.Color.White;
            this.checkinLogsBtn.Location = new System.Drawing.Point(371, 644);
            this.checkinLogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkinLogsBtn.Name = "checkinLogsBtn";
            this.checkinLogsBtn.Size = new System.Drawing.Size(241, 49);
            this.checkinLogsBtn.TabIndex = 43;
            this.checkinLogsBtn.Text = "Checked In";
            this.checkinLogsBtn.UseVisualStyleBackColor = false;
            this.checkinLogsBtn.Click += new System.EventHandler(this.checkinLogsBtn_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewLogsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewLogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogsBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.viewLogsBtn.ForeColor = System.Drawing.Color.White;
            this.viewLogsBtn.Location = new System.Drawing.Point(73, 644);
            this.viewLogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(241, 49);
            this.viewLogsBtn.TabIndex = 44;
            this.viewLogsBtn.Text = "View Logs";
            this.viewLogsBtn.UseVisualStyleBackColor = false;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 20;
            this.logsInfoLbx.Location = new System.Drawing.Point(69, 183);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(834, 444);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // ticketRbtn
            // 
            this.ticketRbtn.AutoSize = true;
            this.ticketRbtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.ticketRbtn.Location = new System.Drawing.Point(289, 136);
            this.ticketRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ticketRbtn.Name = "ticketRbtn";
            this.ticketRbtn.Size = new System.Drawing.Size(112, 28);
            this.ticketRbtn.TabIndex = 38;
            this.ticketRbtn.TabStop = true;
            this.ticketRbtn.Text = "Ticket Nr";
            this.ticketRbtn.UseVisualStyleBackColor = true;
            // 
            // nameRbtn
            // 
            this.nameRbtn.AutoSize = true;
            this.nameRbtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.nameRbtn.Location = new System.Drawing.Point(189, 136);
            this.nameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.nameRbtn.Name = "nameRbtn";
            this.nameRbtn.Size = new System.Drawing.Size(85, 28);
            this.nameRbtn.TabIndex = 39;
            this.nameRbtn.TabStop = true;
            this.nameRbtn.Text = "Name";
            this.nameRbtn.UseVisualStyleBackColor = true;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Font = new System.Drawing.Font("Roboto", 16F);
            this.searchLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchLbl.Location = new System.Drawing.Point(67, 133);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(105, 33);
            this.searchLbl.TabIndex = 36;
            this.searchLbl.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(67, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 46);
            this.label4.TabIndex = 33;
            this.label4.Text = "Entrance Logs";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(563, 137);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(259, 29);
            this.textBoxSearch.TabIndex = 30;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(48, 90);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 29;
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
            this.buttonSearch.Location = new System.Drawing.Point(844, 135);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 32);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // webCamTimer
            // 
            this.webCamTimer.Tick += new System.EventHandler(this.webCamTimer_Tick);
            // 
            // userDetailsBtn
            // 
            this.userDetailsBtn.BackColor = System.Drawing.Color.DimGray;
            this.userDetailsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDetailsBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.userDetailsBtn.ForeColor = System.Drawing.Color.White;
            this.userDetailsBtn.Location = new System.Drawing.Point(793, 517);
            this.userDetailsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.userDetailsBtn.Name = "userDetailsBtn";
            this.userDetailsBtn.Size = new System.Drawing.Size(231, 64);
            this.userDetailsBtn.TabIndex = 64;
            this.userDetailsBtn.Text = "Visitor Details";
            this.userDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // checkinHistoryBtn
            // 
            this.checkinHistoryBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkinHistoryBtn.Enabled = false;
            this.checkinHistoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkinHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinHistoryBtn.Font = new System.Drawing.Font("Roboto", 12F);
            this.checkinHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.checkinHistoryBtn.Location = new System.Drawing.Point(793, 589);
            this.checkinHistoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkinHistoryBtn.Name = "checkinHistoryBtn";
            this.checkinHistoryBtn.Size = new System.Drawing.Size(231, 64);
            this.checkinHistoryBtn.TabIndex = 65;
            this.checkinHistoryBtn.Text = "Check History";
            this.checkinHistoryBtn.UseVisualStyleBackColor = false;
            // 
            // EntranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.checkinPanel);
            this.Controls.Add(this.checkoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntranceForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.panel1.ResumeLayout(false);
            this.checkinPanel.ResumeLayout(false);
            this.checkinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button checkinBtn;
        private System.Windows.Forms.Button monitorBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Panel checkinPanel;
        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.Label labelStatusOut;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelStatusIn;
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.Button buttonStartWC;
        private System.Windows.Forms.Timer webCamTimer;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Button checkinOverrideBtn;
        private System.Windows.Forms.Label checkinMessageLbl;
        private System.Windows.Forms.Label checkinStatusLbl;
        private System.Windows.Forms.Button checkoutOverrideBtn;
        private System.Windows.Forms.Button checkoutDetailsBtn;
        private System.Windows.Forms.ListBox checkoutInfoLbx;
        private System.Windows.Forms.Label checkoutMessageLbl;
        private System.Windows.Forms.Label checkoutStatusLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button checkoutLogsBtn;
        private System.Windows.Forms.Button checkinLogsBtn;
        private System.Windows.Forms.Button viewLogsBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.RadioButton ticketRbtn;
        private System.Windows.Forms.RadioButton nameRbtn;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton tagRbtn;
        private System.Windows.Forms.Label labelEntrance;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ListBox checkinInfoLbx;
        private System.Windows.Forms.Button checkinHistoryBtn;
        private System.Windows.Forms.Button userDetailsBtn;
    }
}

