namespace BMViewer.View
{
    partial class MainForm
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
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadedImage = new System.Windows.Forms.PictureBox();
            this.BrightnesTrackBar = new System.Windows.Forms.TrackBar();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnesTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.FiltersToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(704, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // FiltersToolStripMenuItem
            // 
            this.FiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BrightnessToolStripMenuItem,
            this.BlurToolStripMenuItem,
            this.ContrastToolStripMenuItem});
            this.FiltersToolStripMenuItem.Name = "FiltersToolStripMenuItem";
            this.FiltersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.FiltersToolStripMenuItem.Text = "Фильтры";
            // 
            // BrightnessToolStripMenuItem
            // 
            this.BrightnessToolStripMenuItem.Name = "BrightnessToolStripMenuItem";
            this.BrightnessToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.BrightnessToolStripMenuItem.Text = "Яркость";
            this.BrightnessToolStripMenuItem.Click += new System.EventHandler(this.BrightnessToolStripMenuItem_Click);
            // 
            // BlurToolStripMenuItem
            // 
            this.BlurToolStripMenuItem.Name = "BlurToolStripMenuItem";
            this.BlurToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.BlurToolStripMenuItem.Text = "Размытие";
            this.BlurToolStripMenuItem.Click += new System.EventHandler(this.BlurToolStripMenuItem_Click);
            // 
            // ContrastToolStripMenuItem
            // 
            this.ContrastToolStripMenuItem.Name = "ContrastToolStripMenuItem";
            this.ContrastToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ContrastToolStripMenuItem.Text = "Контраст";
            this.ContrastToolStripMenuItem.Click += new System.EventHandler(this.ContrastToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // LoadedImage
            // 
            this.LoadedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadedImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadedImage.Location = new System.Drawing.Point(12, 34);
            this.LoadedImage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LoadedImage.Name = "LoadedImage";
            this.LoadedImage.Size = new System.Drawing.Size(376, 335);
            this.LoadedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadedImage.TabIndex = 1;
            this.LoadedImage.TabStop = false;
            // 
            // BrightnesTrackBar
            // 
            this.BrightnesTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnesTrackBar.Enabled = false;
            this.BrightnesTrackBar.Location = new System.Drawing.Point(487, 34);
            this.BrightnesTrackBar.Minimum = -10;
            this.BrightnesTrackBar.Name = "BrightnesTrackBar";
            this.BrightnesTrackBar.Size = new System.Drawing.Size(205, 45);
            this.BrightnesTrackBar.TabIndex = 2;
            this.BrightnesTrackBar.Scroll += new System.EventHandler(this.BrightnesTrackBar_Scroll);
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastTrackBar.Enabled = false;
            this.ContrastTrackBar.Location = new System.Drawing.Point(487, 112);
            this.ContrastTrackBar.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ContrastTrackBar.Minimum = -10;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(205, 45);
            this.ContrastTrackBar.TabIndex = 3;
            this.ContrastTrackBar.Tag = "";
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(410, 34);
            this.BrightnessLabel.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(50, 13);
            this.BrightnessLabel.TabIndex = 5;
            this.BrightnessLabel.Text = "Яркость";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(410, 112);
            this.ContrastLabel.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(54, 13);
            this.ContrastLabel.TabIndex = 6;
            this.ContrastLabel.Text = "Контраст";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.BrightnesTrackBar);
            this.Controls.Add(this.LoadedImage);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.Name = "MainForm";
            this.Text = "BMViewer";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnesTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContrastToolStripMenuItem;
        private System.Windows.Forms.PictureBox LoadedImage;
        private System.Windows.Forms.TrackBar BrightnesTrackBar;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
    }
}

