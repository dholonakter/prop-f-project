namespace ManagerApp
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
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.button12 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonTop5 = new System.Windows.Forms.Button();
            this.buttonAllStands = new System.Windows.Forms.Button();
            this.buttonAllStores = new System.Windows.Forms.Button();
            this.buttonAllShops = new System.Windows.Forms.Button();
            this.buttonMostPurchased = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(187, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "Total money earned:";
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShop.Location = new System.Drawing.Point(189, 233);
            this.dataGridViewShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.RowTemplate.Height = 24;
            this.dataGridViewShop.Size = new System.Drawing.Size(673, 357);
            this.dataGridViewShop.TabIndex = 37;
            this.dataGridViewShop.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewShop_CellBeginEdit);
            this.dataGridViewShop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShop_CellEndEdit);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(200)))), ((int)(((byte)(131)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.button12.ForeColor = System.Drawing.Color.DarkGreen;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(185, 123);
            this.button12.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(977, 65);
            this.button12.TabIndex = 34;
            this.button12.Text = "    Shops status";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(245, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 34);
            this.label18.TabIndex = 40;
            this.label18.Text = "Section to import data\r\n\r\n";
            // 
            // buttonTop5
            // 
            this.buttonTop5.Location = new System.Drawing.Point(907, 231);
            this.buttonTop5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTop5.Name = "buttonTop5";
            this.buttonTop5.Size = new System.Drawing.Size(157, 43);
            this.buttonTop5.TabIndex = 51;
            this.buttonTop5.Text = "Show top 5 shops";
            this.buttonTop5.UseVisualStyleBackColor = true;
            this.buttonTop5.Click += new System.EventHandler(this.buttonTop5_Click);
            // 
            // buttonAllStands
            // 
            this.buttonAllStands.Location = new System.Drawing.Point(907, 283);
            this.buttonAllStands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAllStands.Name = "buttonAllStands";
            this.buttonAllStands.Size = new System.Drawing.Size(157, 43);
            this.buttonAllStands.TabIndex = 52;
            this.buttonAllStands.Text = "Show all loan stands";
            this.buttonAllStands.UseVisualStyleBackColor = true;
            this.buttonAllStands.Click += new System.EventHandler(this.buttonAllStands_Click);
            // 
            // buttonAllStores
            // 
            this.buttonAllStores.Location = new System.Drawing.Point(907, 332);
            this.buttonAllStores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAllStores.Name = "buttonAllStores";
            this.buttonAllStores.Size = new System.Drawing.Size(157, 43);
            this.buttonAllStores.TabIndex = 53;
            this.buttonAllStores.Text = "Show all stores";
            this.buttonAllStores.UseVisualStyleBackColor = true;
            this.buttonAllStores.Click += new System.EventHandler(this.buttonAllStores_Click);
            // 
            // buttonAllShops
            // 
            this.buttonAllShops.Location = new System.Drawing.Point(907, 382);
            this.buttonAllShops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAllShops.Name = "buttonAllShops";
            this.buttonAllShops.Size = new System.Drawing.Size(157, 43);
            this.buttonAllShops.TabIndex = 54;
            this.buttonAllShops.Text = "Show all shops";
            this.buttonAllShops.UseVisualStyleBackColor = true;
            this.buttonAllShops.Click += new System.EventHandler(this.buttonAllShops_Click);
            // 
            // buttonMostPurchased
            // 
            this.buttonMostPurchased.Location = new System.Drawing.Point(907, 431);
            this.buttonMostPurchased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMostPurchased.Name = "buttonMostPurchased";
            this.buttonMostPurchased.Size = new System.Drawing.Size(157, 43);
            this.buttonMostPurchased.TabIndex = 55;
            this.buttonMostPurchased.Text = "Most purchased items";
            this.buttonMostPurchased.UseVisualStyleBackColor = true;
            this.buttonMostPurchased.Click += new System.EventHandler(this.buttonMostPurchased_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(907, 480);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 43);
            this.buttonSave.TabIndex = 56;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 3000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1197, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 52);
            this.button7.TabIndex = 57;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
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
            this.homeBtn.Location = new System.Drawing.Point(1264, 15);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(59, 52);
            this.homeBtn.TabIndex = 58;
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 703);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAllShops);
            this.Controls.Add(this.buttonMostPurchased);
            this.Controls.Add(this.buttonAllStores);
            this.Controls.Add(this.buttonAllStands);
            this.Controls.Add(this.buttonTop5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridViewShop);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonTop5;
        private System.Windows.Forms.Button buttonAllStands;
        private System.Windows.Forms.Button buttonAllStores;
        private System.Windows.Forms.Button buttonAllShops;
        private System.Windows.Forms.Button buttonMostPurchased;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button homeBtn;
    }
}