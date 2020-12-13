using System;

namespace ManagerApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffBtn = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.visitorBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.campBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Controls.Add(this.buttonTransactions);
            this.panel1.Controls.Add(this.visitorBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.campBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 571);
            this.panel1.TabIndex = 0;
            // 
            // staffBtn
            // 
            this.staffBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.staffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.staffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.ForeColor = System.Drawing.Color.White;
            this.staffBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffBtn.Image")));
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffBtn.Location = new System.Drawing.Point(420, 225);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(177, 54);
            this.staffBtn.TabIndex = 21;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactions.ForeColor = System.Drawing.Color.White;
            this.buttonTransactions.Image = ((System.Drawing.Image)(resources.GetObject("buttonTransactions.Image")));
            this.buttonTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactions.Location = new System.Drawing.Point(201, 325);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(177, 54);
            this.buttonTransactions.TabIndex = 19;
            this.buttonTransactions.Text = "   Transactions";
            this.buttonTransactions.UseVisualStyleBackColor = true;
            this.buttonTransactions.Click += new System.EventHandler(this.buttonTransactions_Click);
            // 
            // visitorBtn
            // 
            this.visitorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visitorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.visitorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.visitorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitorBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorBtn.ForeColor = System.Drawing.Color.White;
            this.visitorBtn.Image = ((System.Drawing.Image)(resources.GetObject("visitorBtn.Image")));
            this.visitorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visitorBtn.Location = new System.Drawing.Point(201, 225);
            this.visitorBtn.Name = "visitorBtn";
            this.visitorBtn.Size = new System.Drawing.Size(177, 54);
            this.visitorBtn.TabIndex = 19;
            this.visitorBtn.Text = "Visitors";
            this.visitorBtn.UseVisualStyleBackColor = true;
            this.visitorBtn.Click += new System.EventHandler(this.visitorBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(420, 325);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(177, 54);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Logout";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // campBtn
            // 
            this.campBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.campBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.campBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.campBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campBtn.ForeColor = System.Drawing.Color.White;
            this.campBtn.Image = ((System.Drawing.Image)(resources.GetObject("campBtn.Image")));
            this.campBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campBtn.Location = new System.Drawing.Point(637, 225);
            this.campBtn.Name = "campBtn";
            this.campBtn.Size = new System.Drawing.Size(177, 54);
            this.campBtn.TabIndex = 2;
            this.campBtn.Text = "Camping";
            this.campBtn.UseVisualStyleBackColor = true;
            this.campBtn.Click += new System.EventHandler(this.campBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 56);
            this.panel2.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";

            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button campBtn;
        private System.Windows.Forms.Button visitorBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button buttonTransactions;
    }
}

