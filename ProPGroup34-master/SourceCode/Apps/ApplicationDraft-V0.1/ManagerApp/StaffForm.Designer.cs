namespace ManagerApp
{
    partial class StaffForm
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
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(52, 104);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(870, 418);
            this.dataGridViewStaff.TabIndex = 0;
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelJobTitle.Location = new System.Drawing.Point(48, 37);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(130, 20);
            this.labelJobTitle.TabIndex = 1;
            this.labelJobTitle.Text = "Choose job title:";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(195, 33);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(275, 28);
            this.comboBoxTitle.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(797, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(507, 33);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(120, 30);
            this.buttonDisplay.TabIndex = 4;
            this.buttonDisplay.Text = "Display";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(650, 32);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(120, 30);
            this.buttonShowAll.TabIndex = 5;
            this.buttonShowAll.Text = "Show all";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCount.Location = new System.Drawing.Point(48, 69);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(144, 20);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "You have x people";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSum.Location = new System.Drawing.Point(503, 69);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(272, 20);
            this.labelSum.TabIndex = 7;
            this.labelSum.Text = "The sum of their monthly salary is: ";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 557);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.dataGridViewStaff);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelSum;
    }
}