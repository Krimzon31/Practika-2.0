namespace Practika
{
    partial class OperatorBillingForm
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
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ChecksDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(24, 41);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(103, 43);
            this.ReplaceButton.TabIndex = 9;
            this.ReplaceButton.Text = "Обновить";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(428, 51);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(194, 22);
            this.SearchTextBox.TabIndex = 8;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(293, 41);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(129, 43);
            this.SearchLabel.TabIndex = 7;
            this.SearchLabel.Text = "Поиск по долгу";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChecksDataGridView
            // 
            this.ChecksDataGridView.AllowUserToDeleteRows = false;
            this.ChecksDataGridView.AllowUserToOrderColumns = true;
            this.ChecksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChecksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChecksDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChecksDataGridView.Location = new System.Drawing.Point(0, 128);
            this.ChecksDataGridView.Name = "ChecksDataGridView";
            this.ChecksDataGridView.RowHeadersWidth = 51;
            this.ChecksDataGridView.RowTemplate.Height = 24;
            this.ChecksDataGridView.Size = new System.Drawing.Size(800, 322);
            this.ChecksDataGridView.TabIndex = 10;
            this.ChecksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChecksDataGridView_CellClick);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(147, 41);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(103, 43);
            this.InsertButton.TabIndex = 11;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // OperatorBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.ChecksDataGridView);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Name = "OperatorBillingForm";
            this.Text = "OperatorBillingForm";
            this.Load += new System.EventHandler(this.OperatorBillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChecksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView ChecksDataGridView;
        private System.Windows.Forms.Button InsertButton;
    }
}