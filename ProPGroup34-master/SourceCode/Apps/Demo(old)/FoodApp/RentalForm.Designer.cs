namespace FoodApp
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
            this.costumeBtn = new System.Windows.Forms.Button();
            this.chargeBtn = new System.Windows.Forms.Button();
            this.otherBtn = new System.Windows.Forms.Button();
            this.cameraBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.costumesControl1 = new FoodApp.CostumesControl();
            this.cameraControl1 = new FoodApp.CameraControl();
            this.chargersControl1 = new FoodApp.ChargersControl();
            this.otherControl1 = new FoodApp.OtherControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.costumeBtn);
            this.panel1.Controls.Add(this.chargeBtn);
            this.panel1.Controls.Add(this.otherBtn);
            this.panel1.Controls.Add(this.cameraBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 571);
            this.panel1.TabIndex = 0;
            // 
            // sideHighlight
            // 
            this.sideHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sideHighlight.Location = new System.Drawing.Point(0, 89);
            this.sideHighlight.Name = "sideHighlight";
            this.sideHighlight.Size = new System.Drawing.Size(11, 54);
            this.sideHighlight.TabIndex = 9;
            // 
            // costumeBtn
            // 
            this.costumeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.costumeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.costumeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.costumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costumeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumeBtn.ForeColor = System.Drawing.Color.White;
            this.costumeBtn.Image = ((System.Drawing.Image)(resources.GetObject("costumeBtn.Image")));
            this.costumeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.costumeBtn.Location = new System.Drawing.Point(11, 89);
            this.costumeBtn.Name = "costumeBtn";
            this.costumeBtn.Size = new System.Drawing.Size(155, 54);
            this.costumeBtn.TabIndex = 13;
            this.costumeBtn.Text = "Costumes";
            this.costumeBtn.UseVisualStyleBackColor = true;
            this.costumeBtn.Click += new System.EventHandler(this.costumeBtn_Click);
            // 
            // chargeBtn
            // 
            this.chargeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chargeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.chargeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.chargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chargeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargeBtn.ForeColor = System.Drawing.Color.White;
            this.chargeBtn.Image = ((System.Drawing.Image)(resources.GetObject("chargeBtn.Image")));
            this.chargeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chargeBtn.Location = new System.Drawing.Point(11, 181);
            this.chargeBtn.Name = "chargeBtn";
            this.chargeBtn.Size = new System.Drawing.Size(155, 54);
            this.chargeBtn.TabIndex = 10;
            this.chargeBtn.Text = "Chargers";
            this.chargeBtn.UseVisualStyleBackColor = true;
            this.chargeBtn.Click += new System.EventHandler(this.chargeBtn_Click);
            // 
            // otherBtn
            // 
            this.otherBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.otherBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.otherBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.otherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBtn.ForeColor = System.Drawing.Color.White;
            this.otherBtn.Image = ((System.Drawing.Image)(resources.GetObject("otherBtn.Image")));
            this.otherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.otherBtn.Location = new System.Drawing.Point(11, 358);
            this.otherBtn.Name = "otherBtn";
            this.otherBtn.Size = new System.Drawing.Size(155, 54);
            this.otherBtn.TabIndex = 11;
            this.otherBtn.Text = "Other";
            this.otherBtn.UseVisualStyleBackColor = true;
            this.otherBtn.Click += new System.EventHandler(this.otherBtn_Click);
            // 
            // cameraBtn
            // 
            this.cameraBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cameraBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.cameraBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.cameraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraBtn.ForeColor = System.Drawing.Color.White;
            this.cameraBtn.Image = ((System.Drawing.Image)(resources.GetObject("cameraBtn.Image")));
            this.cameraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cameraBtn.Location = new System.Drawing.Point(11, 273);
            this.cameraBtn.Name = "cameraBtn";
            this.cameraBtn.Size = new System.Drawing.Size(155, 54);
            this.cameraBtn.TabIndex = 12;
            this.cameraBtn.Text = "Cameras";
            this.cameraBtn.UseVisualStyleBackColor = true;
            this.cameraBtn.Click += new System.EventHandler(this.cameraBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 10);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(901, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 42);
            this.button7.TabIndex = 3;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.DimGray;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(951, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 4;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // costumesControl1
            // 
            this.costumesControl1.BackColor = System.Drawing.Color.White;
            this.costumesControl1.Location = new System.Drawing.Point(166, 56);
            this.costumesControl1.Name = "costumesControl1";
            this.costumesControl1.Size = new System.Drawing.Size(832, 494);
            this.costumesControl1.TabIndex = 5;
            // 
            // cameraControl1
            // 
            this.cameraControl1.BackColor = System.Drawing.Color.White;
            this.cameraControl1.Location = new System.Drawing.Point(166, 56);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(832, 494);
            this.cameraControl1.TabIndex = 6;
            // 
            // chargersControl1
            // 
            this.chargersControl1.BackColor = System.Drawing.Color.White;
            this.chargersControl1.Location = new System.Drawing.Point(166, 56);
            this.chargersControl1.Name = "chargersControl1";
            this.chargersControl1.Size = new System.Drawing.Size(832, 494);
            this.chargersControl1.TabIndex = 7;
            // 
            // otherControl1
            // 
            this.otherControl1.BackColor = System.Drawing.Color.White;
            this.otherControl1.Location = new System.Drawing.Point(166, 56);
            this.otherControl1.Name = "otherControl1";
            this.otherControl1.Size = new System.Drawing.Size(832, 494);
            this.otherControl1.TabIndex = 8;
            this.otherControl1.Load += new System.EventHandler(this.otherControl1_Load);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.otherControl1);
            this.Controls.Add(this.chargersControl1);
            this.Controls.Add(this.cameraControl1);
            this.Controls.Add(this.costumesControl1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button costumeBtn;
        private System.Windows.Forms.Button chargeBtn;
        private System.Windows.Forms.Button otherBtn;
        private System.Windows.Forms.Button cameraBtn;
        private CostumesControl costumesControl1;
        private CameraControl cameraControl1;
        private ChargersControl chargersControl1;
        private OtherControl otherControl1;
    }
}

