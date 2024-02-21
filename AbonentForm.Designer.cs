namespace Practika
{
    partial class AbonentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbonentForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CRMButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неРаботаетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.станцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.BillingButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(640, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 327);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BillingButton);
            this.panel3.Controls.Add(this.CRMButton);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 327);
            this.panel3.TabIndex = 6;
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 102);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(121, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.состояниеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.станцииToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(108, 31);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // состояниеToolStripMenuItem
            // 
            this.состояниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаетToolStripMenuItem,
            this.неРаботаетToolStripMenuItem});
            this.состояниеToolStripMenuItem.Name = "состояниеToolStripMenuItem";
            this.состояниеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.состояниеToolStripMenuItem.Text = "Состояние";
            // 
            // работаетToolStripMenuItem
            // 
            this.работаетToolStripMenuItem.Name = "работаетToolStripMenuItem";
            this.работаетToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.работаетToolStripMenuItem.Text = "Работает";
            this.работаетToolStripMenuItem.Click += new System.EventHandler(this.работаетToolStripMenuItem_Click);
            // 
            // неРаботаетToolStripMenuItem
            // 
            this.неРаботаетToolStripMenuItem.Name = "неРаботаетToolStripMenuItem";
            this.неРаботаетToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.неРаботаетToolStripMenuItem.Text = "Не работает";
            this.неРаботаетToolStripMenuItem.Click += new System.EventHandler(this.неРаботаетToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // станцииToolStripMenuItem
            // 
            this.станцииToolStripMenuItem.Name = "станцииToolStripMenuItem";
            this.станцииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.станцииToolStripMenuItem.Text = "Станции";
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
            this.panel2.Size = new System.Drawing.Size(808, 118);
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
            this.label1.Text = "Абонент";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIOLabel
            // 
            this.FIOLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIOLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOLabel.Location = new System.Drawing.Point(130, 124);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(504, 43);
            this.FIOLabel.TabIndex = 8;
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.SystemColors.Control;
            this.BillingButton.Location = new System.Drawing.Point(11, 54);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(98, 45);
            this.BillingButton.TabIndex = 2;
            this.BillingButton.Text = "Биллинг";
            this.BillingButton.UseVisualStyleBackColor = false;
            this.BillingButton.Click += new System.EventHandler(this.BillingButton_Click);
            // 
            // AbonentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 445);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AbonentForm";
            this.Text = "AbonentForm";
            this.Load += new System.EventHandler(this.AbonentForm_Load);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CRMButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem станцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неРаботаетToolStripMenuItem;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Button BillingButton;
    }
}