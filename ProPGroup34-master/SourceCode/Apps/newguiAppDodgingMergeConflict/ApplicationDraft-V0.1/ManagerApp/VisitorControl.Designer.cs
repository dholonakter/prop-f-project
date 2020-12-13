namespace ManagerApp
{
    partial class VisitorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorControl));
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalSpent = new System.Windows.Forms.Label();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.dataGridViewVisitor = new System.Windows.Forms.DataGridView();
            this.labelTotalPresent = new System.Windows.Forms.Label();
            this.labelTotalVisitors = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 28);
            this.button1.TabIndex = 55;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelTotalSpent
            // 
            this.labelTotalSpent.AutoSize = true;
            this.labelTotalSpent.ForeColor = System.Drawing.Color.Black;
            this.labelTotalSpent.Location = new System.Drawing.Point(287, 154);
            this.labelTotalSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalSpent.Name = "labelTotalSpent";
            this.labelTotalSpent.Size = new System.Drawing.Size(63, 13);
            this.labelTotalSpent.TabIndex = 54;
            this.labelTotalSpent.Text = "Total spent:";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.ForeColor = System.Drawing.Color.Black;
            this.labelTotalBalance.Location = new System.Drawing.Point(287, 135);
            this.labelTotalBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(75, 13);
            this.labelTotalBalance.TabIndex = 53;
            this.labelTotalBalance.Text = "Total balance:";
            // 
            // dataGridViewVisitor
            // 
            this.dataGridViewVisitor.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewVisitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisitor.Location = new System.Drawing.Point(72, 173);
            this.dataGridViewVisitor.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVisitor.Name = "dataGridViewVisitor";
            this.dataGridViewVisitor.RowTemplate.Height = 24;
            this.dataGridViewVisitor.Size = new System.Drawing.Size(890, 317);
            this.dataGridViewVisitor.TabIndex = 52;
            // 
            // labelTotalPresent
            // 
            this.labelTotalPresent.AutoSize = true;
            this.labelTotalPresent.ForeColor = System.Drawing.Color.Black;
            this.labelTotalPresent.Location = new System.Drawing.Point(70, 154);
            this.labelTotalPresent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPresent.Name = "labelTotalPresent";
            this.labelTotalPresent.Size = new System.Drawing.Size(107, 13);
            this.labelTotalPresent.TabIndex = 51;
            this.labelTotalPresent.Text = "Total visitors present:";
            // 
            // labelTotalVisitors
            // 
            this.labelTotalVisitors.AutoSize = true;
            this.labelTotalVisitors.ForeColor = System.Drawing.Color.Black;
            this.labelTotalVisitors.Location = new System.Drawing.Point(70, 135);
            this.labelTotalVisitors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalVisitors.Name = "labelTotalVisitors";
            this.labelTotalVisitors.Size = new System.Drawing.Size(69, 13);
            this.labelTotalVisitors.TabIndex = 50;
            this.labelTotalVisitors.Text = "Total visitors:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.buttonSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(72, 75);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.buttonSave.Size = new System.Drawing.Size(890, 53);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "    Visitors status";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // VisitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalSpent);
            this.Controls.Add(this.labelTotalBalance);
            this.Controls.Add(this.dataGridViewVisitor);
            this.Controls.Add(this.labelTotalPresent);
            this.Controls.Add(this.labelTotalVisitors);
            this.Controls.Add(this.buttonSave);
            this.Name = "VisitorControl";
            this.Size = new System.Drawing.Size(1033, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotalSpent;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.DataGridView dataGridViewVisitor;
        private System.Windows.Forms.Label labelTotalPresent;
        private System.Windows.Forms.Label labelTotalVisitors;
        private System.Windows.Forms.Button buttonSave;
    }
}
