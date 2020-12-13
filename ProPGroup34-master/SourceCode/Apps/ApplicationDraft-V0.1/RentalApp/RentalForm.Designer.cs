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
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startPanel = new System.Windows.Forms.Panel();
            this.borrowPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStopBorrow = new System.Windows.Forms.Button();
            this.labelBorrowInfo = new System.Windows.Forms.Label();
            this.labelVisitorB = new System.Windows.Forms.Label();
            this.returnPanel = new System.Windows.Forms.Panel();
            this.buttonStopReturn = new System.Windows.Forms.Button();
            this.labelVisitorR = new System.Windows.Forms.Label();
            this.labelReturnInfo = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.LogMeesage = new System.Windows.Forms.GroupBox();
            this.lbxReturnmMessage = new System.Windows.Forms.ListBox();
            this.lbxBorrowMessage = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrowClear = new System.Windows.Forms.Button();
            this.btnClearOfReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.borrowPanel.SuspendLayout();
            this.returnPanel.SuspendLayout();
            this.LogMeesage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.borrowBtn);
            this.panel1.Controls.Add(this.returnBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 640);
            this.panel1.TabIndex = 0;
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 14;
            // 
            // borrowBtn
            // 
            this.borrowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.borrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.borrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.ForeColor = System.Drawing.Color.White;
            this.borrowBtn.Image = ((System.Drawing.Image)(resources.GetObject("borrowBtn.Image")));
            this.borrowBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowBtn.Location = new System.Drawing.Point(11, 89);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(155, 54);
            this.borrowBtn.TabIndex = 20;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.returnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.Location = new System.Drawing.Point(11, 157);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(155, 54);
            this.returnBtn.TabIndex = 21;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
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
            // startPanel
            // 
            this.startPanel.Location = new System.Drawing.Point(220, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1105, 687);
            this.startPanel.TabIndex = 10;
            // 
            // borrowPanel
            // 
            this.borrowPanel.Controls.Add(this.btnBorrowClear);
            this.borrowPanel.Controls.Add(this.groupBox1);
            this.borrowPanel.Controls.Add(this.button1);
            this.borrowPanel.Controls.Add(this.label3);
            this.borrowPanel.Controls.Add(this.buttonStopBorrow);
            this.borrowPanel.Controls.Add(this.labelBorrowInfo);
            this.borrowPanel.Controls.Add(this.labelVisitorB);
            this.borrowPanel.Location = new System.Drawing.Point(223, 73);
            this.borrowPanel.Name = "borrowPanel";
            this.borrowPanel.Size = new System.Drawing.Size(997, 634);
            this.borrowPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(54, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Borrowing items";
            // 
            // buttonStopBorrow
            // 
            this.buttonStopBorrow.Location = new System.Drawing.Point(63, 381);
            this.buttonStopBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopBorrow.Name = "buttonStopBorrow";
            this.buttonStopBorrow.Size = new System.Drawing.Size(124, 45);
            this.buttonStopBorrow.TabIndex = 29;
            this.buttonStopBorrow.Text = "stop scanning items";
            this.buttonStopBorrow.UseVisualStyleBackColor = true;
            this.buttonStopBorrow.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelBorrowInfo
            // 
            this.labelBorrowInfo.AutoSize = true;
            this.labelBorrowInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrowInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelBorrowInfo.Location = new System.Drawing.Point(462, 75);
            this.labelBorrowInfo.Name = "labelBorrowInfo";
            this.labelBorrowInfo.Size = new System.Drawing.Size(67, 23);
            this.labelBorrowInfo.TabIndex = 27;
            this.labelBorrowInfo.Text = "Order";
            // 
            // labelVisitorB
            // 
            this.labelVisitorB.AutoSize = true;
            this.labelVisitorB.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorB.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorB.Location = new System.Drawing.Point(54, 75);
            this.labelVisitorB.Name = "labelVisitorB";
            this.labelVisitorB.Size = new System.Drawing.Size(77, 23);
            this.labelVisitorB.TabIndex = 26;
            this.labelVisitorB.Text = "Visitor";
            // 
            // returnPanel
            // 
            this.returnPanel.Controls.Add(this.btnClearOfReturn);
            this.returnPanel.Controls.Add(this.LogMeesage);
            this.returnPanel.Controls.Add(this.buttonStopReturn);
            this.returnPanel.Controls.Add(this.labelVisitorR);
            this.returnPanel.Controls.Add(this.labelReturnInfo);
            this.returnPanel.Location = new System.Drawing.Point(223, 70);
            this.returnPanel.Name = "returnPanel";
            this.returnPanel.Size = new System.Drawing.Size(997, 634);
            this.returnPanel.TabIndex = 30;
            this.returnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.returnPanel_Paint);
            // 
            // buttonStopReturn
            // 
            this.buttonStopReturn.Location = new System.Drawing.Point(457, 384);
            this.buttonStopReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopReturn.Name = "buttonStopReturn";
            this.buttonStopReturn.Size = new System.Drawing.Size(124, 45);
            this.buttonStopReturn.TabIndex = 29;
            this.buttonStopReturn.Text = "stop scanning items";
            this.buttonStopReturn.UseVisualStyleBackColor = true;
            this.buttonStopReturn.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelVisitorR
            // 
            this.labelVisitorR.AutoSize = true;
            this.labelVisitorR.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitorR.ForeColor = System.Drawing.Color.DimGray;
            this.labelVisitorR.Location = new System.Drawing.Point(54, 87);
            this.labelVisitorR.Name = "labelVisitorR";
            this.labelVisitorR.Size = new System.Drawing.Size(77, 23);
            this.labelVisitorR.TabIndex = 27;
            this.labelVisitorR.Text = "Visitor";
            // 
            // labelReturnInfo
            // 
            this.labelReturnInfo.AutoSize = true;
            this.labelReturnInfo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnInfo.ForeColor = System.Drawing.Color.DimGray;
            this.labelReturnInfo.Location = new System.Drawing.Point(470, 87);
            this.labelReturnInfo.Name = "labelReturnInfo";
            this.labelReturnInfo.Size = new System.Drawing.Size(67, 23);
            this.labelReturnInfo.TabIndex = 26;
            this.labelReturnInfo.Text = "Order";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold);
            this.labelShopName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelShopName.Location = new System.Drawing.Point(248, 31);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(162, 27);
            this.labelShopName.TabIndex = 31;
            this.labelShopName.Text = "SHOP NAME";
            // 
            // LogMeesage
            // 
            this.LogMeesage.Controls.Add(this.lbxReturnmMessage);
            this.LogMeesage.Location = new System.Drawing.Point(30, 446);
            this.LogMeesage.Name = "LogMeesage";
            this.LogMeesage.Size = new System.Drawing.Size(507, 100);
            this.LogMeesage.TabIndex = 30;
            this.LogMeesage.TabStop = false;
            this.LogMeesage.Text = "LogMessage";
            // 
            // lbxReturnmMessage
            // 
            this.lbxReturnmMessage.FormattingEnabled = true;
            this.lbxReturnmMessage.Location = new System.Drawing.Point(17, 19);
            this.lbxReturnmMessage.Name = "lbxReturnmMessage";
            this.lbxReturnmMessage.Size = new System.Drawing.Size(468, 69);
            this.lbxReturnmMessage.TabIndex = 0;
            // 
            // lbxBorrowMessage
            // 
            this.lbxBorrowMessage.FormattingEnabled = true;
            this.lbxBorrowMessage.Location = new System.Drawing.Point(6, 19);
            this.lbxBorrowMessage.Name = "lbxBorrowMessage";
            this.lbxBorrowMessage.Size = new System.Drawing.Size(545, 69);
            this.lbxBorrowMessage.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxBorrowMessage);
            this.groupBox1.Location = new System.Drawing.Point(58, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogMessage";
            // 
            // btnBorrowClear
            // 
            this.btnBorrowClear.Location = new System.Drawing.Point(254, 549);
            this.btnBorrowClear.Name = "btnBorrowClear";
            this.btnBorrowClear.Size = new System.Drawing.Size(110, 23);
            this.btnBorrowClear.TabIndex = 34;
            this.btnBorrowClear.Text = "Clear All\r\n";
            this.btnBorrowClear.UseVisualStyleBackColor = true;
            this.btnBorrowClear.Click += new System.EventHandler(this.btnBorrowClear_Click);
            // 
            // btnClearOfReturn
            // 
            this.btnClearOfReturn.Location = new System.Drawing.Point(189, 558);
            this.btnClearOfReturn.Name = "btnClearOfReturn";
            this.btnClearOfReturn.Size = new System.Drawing.Size(75, 23);
            this.btnClearOfReturn.TabIndex = 31;
            this.btnClearOfReturn.Text = "ClearAll\r\n";
            this.btnClearOfReturn.UseVisualStyleBackColor = true;
            this.btnClearOfReturn.Click += new System.EventHandler(this.btnClearOfReturn_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.borrowPanel);
            this.Controls.Add(this.returnPanel);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalForm_FormClosed);
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.panel1.ResumeLayout(false);
            this.borrowPanel.ResumeLayout(false);
            this.borrowPanel.PerformLayout();
            this.returnPanel.ResumeLayout(false);
            this.returnPanel.PerformLayout();
            this.LogMeesage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelVisitorB;
        private System.Windows.Forms.Label labelBorrowInfo;
        private System.Windows.Forms.Button buttonStopBorrow;
        private System.Windows.Forms.Panel returnPanel;
        private System.Windows.Forms.Button buttonStopReturn;
        private System.Windows.Forms.Label labelVisitorR;
        private System.Windows.Forms.Label labelReturnInfo;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox LogMeesage;
        private System.Windows.Forms.ListBox lbxReturnmMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxBorrowMessage;
        private System.Windows.Forms.Button btnBorrowClear;
        private System.Windows.Forms.Button btnClearOfReturn;
    }
}

