namespace Practika
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.AbonentDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EventLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ArhivButton = new System.Windows.Forms.Button();
            this.CRMButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AbonentDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbonentDataGridView
            // 
            this.AbonentDataGridView.AllowUserToAddRows = false;
            this.AbonentDataGridView.AllowUserToDeleteRows = false;
            this.AbonentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AbonentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbonentDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.AbonentDataGridView.Location = new System.Drawing.Point(129, 170);
            this.AbonentDataGridView.Name = "AbonentDataGridView";
            this.AbonentDataGridView.ReadOnly = true;
            this.AbonentDataGridView.RowHeadersWidth = 51;
            this.AbonentDataGridView.RowTemplate.Height = 24;
            this.AbonentDataGridView.Size = new System.Drawing.Size(503, 280);
            this.AbonentDataGridView.TabIndex = 8;
            this.AbonentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AbonentDataGridView_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.EventLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(638, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 332);
            this.panel4.TabIndex = 7;
            // 
            // EventLabel
            // 
            this.EventLabel.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventLabel.Location = new System.Drawing.Point(4, 4);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(153, 318);
            this.EventLabel.TabIndex = 0;
            this.EventLabel.Click += new System.EventHandler(this.EventLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ImportButton);
            this.panel3.Controls.Add(this.ExportButton);
            this.panel3.Controls.Add(this.ArhivButton);
            this.panel3.Controls.Add(this.CRMButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 332);
            this.panel3.TabIndex = 6;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExportButton.Location = new System.Drawing.Point(11, 103);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(96, 47);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ArhivButton
            // 
            this.ArhivButton.BackColor = System.Drawing.SystemColors.Control;
            this.ArhivButton.Location = new System.Drawing.Point(11, 54);
            this.ArhivButton.Name = "ArhivButton";
            this.ArhivButton.Size = new System.Drawing.Size(98, 43);
            this.ArhivButton.TabIndex = 1;
            this.ArhivButton.Text = "Архив";
            this.ArhivButton.UseVisualStyleBackColor = false;
            this.ArhivButton.Click += new System.EventHandler(this.ArhivButton_Click);
            // 
            // CRMButton
            // 
            this.CRMButton.BackColor = System.Drawing.SystemColors.Control;
            this.CRMButton.Location = new System.Drawing.Point(11, 5);
            this.CRMButton.Name = "CRMButton";
            this.CRMButton.Size = new System.Drawing.Size(98, 43);
            this.CRMButton.TabIndex = 0;
            this.CRMButton.Text = "CRM";
            this.CRMButton.UseVisualStyleBackColor = false;
            this.CRMButton.Click += new System.EventHandler(this.CRMButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 118);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 109);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(639, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 103);
            this.label2.TabIndex = 2;
            this.label2.Text = "События";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "Администратор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(128, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Абоненты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.SystemColors.Control;
            this.ImportButton.Location = new System.Drawing.Point(11, 156);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(96, 47);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Импорт";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AbonentDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AdministratorForm";
            this.Text = "AdministratotForm";
            this.Load += new System.EventHandler(this.AdministratotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbonentDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AbonentDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CRMButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ArhivButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
    }
}