namespace Practika
{
    partial class CRMForm
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
            this.CRMDataGridView = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CRMDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CRMDataGridView
            // 
            this.CRMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CRMDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.CRMDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CRMDataGridView.Name = "CRMDataGridView";
            this.CRMDataGridView.RowHeadersWidth = 51;
            this.CRMDataGridView.RowTemplate.Height = 24;
            this.CRMDataGridView.Size = new System.Drawing.Size(1152, 330);
            this.CRMDataGridView.TabIndex = 0;
            this.CRMDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CRMDataGridView_CellValidating);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(518, 336);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(116, 44);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CRMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 392);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.CRMDataGridView);
            this.Name = "CRMForm";
            this.Text = "CRMForm";
            this.Load += new System.EventHandler(this.CRMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CRMDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CRMDataGridView;
        private System.Windows.Forms.Button InsertButton;
    }
}