namespace Practika
{
    partial class ArhivForm
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
            this.ArhivDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Personal_accountLabel = new System.Windows.Forms.Label();
            this.ServicesLabel = new System.Windows.Forms.Label();
            this.FIOlabel = new System.Windows.Forms.Label();
            this.Personal_AccountTextBox = new System.Windows.Forms.TextBox();
            this.Abonent_NumberTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArhivDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArhivDataGridView
            // 
            this.ArhivDataGridView.AllowUserToAddRows = false;
            this.ArhivDataGridView.AllowUserToDeleteRows = false;
            this.ArhivDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArhivDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArhivDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArhivDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ArhivDataGridView.Name = "ArhivDataGridView";
            this.ArhivDataGridView.ReadOnly = true;
            this.ArhivDataGridView.RowHeadersWidth = 51;
            this.ArhivDataGridView.RowTemplate.Height = 24;
            this.ArhivDataGridView.Size = new System.Drawing.Size(1045, 387);
            this.ArhivDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Personal_accountLabel);
            this.panel1.Controls.Add(this.ServicesLabel);
            this.panel1.Controls.Add(this.FIOlabel);
            this.panel1.Controls.Add(this.Personal_AccountTextBox);
            this.panel1.Controls.Add(this.Abonent_NumberTextBox);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 133);
            this.panel1.TabIndex = 1;
            // 
            // Personal_accountLabel
            // 
            this.Personal_accountLabel.Location = new System.Drawing.Point(621, 42);
            this.Personal_accountLabel.Name = "Personal_accountLabel";
            this.Personal_accountLabel.Size = new System.Drawing.Size(103, 23);
            this.Personal_accountLabel.TabIndex = 5;
            this.Personal_accountLabel.Text = "Лицевой счёт";
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.Location = new System.Drawing.Point(384, 43);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(79, 23);
            this.ServicesLabel.TabIndex = 4;
            this.ServicesLabel.Text = "Услуга";
            // 
            // FIOlabel
            // 
            this.FIOlabel.Location = new System.Drawing.Point(158, 42);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(52, 23);
            this.FIOlabel.TabIndex = 3;
            this.FIOlabel.Text = "Логин";
            // 
            // Personal_AccountTextBox
            // 
            this.Personal_AccountTextBox.Location = new System.Drawing.Point(730, 43);
            this.Personal_AccountTextBox.Name = "Personal_AccountTextBox";
            this.Personal_AccountTextBox.Size = new System.Drawing.Size(146, 22);
            this.Personal_AccountTextBox.TabIndex = 2;
            this.Personal_AccountTextBox.TextChanged += new System.EventHandler(this.Personal_AccountTextBox_TextChanged);
            // 
            // Abonent_NumberTextBox
            // 
            this.Abonent_NumberTextBox.Location = new System.Drawing.Point(469, 43);
            this.Abonent_NumberTextBox.Name = "Abonent_NumberTextBox";
            this.Abonent_NumberTextBox.Size = new System.Drawing.Size(146, 22);
            this.Abonent_NumberTextBox.TabIndex = 1;
            this.Abonent_NumberTextBox.TextChanged += new System.EventHandler(this.Abonent_NumberTextBox_TextChanged);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(216, 40);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(146, 22);
            this.LoginTextBox.TabIndex = 0;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.FIOTextBox_TextChanged);
            // 
            // ArhivForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArhivDataGridView);
            this.Name = "ArhivForm";
            this.Text = "ArhivForm";
            this.Load += new System.EventHandler(this.ArhivForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArhivDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ArhivDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Personal_accountLabel;
        private System.Windows.Forms.Label ServicesLabel;
        private System.Windows.Forms.Label FIOlabel;
        private System.Windows.Forms.TextBox Personal_AccountTextBox;
        private System.Windows.Forms.TextBox Abonent_NumberTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}