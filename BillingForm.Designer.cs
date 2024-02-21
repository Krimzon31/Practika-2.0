namespace Practika
{
    partial class BillingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.NewCheckButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.ChecksDataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ReplaceButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Controls.Add(this.NewCheckButton);
            this.panel1.Controls.Add(this.CheckButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 127);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(253, 40);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(103, 43);
            this.ReplaceButton.TabIndex = 4;
            this.ReplaceButton.Text = "Обновить";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(540, 50);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(194, 22);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Location = new System.Drawing.Point(430, 40);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(104, 43);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Поиск по тарифу";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCheckButton
            // 
            this.NewCheckButton.Location = new System.Drawing.Point(144, 40);
            this.NewCheckButton.Name = "NewCheckButton";
            this.NewCheckButton.Size = new System.Drawing.Size(103, 43);
            this.NewCheckButton.TabIndex = 1;
            this.NewCheckButton.Text = "Новый";
            this.NewCheckButton.UseVisualStyleBackColor = true;
            this.NewCheckButton.Click += new System.EventHandler(this.NewCheckButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(35, 40);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(103, 43);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Счёт";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // ChecksDataGridView
            // 
            this.ChecksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChecksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChecksDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChecksDataGridView.Location = new System.Drawing.Point(0, 128);
            this.ChecksDataGridView.Name = "ChecksDataGridView";
            this.ChecksDataGridView.RowHeadersWidth = 51;
            this.ChecksDataGridView.RowTemplate.Height = 24;
            this.ChecksDataGridView.Size = new System.Drawing.Size(800, 322);
            this.ChecksDataGridView.TabIndex = 1;
            this.ChecksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChecksDataGridView_CellClick);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChecksDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ChecksDataGridView;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button NewCheckButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}