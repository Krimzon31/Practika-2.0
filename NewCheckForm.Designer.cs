namespace Practika
{
    partial class NewCheckForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ServiceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(89, 191);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(108, 43);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.Location = new System.Drawing.Point(119, 48);
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.Size = new System.Drawing.Size(150, 22);
            this.ServiceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Услуга";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тариф";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(119, 89);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(150, 22);
            this.RateTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(119, 133);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(150, 22);
            this.PriceTextBox.TabIndex = 5;
            // 
            // NewCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTextBox);
            this.Controls.Add(this.OKButton);
            this.Name = "NewCheckForm";
            this.Text = "NewCheckForm";
            this.Load += new System.EventHandler(this.NewCheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox ServiceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}