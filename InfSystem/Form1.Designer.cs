namespace InfSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.мужскаяОбувьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.женскаяОбувьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.корзинаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кошелекToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мужскаяОбувьToolStripMenuItem1,
            this.женскаяОбувьToolStripMenuItem1,
            this.корзинаToolStripMenuItem1,
            this.кошелекToolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(211, 824);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // мужскаяОбувьToolStripMenuItem1
            // 
            this.мужскаяОбувьToolStripMenuItem1.Name = "мужскаяОбувьToolStripMenuItem1";
            this.мужскаяОбувьToolStripMenuItem1.Size = new System.Drawing.Size(205, 36);
            this.мужскаяОбувьToolStripMenuItem1.Text = "Мужская обувь";
            // 
            // женскаяОбувьToolStripMenuItem1
            // 
            this.женскаяОбувьToolStripMenuItem1.Name = "женскаяОбувьToolStripMenuItem1";
            this.женскаяОбувьToolStripMenuItem1.Size = new System.Drawing.Size(201, 36);
            this.женскаяОбувьToolStripMenuItem1.Text = "Женская обувь";
            // 
            // корзинаToolStripMenuItem1
            // 
            this.корзинаToolStripMenuItem1.Name = "корзинаToolStripMenuItem1";
            this.корзинаToolStripMenuItem1.Size = new System.Drawing.Size(127, 36);
            this.корзинаToolStripMenuItem1.Text = "Корзина";
            // 
            // кошелекToolStripMenuItem1
            // 
            this.кошелекToolStripMenuItem1.Name = "кошелекToolStripMenuItem1";
            this.кошелекToolStripMenuItem1.Size = new System.Drawing.Size(132, 36);
            this.кошелекToolStripMenuItem1.Text = "Кошелек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 824);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ShoesZone";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem мужскаяОбувьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem женскаяОбувьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кошелекToolStripMenuItem1;
    }
}

