namespace ManagerApp
{
    partial class StockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(480, 416);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(77, 24);
            this.buttonShowAll.TabIndex = 48;
            this.buttonShowAll.Text = "Show all";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Show articles with quantity lower than:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(613, 421);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(77, 24);
            this.buttonSave.TabIndex = 46;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 421);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 45;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(387, 418);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(77, 24);
            this.buttonShow.TabIndex = 44;
            this.buttonShow.Text = "Display";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(140)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(140)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(206)))), ((int)(((byte)(140)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(122)))), ((int)(((byte)(17)))));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(59, 40);
            this.button13.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(745, 53);
            this.button13.TabIndex = 43;
            this.button13.Text = "    Inventory status";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(59, 113);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(745, 293);
            this.dataGridViewInventory.TabIndex = 42;
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dataGridViewInventory);
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(860, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
    }
}
