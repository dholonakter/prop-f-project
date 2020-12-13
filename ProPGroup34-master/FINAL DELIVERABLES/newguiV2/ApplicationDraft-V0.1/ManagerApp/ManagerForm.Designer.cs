namespace ManagerApp
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.analyticBtn = new System.Windows.Forms.Button();
            this.eventBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.transBtn = new System.Windows.Forms.Button();
            this.campBtn = new System.Windows.Forms.Button();
            this.shopBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.analyticBtn);
            this.panel1.Controls.Add(this.eventBtn);
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Controls.Add(this.transBtn);
            this.panel1.Controls.Add(this.campBtn);
            this.panel1.Controls.Add(this.shopBtn);
            this.panel1.Controls.Add(this.inventoryBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 768);
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
            // analyticBtn
            // 
            this.analyticBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.analyticBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.analyticBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.analyticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyticBtn.ForeColor = System.Drawing.Color.White;
            this.analyticBtn.Image = ((System.Drawing.Image)(resources.GetObject("analyticBtn.Image")));
            this.analyticBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyticBtn.Location = new System.Drawing.Point(11, 329);
            this.analyticBtn.Name = "analyticBtn";
            this.analyticBtn.Size = new System.Drawing.Size(155, 54);
            this.analyticBtn.TabIndex = 18;
            this.analyticBtn.Text = "Analytics";
            this.analyticBtn.UseVisualStyleBackColor = true;
            this.analyticBtn.Click += new System.EventHandler(this.analyticBtn_Click);
            // 
            // eventBtn
            // 
            this.eventBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.eventBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.eventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBtn.ForeColor = System.Drawing.Color.White;
            this.eventBtn.Image = ((System.Drawing.Image)(resources.GetObject("eventBtn.Image")));
            this.eventBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventBtn.Location = new System.Drawing.Point(11, 89);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(155, 54);
            this.eventBtn.TabIndex = 18;
            this.eventBtn.Text = "Visitors";
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.Click += new System.EventHandler(this.eventBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.staffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffBtn.Image")));
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(11, 449);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(155, 54);
            this.staffBtn.TabIndex = 17;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // transBtn
            // 
            this.transBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.transBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.transBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transBtn.ForeColor = System.Drawing.Color.White;
            this.transBtn.Image = ((System.Drawing.Image)(resources.GetObject("transBtn.Image")));
            this.transBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transBtn.Location = new System.Drawing.Point(11, 389);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(155, 54);
            this.transBtn.TabIndex = 15;
            this.transBtn.Text = "   Transactions";
            this.transBtn.UseVisualStyleBackColor = true;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // campBtn
            // 
            this.campBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.campBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.campBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.campBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campBtn.ForeColor = System.Drawing.Color.White;
            this.campBtn.Image = ((System.Drawing.Image)(resources.GetObject("campBtn.Image")));
            this.campBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campBtn.Location = new System.Drawing.Point(11, 209);
            this.campBtn.Name = "campBtn";
            this.campBtn.Size = new System.Drawing.Size(155, 54);
            this.campBtn.TabIndex = 17;
            this.campBtn.Text = "Camping";
            this.campBtn.UseVisualStyleBackColor = true;
            this.campBtn.Click += new System.EventHandler(this.campBtn_Click);
            // 
            // shopBtn
            // 
            this.shopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.shopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.shopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBtn.ForeColor = System.Drawing.Color.White;
            this.shopBtn.Image = ((System.Drawing.Image)(resources.GetObject("shopBtn.Image")));
            this.shopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopBtn.Location = new System.Drawing.Point(11, 149);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(155, 54);
            this.shopBtn.TabIndex = 15;
            this.shopBtn.Text = "Shops";
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inventoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.White;
            this.inventoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBtn.Image")));
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.Location = new System.Drawing.Point(11, 269);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(155, 54);
            this.inventoryBtn.TabIndex = 16;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 10);
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
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button eventBtn;
        private System.Windows.Forms.Button campBtn;
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button analyticBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button transBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}

