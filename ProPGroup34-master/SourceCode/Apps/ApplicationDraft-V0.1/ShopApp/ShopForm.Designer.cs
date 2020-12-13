namespace ShopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.overviewBtn = new System.Windows.Forms.Button();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbProductMessage = new System.Windows.Forms.ListBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelAdminShop = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.lblCardLinkedStatus = new System.Windows.Forms.Label();
            this.labelOrderInfo = new System.Windows.Forms.Label();
            this.itemLbx = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkRbtn = new System.Windows.Forms.RadioButton();
            this.foodRbtn = new System.Windows.Forms.RadioButton();
            this.quantitySelec = new System.Windows.Forms.NumericUpDown();
            this.startPanel = new System.Windows.Forms.Panel();
            this.labelShopName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxOverviewMessage = new System.Windows.Forms.ListBox();
            this.btnOverviewClear = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.productPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).BeginInit();
            this.startPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.overviewBtn);
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.productBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 640);
            this.panel1.TabIndex = 0;
            // 
            // overviewBtn
            // 
            this.overviewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.overviewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.overviewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.overviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overviewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overviewBtn.ForeColor = System.Drawing.Color.White;
            this.overviewBtn.Image = ((System.Drawing.Image)(resources.GetObject("overviewBtn.Image")));
            this.overviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.overviewBtn.Location = new System.Drawing.Point(11, 89);
            this.overviewBtn.Name = "overviewBtn";
            this.overviewBtn.Size = new System.Drawing.Size(155, 54);
            this.overviewBtn.TabIndex = 15;
            this.overviewBtn.Text = "Overview";
            this.overviewBtn.UseVisualStyleBackColor = true;
            this.overviewBtn.Click += new System.EventHandler(this.overviewBtn_Click);
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
            // 
            // productBtn
            // 
            this.productBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.productBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.White;
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(11, 181);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(155, 54);
            this.productBtn.TabIndex = 17;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            // productPanel
            // 
            this.productPanel.Controls.Add(this.btnProductClear);
            this.productPanel.Controls.Add(this.progressBar1);
            this.productPanel.Controls.Add(this.groupBox1);
            this.productPanel.Controls.Add(this.buttonRestart);
            this.productPanel.Controls.Add(this.labelAdminShop);
            this.productPanel.Controls.Add(this.comboBoxShop);
            this.productPanel.Controls.Add(this.lblCardLinkedStatus);
            this.productPanel.Controls.Add(this.labelOrderInfo);
            this.productPanel.Controls.Add(this.itemLbx);
            this.productPanel.Controls.Add(this.label3);
            this.productPanel.Controls.Add(this.label1);
            this.productPanel.Controls.Add(this.drinkRbtn);
            this.productPanel.Controls.Add(this.foodRbtn);
            this.productPanel.Controls.Add(this.quantitySelec);
            this.productPanel.Location = new System.Drawing.Point(233, 70);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(994, 634);
            this.productPanel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(107, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 9);
            this.progressBar1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbProductMessage);
            this.groupBox1.Location = new System.Drawing.Point(24, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 96);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogMessage";
            // 
            // lbProductMessage
            // 
            this.lbProductMessage.FormattingEnabled = true;
            this.lbProductMessage.Location = new System.Drawing.Point(13, 19);
            this.lbProductMessage.Name = "lbProductMessage";
            this.lbProductMessage.Size = new System.Drawing.Size(514, 69);
            this.lbProductMessage.TabIndex = 0;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(44, 398);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(124, 45);
            this.buttonRestart.TabIndex = 34;
            this.buttonRestart.Text = "restart order";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelAdminShop
            // 
            this.labelAdminShop.AutoSize = true;
            this.labelAdminShop.Location = new System.Drawing.Point(62, 59);
            this.labelAdminShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdminShop.Name = "labelAdminShop";
            this.labelAdminShop.Size = new System.Drawing.Size(69, 13);
            this.labelAdminShop.TabIndex = 33;
            this.labelAdminShop.Text = "Choose shop";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(242, 54);
            this.comboBoxShop.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(147, 21);
            this.comboBoxShop.TabIndex = 32;
            this.comboBoxShop.SelectedIndexChanged += new System.EventHandler(this.comboBoxShop_SelectedIndexChanged);
            // 
            // lblCardLinkedStatus
            // 
            this.lblCardLinkedStatus.AutoSize = true;
            this.lblCardLinkedStatus.Location = new System.Drawing.Point(56, 370);
            this.lblCardLinkedStatus.Name = "lblCardLinkedStatus";
            this.lblCardLinkedStatus.Size = new System.Drawing.Size(88, 13);
            this.lblCardLinkedStatus.TabIndex = 31;
            this.lblCardLinkedStatus.Text = "...........................";
            // 
            // labelOrderInfo
            // 
            this.labelOrderInfo.AutoSize = true;
            this.labelOrderInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelOrderInfo.Location = new System.Drawing.Point(508, 97);
            this.labelOrderInfo.Name = "labelOrderInfo";
            this.labelOrderInfo.Size = new System.Drawing.Size(17, 23);
            this.labelOrderInfo.TabIndex = 28;
            this.labelOrderInfo.Text = "-";
            // 
            // itemLbx
            // 
            this.itemLbx.FormattingEnabled = true;
            this.itemLbx.Location = new System.Drawing.Point(59, 136);
            this.itemLbx.Name = "itemLbx";
            this.itemLbx.Size = new System.Drawing.Size(330, 160);
            this.itemLbx.TabIndex = 26;
            this.itemLbx.SelectedIndexChanged += new System.EventHandler(this.itemLbx_SelectedIndexChanged);
            this.itemLbx.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemLbx_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose Type :";
            // 
            // drinkRbtn
            // 
            this.drinkRbtn.AutoSize = true;
            this.drinkRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkRbtn.Location = new System.Drawing.Point(336, 97);
            this.drinkRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.drinkRbtn.Name = "drinkRbtn";
            this.drinkRbtn.Size = new System.Drawing.Size(57, 20);
            this.drinkRbtn.TabIndex = 24;
            this.drinkRbtn.Text = "Drink";
            this.drinkRbtn.UseVisualStyleBackColor = true;
            // 
            // foodRbtn
            // 
            this.foodRbtn.AutoSize = true;
            this.foodRbtn.Checked = true;
            this.foodRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodRbtn.Location = new System.Drawing.Point(242, 96);
            this.foodRbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foodRbtn.Name = "foodRbtn";
            this.foodRbtn.Size = new System.Drawing.Size(58, 20);
            this.foodRbtn.TabIndex = 23;
            this.foodRbtn.TabStop = true;
            this.foodRbtn.Text = "Food";
            this.foodRbtn.UseVisualStyleBackColor = true;
            this.foodRbtn.CheckedChanged += new System.EventHandler(this.foodRbtn_CheckedChanged);
            // 
            // quantitySelec
            // 
            this.quantitySelec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantitySelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelec.Location = new System.Drawing.Point(172, 314);
            this.quantitySelec.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySelec.Name = "quantitySelec";
            this.quantitySelec.Size = new System.Drawing.Size(92, 22);
            this.quantitySelec.TabIndex = 19;
            this.quantitySelec.ValueChanged += new System.EventHandler(this.quantitySelec_ValueChanged);
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.btnOverviewClear);
            this.startPanel.Controls.Add(this.groupBox2);
            this.startPanel.Location = new System.Drawing.Point(233, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1091, 687);
            this.startPanel.TabIndex = 9;
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(236, 32);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(162, 27);
            this.labelShopName.TabIndex = 32;
            this.labelShopName.Text = "SHOP NAME";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxOverviewMessage);
            this.groupBox2.Location = new System.Drawing.Point(18, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LogMessage";
            // 
            // lbxOverviewMessage
            // 
            this.lbxOverviewMessage.FormattingEnabled = true;
            this.lbxOverviewMessage.Location = new System.Drawing.Point(6, 17);
            this.lbxOverviewMessage.Name = "lbxOverviewMessage";
            this.lbxOverviewMessage.Size = new System.Drawing.Size(581, 95);
            this.lbxOverviewMessage.TabIndex = 0;
            // 
            // btnOverviewClear
            // 
            this.btnOverviewClear.Location = new System.Drawing.Point(225, 544);
            this.btnOverviewClear.Name = "btnOverviewClear";
            this.btnOverviewClear.Size = new System.Drawing.Size(75, 23);
            this.btnOverviewClear.TabIndex = 1;
            this.btnOverviewClear.Text = "ClearAll";
            this.btnOverviewClear.UseVisualStyleBackColor = true;
            this.btnOverviewClear.Click += new System.EventHandler(this.btnOverviewClear_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.Location = new System.Drawing.Point(225, 550);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(75, 23);
            this.btnProductClear.TabIndex = 37;
            this.btnProductClear.Text = "ClearAll";
            this.btnProductClear.UseVisualStyleBackColor = true;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.panel1.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelec)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button overviewBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.RadioButton drinkRbtn;
        private System.Windows.Forms.RadioButton foodRbtn;
        private System.Windows.Forms.NumericUpDown quantitySelec;
        private System.Windows.Forms.ListBox itemLbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Label labelOrderInfo;
        private System.Windows.Forms.Label lblCardLinkedStatus;
        private System.Windows.Forms.Label labelAdminShop;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProductMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxOverviewMessage;
        private System.Windows.Forms.Button btnOverviewClear;
        private System.Windows.Forms.Button btnProductClear;
    }
}

