namespace FoodApp
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
            this.sideHighlight = new System.Windows.Forms.Panel();
            this.snackBtn = new System.Windows.Forms.Button();
            this.drinkBtn = new System.Windows.Forms.Button();
            this.foodBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.foodCustomControl1 = new FoodApp.FoodCustomControl();
            this.snacksCustomControl1 = new FoodApp.SnacksCustomControl();
            this.drinksCustomControl1 = new FoodApp.DrinksCustomControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.sideHighlight);
            this.panel1.Controls.Add(this.snackBtn);
            this.panel1.Controls.Add(this.drinkBtn);
            this.panel1.Controls.Add(this.foodBtn);
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
            this.sideHighlight.TabIndex = 2;
            // 
            // snackBtn
            // 
            this.snackBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.snackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.snackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.snackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snackBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snackBtn.ForeColor = System.Drawing.Color.White;
            this.snackBtn.Image = ((System.Drawing.Image)(resources.GetObject("snackBtn.Image")));
            this.snackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.snackBtn.Location = new System.Drawing.Point(11, 181);
            this.snackBtn.Name = "snackBtn";
            this.snackBtn.Size = new System.Drawing.Size(155, 54);
            this.snackBtn.TabIndex = 2;
            this.snackBtn.Text = "Snacks";
            this.snackBtn.UseVisualStyleBackColor = true;
            this.snackBtn.Click += new System.EventHandler(this.snackBtn_Click);
            // 
            // drinkBtn
            // 
            this.drinkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drinkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.drinkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.drinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drinkBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkBtn.ForeColor = System.Drawing.Color.White;
            this.drinkBtn.Image = ((System.Drawing.Image)(resources.GetObject("drinkBtn.Image")));
            this.drinkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drinkBtn.Location = new System.Drawing.Point(11, 273);
            this.drinkBtn.Name = "drinkBtn";
            this.drinkBtn.Size = new System.Drawing.Size(155, 54);
            this.drinkBtn.TabIndex = 2;
            this.drinkBtn.Text = "Drinks";
            this.drinkBtn.UseVisualStyleBackColor = true;
            this.drinkBtn.Click += new System.EventHandler(this.drinkBtn_Click);
            // 
            // foodBtn
            // 
            this.foodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.foodBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.foodBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.foodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodBtn.ForeColor = System.Drawing.Color.White;
            this.foodBtn.Image = ((System.Drawing.Image)(resources.GetObject("foodBtn.Image")));
            this.foodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodBtn.Location = new System.Drawing.Point(11, 89);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(155, 54);
            this.foodBtn.TabIndex = 2;
            this.foodBtn.Text = "Food";
            this.foodBtn.UseVisualStyleBackColor = true;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
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
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(951, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 42);
            this.button4.TabIndex = 2;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(901, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 42);
            this.button5.TabIndex = 2;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // foodCustomControl1
            // 
            this.foodCustomControl1.BackColor = System.Drawing.Color.White;
            this.foodCustomControl1.Location = new System.Drawing.Point(166, 53);
            this.foodCustomControl1.Name = "foodCustomControl1";
            this.foodCustomControl1.Size = new System.Drawing.Size(832, 494);
            this.foodCustomControl1.TabIndex = 3;
            // 
            // snacksCustomControl1
            // 
            this.snacksCustomControl1.BackColor = System.Drawing.Color.White;
            this.snacksCustomControl1.Location = new System.Drawing.Point(166, 53);
            this.snacksCustomControl1.Name = "snacksCustomControl1";
            this.snacksCustomControl1.Size = new System.Drawing.Size(832, 494);
            this.snacksCustomControl1.TabIndex = 4;
            // 
            // drinksCustomControl1
            // 
            this.drinksCustomControl1.BackColor = System.Drawing.Color.White;
            this.drinksCustomControl1.Location = new System.Drawing.Point(166, 53);
            this.drinksCustomControl1.Name = "drinksCustomControl1";
            this.drinksCustomControl1.Size = new System.Drawing.Size(832, 494);
            this.drinksCustomControl1.TabIndex = 5;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 571);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.snacksCustomControl1);
            this.Controls.Add(this.foodCustomControl1);
            this.Controls.Add(this.drinksCustomControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button snackBtn;
        private System.Windows.Forms.Button drinkBtn;
        private System.Windows.Forms.Panel sideHighlight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private FoodCustomControl foodCustomControl1;
        private SnacksCustomControl snacksCustomControl1;
        private DrinksCustomControl drinksCustomControl1;
    }
}

