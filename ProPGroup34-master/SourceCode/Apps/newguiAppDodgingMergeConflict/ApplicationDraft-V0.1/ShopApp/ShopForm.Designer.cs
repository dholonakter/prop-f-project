﻿namespace ShopApp
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.stockBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.productLabel9 = new System.Windows.Forms.Label();
            this.productLabel10 = new System.Windows.Forms.Label();
            this.productLabel11 = new System.Windows.Forms.Label();
            this.productLabel12 = new System.Windows.Forms.Label();
            this.productLabel5 = new System.Windows.Forms.Label();
            this.productLabel6 = new System.Windows.Forms.Label();
            this.productLabel8 = new System.Windows.Forms.Label();
            this.productLabel7 = new System.Windows.Forms.Label();
            this.productLabel4 = new System.Windows.Forms.Label();
            this.productLabel3 = new System.Windows.Forms.Label();
            this.productLabel1 = new System.Windows.Forms.Label();
            this.productLabel2 = new System.Windows.Forms.Label();
            this.productButton9 = new System.Windows.Forms.Button();
            this.productButton10 = new System.Windows.Forms.Button();
            this.productButton11 = new System.Windows.Forms.Button();
            this.productButton12 = new System.Windows.Forms.Button();
            this.productButton5 = new System.Windows.Forms.Button();
            this.productButton6 = new System.Windows.Forms.Button();
            this.productButton7 = new System.Windows.Forms.Button();
            this.productButton8 = new System.Windows.Forms.Button();
            this.productButton4 = new System.Windows.Forms.Button();
            this.productButton3 = new System.Windows.Forms.Button();
            this.productButton2 = new System.Windows.Forms.Button();
            this.productButton1 = new System.Windows.Forms.Button();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.personNameRbtn = new System.Windows.Forms.RadioButton();
            this.itemNrRbtn = new System.Windows.Forms.RadioButton();
            this.itemNameRbtn = new System.Windows.Forms.RadioButton();
            this.viewStockBtn = new System.Windows.Forms.Button();
            this.viewHistoryBtn = new System.Windows.Forms.Button();
            this.logsInfoLbx = new System.Windows.Forms.ListBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.searchStockLbl = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.stockLogsLbl = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.timerScanCard = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.stockBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 788);
            this.panel1.TabIndex = 0;
            // 
            // orderBtn
            // 
            this.orderBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.orderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.White;
            this.orderBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderBtn.Image")));
            this.orderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderBtn.Location = new System.Drawing.Point(16, 110);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(207, 91);
            this.orderBtn.TabIndex = 15;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.overviewBtn_Click);
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
            // stockBtn
            // 
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.stockBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtn.ForeColor = System.Drawing.Color.White;
            this.stockBtn.Image = ((System.Drawing.Image)(resources.GetObject("stockBtn.Image")));
            this.stockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn.Location = new System.Drawing.Point(16, 235);
            this.stockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(207, 91);
            this.stockBtn.TabIndex = 17;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            // productPanel
            // 
            this.productPanel.Controls.Add(this.buttonUndo);
            this.productPanel.Controls.Add(this.buttonIncrease);
            this.productPanel.Controls.Add(this.buttonConfirm);
            this.productPanel.Controls.Add(this.buttonDecrease);
            this.productPanel.Controls.Add(this.productLabel9);
            this.productPanel.Controls.Add(this.productLabel10);
            this.productPanel.Controls.Add(this.productLabel11);
            this.productPanel.Controls.Add(this.productLabel12);
            this.productPanel.Controls.Add(this.productLabel5);
            this.productPanel.Controls.Add(this.productLabel6);
            this.productPanel.Controls.Add(this.productLabel8);
            this.productPanel.Controls.Add(this.productLabel7);
            this.productPanel.Controls.Add(this.productLabel4);
            this.productPanel.Controls.Add(this.productLabel3);
            this.productPanel.Controls.Add(this.productLabel1);
            this.productPanel.Controls.Add(this.productLabel2);
            this.productPanel.Controls.Add(this.productButton9);
            this.productPanel.Controls.Add(this.productButton10);
            this.productPanel.Controls.Add(this.productButton11);
            this.productPanel.Controls.Add(this.productButton12);
            this.productPanel.Controls.Add(this.productButton5);
            this.productPanel.Controls.Add(this.productButton6);
            this.productPanel.Controls.Add(this.productButton7);
            this.productPanel.Controls.Add(this.productButton8);
            this.productPanel.Controls.Add(this.productButton4);
            this.productPanel.Controls.Add(this.productButton3);
            this.productPanel.Controls.Add(this.productButton2);
            this.productPanel.Controls.Add(this.productButton1);
            this.productPanel.Controls.Add(this.labelOrderInfo);
            this.productPanel.Controls.Add(this.itemLbx);
            this.productPanel.Controls.Add(this.labelOrder);
            this.productPanel.Location = new System.Drawing.Point(231, 77);
            this.productPanel.Margin = new System.Windows.Forms.Padding(4);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1329, 780);
            this.productPanel.TabIndex = 4;
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.DimGray;
            this.buttonUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUndo.FlatAppearance.BorderSize = 0;
            this.buttonUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.Location = new System.Drawing.Point(962, 492);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(96, 49);
            this.buttonUndo.TabIndex = 62;
            this.buttonUndo.Text = "New  order";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.BackColor = System.Drawing.Color.White;
            this.buttonIncrease.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonIncrease.FlatAppearance.BorderSize = 3;
            this.buttonIncrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonIncrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncrease.ForeColor = System.Drawing.Color.White;
            this.buttonIncrease.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncrease.Image")));
            this.buttonIncrease.Location = new System.Drawing.Point(827, 492);
            this.buttonIncrease.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(55, 49);
            this.buttonIncrease.TabIndex = 61;
            this.buttonIncrease.UseVisualStyleBackColor = false;
            this.buttonIncrease.Click += new System.EventHandler(this.buttonIncrease_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.DimGray;
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(1066, 492);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(96, 49);
            this.buttonConfirm.TabIndex = 60;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.BackColor = System.Drawing.Color.White;
            this.buttonDecrease.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonDecrease.FlatAppearance.BorderSize = 3;
            this.buttonDecrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonDecrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrease.ForeColor = System.Drawing.Color.White;
            this.buttonDecrease.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecrease.Image")));
            this.buttonDecrease.Location = new System.Drawing.Point(890, 492);
            this.buttonDecrease.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(55, 49);
            this.buttonDecrease.TabIndex = 59;
            this.buttonDecrease.UseVisualStyleBackColor = false;
            this.buttonDecrease.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // productLabel9
            // 
            this.productLabel9.AutoSize = true;
            this.productLabel9.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel9.ForeColor = System.Drawing.Color.Black;
            this.productLabel9.Location = new System.Drawing.Point(53, 620);
            this.productLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel9.Name = "productLabel9";
            this.productLabel9.Size = new System.Drawing.Size(66, 20);
            this.productLabel9.TabIndex = 58;
            this.productLabel9.Text = "Order #";
            // 
            // productLabel10
            // 
            this.productLabel10.AutoSize = true;
            this.productLabel10.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel10.ForeColor = System.Drawing.Color.Black;
            this.productLabel10.Location = new System.Drawing.Point(245, 620);
            this.productLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel10.Name = "productLabel10";
            this.productLabel10.Size = new System.Drawing.Size(66, 20);
            this.productLabel10.TabIndex = 57;
            this.productLabel10.Text = "Order #";
            // 
            // productLabel11
            // 
            this.productLabel11.AutoSize = true;
            this.productLabel11.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel11.ForeColor = System.Drawing.Color.Black;
            this.productLabel11.Location = new System.Drawing.Point(440, 620);
            this.productLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel11.Name = "productLabel11";
            this.productLabel11.Size = new System.Drawing.Size(66, 20);
            this.productLabel11.TabIndex = 55;
            this.productLabel11.Text = "Order #";
            // 
            // productLabel12
            // 
            this.productLabel12.AutoSize = true;
            this.productLabel12.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel12.ForeColor = System.Drawing.Color.Black;
            this.productLabel12.Location = new System.Drawing.Point(635, 620);
            this.productLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel12.Name = "productLabel12";
            this.productLabel12.Size = new System.Drawing.Size(66, 20);
            this.productLabel12.TabIndex = 56;
            this.productLabel12.Text = "Order #";
            // 
            // productLabel5
            // 
            this.productLabel5.AutoSize = true;
            this.productLabel5.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel5.ForeColor = System.Drawing.Color.Black;
            this.productLabel5.Location = new System.Drawing.Point(55, 445);
            this.productLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel5.Name = "productLabel5";
            this.productLabel5.Size = new System.Drawing.Size(66, 20);
            this.productLabel5.TabIndex = 54;
            this.productLabel5.Text = "Order #";
            // 
            // productLabel6
            // 
            this.productLabel6.AutoSize = true;
            this.productLabel6.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel6.ForeColor = System.Drawing.Color.Black;
            this.productLabel6.Location = new System.Drawing.Point(248, 445);
            this.productLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel6.Name = "productLabel6";
            this.productLabel6.Size = new System.Drawing.Size(66, 20);
            this.productLabel6.TabIndex = 53;
            this.productLabel6.Text = "Order #";
            // 
            // productLabel8
            // 
            this.productLabel8.AutoSize = true;
            this.productLabel8.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel8.ForeColor = System.Drawing.Color.Black;
            this.productLabel8.Location = new System.Drawing.Point(635, 445);
            this.productLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel8.Name = "productLabel8";
            this.productLabel8.Size = new System.Drawing.Size(66, 20);
            this.productLabel8.TabIndex = 51;
            this.productLabel8.Text = "Order #";
            // 
            // productLabel7
            // 
            this.productLabel7.AutoSize = true;
            this.productLabel7.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel7.ForeColor = System.Drawing.Color.Black;
            this.productLabel7.Location = new System.Drawing.Point(437, 445);
            this.productLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel7.Name = "productLabel7";
            this.productLabel7.Size = new System.Drawing.Size(66, 20);
            this.productLabel7.TabIndex = 52;
            this.productLabel7.Text = "Order #";
            // 
            // productLabel4
            // 
            this.productLabel4.AutoSize = true;
            this.productLabel4.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel4.ForeColor = System.Drawing.Color.Black;
            this.productLabel4.Location = new System.Drawing.Point(632, 255);
            this.productLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel4.Name = "productLabel4";
            this.productLabel4.Size = new System.Drawing.Size(66, 20);
            this.productLabel4.TabIndex = 50;
            this.productLabel4.Text = "Order #";
            // 
            // productLabel3
            // 
            this.productLabel3.AutoSize = true;
            this.productLabel3.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel3.ForeColor = System.Drawing.Color.Black;
            this.productLabel3.Location = new System.Drawing.Point(440, 255);
            this.productLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel3.Name = "productLabel3";
            this.productLabel3.Size = new System.Drawing.Size(66, 20);
            this.productLabel3.TabIndex = 49;
            this.productLabel3.Text = "Order #";
            // 
            // productLabel1
            // 
            this.productLabel1.AutoSize = true;
            this.productLabel1.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel1.ForeColor = System.Drawing.Color.Black;
            this.productLabel1.Location = new System.Drawing.Point(55, 255);
            this.productLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel1.Name = "productLabel1";
            this.productLabel1.Size = new System.Drawing.Size(66, 20);
            this.productLabel1.TabIndex = 47;
            this.productLabel1.Text = "Order #";
            // 
            // productLabel2
            // 
            this.productLabel2.AutoSize = true;
            this.productLabel2.Font = new System.Drawing.Font("Roboto", 10F);
            this.productLabel2.ForeColor = System.Drawing.Color.Black;
            this.productLabel2.Location = new System.Drawing.Point(245, 255);
            this.productLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productLabel2.Name = "productLabel2";
            this.productLabel2.Size = new System.Drawing.Size(66, 20);
            this.productLabel2.TabIndex = 48;
            this.productLabel2.Text = "Order #";
            // 
            // productButton9
            // 
            this.productButton9.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton9.Image = ((System.Drawing.Image)(resources.GetObject("productButton9.Image")));
            this.productButton9.Location = new System.Drawing.Point(59, 492);
            this.productButton9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton9.Name = "productButton9";
            this.productButton9.Size = new System.Drawing.Size(165, 116);
            this.productButton9.TabIndex = 46;
            this.productButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton9.UseVisualStyleBackColor = false;
            this.productButton9.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton10
            // 
            this.productButton10.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton10.Image = ((System.Drawing.Image)(resources.GetObject("productButton10.Image")));
            this.productButton10.Location = new System.Drawing.Point(252, 492);
            this.productButton10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton10.Name = "productButton10";
            this.productButton10.Size = new System.Drawing.Size(165, 116);
            this.productButton10.TabIndex = 45;
            this.productButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton10.UseVisualStyleBackColor = false;
            this.productButton10.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton11
            // 
            this.productButton11.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton11.Image = ((System.Drawing.Image)(resources.GetObject("productButton11.Image")));
            this.productButton11.Location = new System.Drawing.Point(444, 492);
            this.productButton11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton11.Name = "productButton11";
            this.productButton11.Size = new System.Drawing.Size(165, 116);
            this.productButton11.TabIndex = 44;
            this.productButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton11.UseVisualStyleBackColor = false;
            this.productButton11.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton12
            // 
            this.productButton12.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton12.Image = ((System.Drawing.Image)(resources.GetObject("productButton12.Image")));
            this.productButton12.Location = new System.Drawing.Point(636, 492);
            this.productButton12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton12.Name = "productButton12";
            this.productButton12.Size = new System.Drawing.Size(165, 116);
            this.productButton12.TabIndex = 43;
            this.productButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton12.UseVisualStyleBackColor = false;
            this.productButton12.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton5
            // 
            this.productButton5.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton5.Image = ((System.Drawing.Image)(resources.GetObject("productButton5.Image")));
            this.productButton5.Location = new System.Drawing.Point(59, 316);
            this.productButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton5.Name = "productButton5";
            this.productButton5.Size = new System.Drawing.Size(165, 116);
            this.productButton5.TabIndex = 42;
            this.productButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton5.UseVisualStyleBackColor = false;
            this.productButton5.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton6
            // 
            this.productButton6.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton6.Image = ((System.Drawing.Image)(resources.GetObject("productButton6.Image")));
            this.productButton6.Location = new System.Drawing.Point(252, 316);
            this.productButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton6.Name = "productButton6";
            this.productButton6.Size = new System.Drawing.Size(165, 116);
            this.productButton6.TabIndex = 41;
            this.productButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton6.UseVisualStyleBackColor = false;
            this.productButton6.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton7
            // 
            this.productButton7.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton7.Image = ((System.Drawing.Image)(resources.GetObject("productButton7.Image")));
            this.productButton7.Location = new System.Drawing.Point(443, 316);
            this.productButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton7.Name = "productButton7";
            this.productButton7.Size = new System.Drawing.Size(165, 116);
            this.productButton7.TabIndex = 40;
            this.productButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton7.UseVisualStyleBackColor = false;
            this.productButton7.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton8
            // 
            this.productButton8.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton8.Image = ((System.Drawing.Image)(resources.GetObject("productButton8.Image")));
            this.productButton8.Location = new System.Drawing.Point(636, 316);
            this.productButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton8.Name = "productButton8";
            this.productButton8.Size = new System.Drawing.Size(165, 116);
            this.productButton8.TabIndex = 39;
            this.productButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productButton8.UseVisualStyleBackColor = false;
            this.productButton8.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton4
            // 
            this.productButton4.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton4.Image = ((System.Drawing.Image)(resources.GetObject("productButton4.Image")));
            this.productButton4.Location = new System.Drawing.Point(636, 137);
            this.productButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton4.Name = "productButton4";
            this.productButton4.Size = new System.Drawing.Size(165, 116);
            this.productButton4.TabIndex = 38;
            this.productButton4.UseVisualStyleBackColor = false;
            this.productButton4.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton3
            // 
            this.productButton3.BackColor = System.Drawing.Color.Silver;
            this.productButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton3.Image = ((System.Drawing.Image)(resources.GetObject("productButton3.Image")));
            this.productButton3.Location = new System.Drawing.Point(444, 137);
            this.productButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton3.Name = "productButton3";
            this.productButton3.Size = new System.Drawing.Size(165, 116);
            this.productButton3.TabIndex = 37;
            this.productButton3.UseVisualStyleBackColor = false;
            this.productButton3.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton2
            // 
            this.productButton2.BackColor = System.Drawing.Color.LightSalmon;
            this.productButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton2.Image = ((System.Drawing.Image)(resources.GetObject("productButton2.Image")));
            this.productButton2.Location = new System.Drawing.Point(251, 137);
            this.productButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton2.Name = "productButton2";
            this.productButton2.Size = new System.Drawing.Size(165, 116);
            this.productButton2.TabIndex = 36;
            this.productButton2.UseVisualStyleBackColor = false;
            this.productButton2.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // productButton1
            // 
            this.productButton1.BackColor = System.Drawing.Color.PaleGreen;
            this.productButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productButton1.Image = ((System.Drawing.Image)(resources.GetObject("productButton1.Image")));
            this.productButton1.Location = new System.Drawing.Point(57, 137);
            this.productButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productButton1.Name = "productButton1";
            this.productButton1.Size = new System.Drawing.Size(165, 116);
            this.productButton1.TabIndex = 35;
            this.productButton1.UseVisualStyleBackColor = false;
            this.productButton1.Click += new System.EventHandler(this.productButton1_Click);
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.labelOrderInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrderInfo.Location = new System.Drawing.Point(821, 577);
            this.labelOrderInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(79, 29);
            this.labelOrderInfo.TabIndex = 28;
            this.labelOrderInfo.Text = "Total:";
            // 
            // itemLbx
            // 
            this.itemLbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.ItemHeight = 20;
            this.itemLbx.Location = new System.Drawing.Point(827, 137);
            this.itemLbx.Margin = new System.Windows.Forms.Padding(4);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(332, 344);
            this.itemLbx.TabIndex = 26;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Roboto Black", 19F);
            this.labelOrder.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrder.Location = new System.Drawing.Point(52, 62);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(120, 38);
            this.labelOrder.TabIndex = 25;
            this.labelOrder.Text = "ORDER";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.personNameRbtn);
            this.startPanel.Controls.Add(this.itemNrRbtn);
            this.startPanel.Controls.Add(this.itemNameRbtn);
            this.startPanel.Controls.Add(this.viewStockBtn);
            this.startPanel.Controls.Add(this.viewHistoryBtn);
            this.startPanel.Controls.Add(this.logsInfoLbx);
            this.startPanel.Controls.Add(this.labelMonitor);
            this.startPanel.Controls.Add(this.searchStockLbl);
            this.startPanel.Controls.Add(this.buttonSearch);
            this.startPanel.Controls.Add(this.textBoxSearch);
            this.startPanel.Controls.Add(this.stockLogsLbl);
            this.startPanel.Location = new System.Drawing.Point(231, 77);
            this.startPanel.Margin = new System.Windows.Forms.Padding(4);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1473, 846);
            this.startPanel.TabIndex = 9;
            this.startPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.startPanel_Paint);
            // 
            // personNameRbtn
            // 
            this.personNameRbtn.AutoSize = true;
            this.personNameRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.personNameRbtn.Location = new System.Drawing.Point(510, 81);
            this.personNameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.personNameRbtn.Name = "personNameRbtn";
            this.personNameRbtn.Size = new System.Drawing.Size(137, 24);
            this.personNameRbtn.TabIndex = 55;
            this.personNameRbtn.TabStop = true;
            this.personNameRbtn.Text = "Person_Name";
            this.personNameRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNrRbtn
            // 
            this.itemNrRbtn.AutoSize = true;
            this.itemNrRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.itemNrRbtn.Location = new System.Drawing.Point(382, 80);
            this.itemNrRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.itemNrRbtn.Name = "itemNrRbtn";
            this.itemNrRbtn.Size = new System.Drawing.Size(97, 24);
            this.itemNrRbtn.TabIndex = 54;
            this.itemNrRbtn.TabStop = true;
            this.itemNrRbtn.Text = "Item\'s Nr";
            this.itemNrRbtn.UseVisualStyleBackColor = true;
            // 
            // itemNameRbtn
            // 
            this.itemNameRbtn.AutoSize = true;
            this.itemNameRbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.itemNameRbtn.Location = new System.Drawing.Point(219, 80);
            this.itemNameRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameRbtn.Name = "itemNameRbtn";
            this.itemNameRbtn.Size = new System.Drawing.Size(124, 24);
            this.itemNameRbtn.TabIndex = 56;
            this.itemNameRbtn.TabStop = true;
            this.itemNameRbtn.Text = "Item\'s Name";
            this.itemNameRbtn.UseVisualStyleBackColor = true;
            // 
            // viewStockBtn
            // 
            this.viewStockBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewStockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewStockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewStockBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.viewStockBtn.ForeColor = System.Drawing.Color.White;
            this.viewStockBtn.Location = new System.Drawing.Point(194, 602);
            this.viewStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewStockBtn.Name = "viewStockBtn";
            this.viewStockBtn.Size = new System.Drawing.Size(285, 38);
            this.viewStockBtn.TabIndex = 43;
            this.viewStockBtn.Text = "View All Items In Stock";
            this.viewStockBtn.UseVisualStyleBackColor = false;
            this.viewStockBtn.Click += new System.EventHandler(this.viewStockBtn_Click);
            // 
            // viewHistoryBtn
            // 
            this.viewHistoryBtn.BackColor = System.Drawing.Color.DimGray;
            this.viewHistoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewHistoryBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.viewHistoryBtn.ForeColor = System.Drawing.Color.White;
            this.viewHistoryBtn.Location = new System.Drawing.Point(567, 602);
            this.viewHistoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewHistoryBtn.Name = "viewHistoryBtn";
            this.viewHistoryBtn.Size = new System.Drawing.Size(285, 38);
            this.viewHistoryBtn.TabIndex = 44;
            this.viewHistoryBtn.Text = "View Purchase History";
            this.viewHistoryBtn.UseVisualStyleBackColor = false;
            this.viewHistoryBtn.Click += new System.EventHandler(this.viewHistoryBtn_Click);
            // 
            // logsInfoLbx
            // 
            this.logsInfoLbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.logsInfoLbx.FormattingEnabled = true;
            this.logsInfoLbx.ItemHeight = 20;
            this.logsInfoLbx.Location = new System.Drawing.Point(70, 158);
            this.logsInfoLbx.Margin = new System.Windows.Forms.Padding(4);
            this.logsInfoLbx.Name = "logsInfoLbx";
            this.logsInfoLbx.Size = new System.Drawing.Size(914, 424);
            this.logsInfoLbx.TabIndex = 40;
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Bold);
            this.labelMonitor.ForeColor = System.Drawing.Color.DimGray;
            this.labelMonitor.Location = new System.Drawing.Point(69, 95);
            this.labelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(0, 27);
            this.labelMonitor.TabIndex = 37;
            // 
            // searchStockLbl
            // 
            this.searchStockLbl.AutoSize = true;
            this.searchStockLbl.Font = new System.Drawing.Font("Roboto", 12F);
            this.searchStockLbl.ForeColor = System.Drawing.Color.DimGray;
            this.searchStockLbl.Location = new System.Drawing.Point(67, 81);
            this.searchStockLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchStockLbl.Name = "searchStockLbl";
            this.searchStockLbl.Size = new System.Drawing.Size(123, 24);
            this.searchStockLbl.TabIndex = 36;
            this.searchStockLbl.Text = "Search Item:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(678, 109);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 31);
            this.buttonSearch.TabIndex = 35;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Roboto", 10F);
            this.textBoxSearch.Location = new System.Drawing.Point(229, 109);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(428, 28);
            this.textBoxSearch.TabIndex = 34;
            // 
            // stockLogsLbl
            // 
            this.stockLogsLbl.AutoSize = true;
            this.stockLogsLbl.Font = new System.Drawing.Font("Roboto Black", 19F);
            this.stockLogsLbl.ForeColor = System.Drawing.Color.DimGray;
            this.stockLogsLbl.Location = new System.Drawing.Point(63, 29);
            this.stockLogsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockLogsLbl.Name = "stockLogsLbl";
            this.stockLogsLbl.Size = new System.Drawing.Size(178, 38);
            this.stockLogsLbl.TabIndex = 33;
            this.stockLogsLbl.Text = "Stock Logs";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(284, 27);
            this.labelShopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(254, 46);
            this.labelShopName.TabIndex = 32;
            this.labelShopName.Text = "SHOP NAME";
            // 
            // timerScanCard
            // 
            this.timerScanCard.Interval = 10000;
            this.timerScanCard.Tick += new System.EventHandler(this.timerScanCard_Tick);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button viewStockBtn;
        private System.Windows.Forms.Button viewHistoryBtn;
        private System.Windows.Forms.ListBox logsInfoLbx;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Label searchStockLbl;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label stockLogsLbl;
        private System.Windows.Forms.Button productButton9;
        private System.Windows.Forms.Button productButton10;
        private System.Windows.Forms.Button productButton11;
        private System.Windows.Forms.Button productButton12;
        private System.Windows.Forms.Button productButton5;
        private System.Windows.Forms.Button productButton6;
        private System.Windows.Forms.Button productButton7;
        private System.Windows.Forms.Button productButton8;
        private System.Windows.Forms.Button productButton4;
        private System.Windows.Forms.Button productButton3;
        private System.Windows.Forms.Button productButton2;
        private System.Windows.Forms.Button productButton1;
        private System.Windows.Forms.Label productLabel9;
        private System.Windows.Forms.Label productLabel10;
        private System.Windows.Forms.Label productLabel11;
        private System.Windows.Forms.Label productLabel12;
        private System.Windows.Forms.Label productLabel5;
        private System.Windows.Forms.Label productLabel6;
        private System.Windows.Forms.Label productLabel8;
        private System.Windows.Forms.Label productLabel7;
        private System.Windows.Forms.Label productLabel4;
        private System.Windows.Forms.Label productLabel3;
        private System.Windows.Forms.Label productLabel1;
        private System.Windows.Forms.Label productLabel2;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonDecrease;
        private System.Windows.Forms.Button buttonIncrease;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Timer timerScanCard;
        private System.Windows.Forms.RadioButton personNameRbtn;
        private System.Windows.Forms.RadioButton itemNrRbtn;
        private System.Windows.Forms.RadioButton itemNameRbtn;
    }
}

