namespace Practika
{
    partial class ZaavkaForm
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
            this.Personal_AccountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServicesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIOIngenerTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Personal_AccountTextBox
            // 
            this.Personal_AccountTextBox.Location = new System.Drawing.Point(44, 48);
            this.Personal_AccountTextBox.Name = "Personal_AccountTextBox";
            this.Personal_AccountTextBox.ReadOnly = true;
            this.Personal_AccountTextBox.Size = new System.Drawing.Size(233, 22);
            this.Personal_AccountTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ Лицевого Счёта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Услуга";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesTextBox
            // 
            this.ServicesTextBox.Location = new System.Drawing.Point(44, 99);
            this.ServicesTextBox.Name = "ServicesTextBox";
            this.ServicesTextBox.ReadOnly = true;
            this.ServicesTextBox.Size = new System.Drawing.Size(233, 22);
            this.ServicesTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "ФИО Инженера";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIOIngenerTextBox
            // 
            this.FIOIngenerTextBox.Location = new System.Drawing.Point(44, 203);
            this.FIOIngenerTextBox.Name = "FIOIngenerTextBox";
            this.FIOIngenerTextBox.Size = new System.Drawing.Size(233, 22);
            this.FIOIngenerTextBox.TabIndex = 6;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(102, 231);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(111, 44);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Новый",
            "Закрытый"});
            this.comboBox1.Location = new System.Drawing.Point(47, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // ZaavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 299);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FIOIngenerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServicesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Personal_AccountTextBox);
            this.Name = "ZaavkaForm";
            this.Text = "ZaavkaForm";
            this.Load += new System.EventHandler(this.ZaavkaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Personal_AccountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServicesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIOIngenerTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}