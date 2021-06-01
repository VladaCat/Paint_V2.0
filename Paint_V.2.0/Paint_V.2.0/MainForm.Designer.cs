namespace Paint_V._2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.DotToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CurveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RedoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.ThicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.MinimumSizeOfThickness = new System.Windows.Forms.Label();
            this.MaxsimumSizeOfThickness = new System.Windows.Forms.Label();
            this.AverageSizeOfThickness = new System.Windows.Forms.Label();
            this.ChangeColorDialog = new System.Windows.Forms.ColorDialog();
            this.ChangeColorPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentColorPictureBox = new System.Windows.Forms.PictureBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ChangeColorLabel = new System.Windows.Forms.Label();
            this.RectangleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SelectToolStripMenuItem,
            this.MoveToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.SelectToolStripMenuItem.Text = "Select";
            this.SelectToolStripMenuItem.Click += new System.EventHandler(this.SelectToolStripMenuItem_Click);
            // 
            // MoveToolStripMenuItem
            // 
            this.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem";
            this.MoveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.MoveToolStripMenuItem.Text = "Move";
            this.MoveToolStripMenuItem.Click += new System.EventHandler(this.MoveToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.AutoSize = false;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DotToolStripButton,
            this.EllipseToolStripButton,
            this.CurveToolStripButton,
            this.RectangleToolStripButton,
            this.UndoToolStripButton,
            this.RedoToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(984, 63);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // DotToolStripButton
            // 
            this.DotToolStripButton.AutoSize = false;
            this.DotToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DotToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DotToolStripButton.Image")));
            this.DotToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DotToolStripButton.Name = "DotToolStripButton";
            this.DotToolStripButton.Size = new System.Drawing.Size(50, 50);
            this.DotToolStripButton.Text = "DotToolStripButton";
            this.DotToolStripButton.Click += new System.EventHandler(this.DotToolStripButton_Click);
            // 
            // EllipseToolStripButton
            // 
            this.EllipseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EllipseToolStripButton.Image")));
            this.EllipseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseToolStripButton.Name = "EllipseToolStripButton";
            this.EllipseToolStripButton.Size = new System.Drawing.Size(54, 60);
            this.EllipseToolStripButton.Text = "EllipseToolStripButton";
            this.EllipseToolStripButton.Click += new System.EventHandler(this.EllipseToolStripButton_Click);
            // 
            // CurveToolStripButton
            // 
            this.CurveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CurveToolStripButton.Image")));
            this.CurveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurveToolStripButton.Name = "CurveToolStripButton";
            this.CurveToolStripButton.Size = new System.Drawing.Size(54, 60);
            this.CurveToolStripButton.Text = "CurveToolStripButton";
            this.CurveToolStripButton.Click += new System.EventHandler(this.CurveToolStripButton_Click);
            // 
            // UndoToolStripButton
            // 
            this.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoToolStripButton.Image")));
            this.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoToolStripButton.Name = "UndoToolStripButton";
            this.UndoToolStripButton.Size = new System.Drawing.Size(54, 60);
            this.UndoToolStripButton.Text = "UndoToolStripButton";
            this.UndoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // RedoToolStripButton
            // 
            this.RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoToolStripButton.Image")));
            this.RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoToolStripButton.Name = "RedoToolStripButton";
            this.RedoToolStripButton.Size = new System.Drawing.Size(54, 60);
            this.RedoToolStripButton.Text = "RedoToolStripButton";
            this.RedoToolStripButton.Click += new System.EventHandler(this.RedoToolStripButton_Click);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 87);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(984, 374);
            this.MainPictureBox.TabIndex = 2;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.MainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // ThicknessTrackBar
            // 
            this.ThicknessTrackBar.Location = new System.Drawing.Point(841, 24);
            this.ThicknessTrackBar.Maximum = 20;
            this.ThicknessTrackBar.Minimum = 1;
            this.ThicknessTrackBar.Name = "ThicknessTrackBar";
            this.ThicknessTrackBar.Size = new System.Drawing.Size(131, 45);
            this.ThicknessTrackBar.TabIndex = 4;
            this.ThicknessTrackBar.Value = 1;
            this.ThicknessTrackBar.Scroll += new System.EventHandler(this.ThicknessTrackBar_Scroll);
            // 
            // MinimumSizeOfThickness
            // 
            this.MinimumSizeOfThickness.AutoSize = true;
            this.MinimumSizeOfThickness.Location = new System.Drawing.Point(848, 56);
            this.MinimumSizeOfThickness.Name = "MinimumSizeOfThickness";
            this.MinimumSizeOfThickness.Size = new System.Drawing.Size(13, 13);
            this.MinimumSizeOfThickness.TabIndex = 5;
            this.MinimumSizeOfThickness.Text = "1";
            // 
            // MaxsimumSizeOfThickness
            // 
            this.MaxsimumSizeOfThickness.AutoSize = true;
            this.MaxsimumSizeOfThickness.Location = new System.Drawing.Point(953, 56);
            this.MaxsimumSizeOfThickness.Name = "MaxsimumSizeOfThickness";
            this.MaxsimumSizeOfThickness.Size = new System.Drawing.Size(19, 13);
            this.MaxsimumSizeOfThickness.TabIndex = 6;
            this.MaxsimumSizeOfThickness.Text = "20";
            // 
            // AverageSizeOfThickness
            // 
            this.AverageSizeOfThickness.AutoSize = true;
            this.AverageSizeOfThickness.Location = new System.Drawing.Point(901, 56);
            this.AverageSizeOfThickness.Name = "AverageSizeOfThickness";
            this.AverageSizeOfThickness.Size = new System.Drawing.Size(19, 13);
            this.AverageSizeOfThickness.TabIndex = 7;
            this.AverageSizeOfThickness.Text = "10";
            // 
            // ChangeColorPictureBox
            // 
            this.ChangeColorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ChangeColorPictureBox.Image = global::Paint_V._2._0.Properties.Resources._2;
            this.ChangeColorPictureBox.InitialImage = null;
            this.ChangeColorPictureBox.Location = new System.Drawing.Point(796, 27);
            this.ChangeColorPictureBox.Name = "ChangeColorPictureBox";
            this.ChangeColorPictureBox.Size = new System.Drawing.Size(39, 36);
            this.ChangeColorPictureBox.TabIndex = 8;
            this.ChangeColorPictureBox.TabStop = false;
            this.ChangeColorPictureBox.Click += new System.EventHandler(this.ChangeColorPictureBox_Click);
            // 
            // CurrentColorPictureBox
            // 
            this.CurrentColorPictureBox.BackColor = System.Drawing.Color.Black;
            this.CurrentColorPictureBox.Location = new System.Drawing.Point(741, 27);
            this.CurrentColorPictureBox.Name = "CurrentColorPictureBox";
            this.CurrentColorPictureBox.Size = new System.Drawing.Size(39, 36);
            this.CurrentColorPictureBox.TabIndex = 9;
            this.CurrentColorPictureBox.TabStop = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorLabel.Location = new System.Drawing.Point(745, 66);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 10;
            this.ColorLabel.Text = "Color";
            // 
            // ChangeColorLabel
            // 
            this.ChangeColorLabel.AutoSize = true;
            this.ChangeColorLabel.Location = new System.Drawing.Point(793, 66);
            this.ChangeColorLabel.Name = "ChangeColorLabel";
            this.ChangeColorLabel.Size = new System.Drawing.Size(44, 26);
            this.ChangeColorLabel.TabIndex = 11;
            this.ChangeColorLabel.Text = "Change\r\nColor";
            this.ChangeColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RectangleToolStripButton
            // 
            this.RectangleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleToolStripButton.Image")));
            this.RectangleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleToolStripButton.Name = "RectangleToolStripButton";
            this.RectangleToolStripButton.Size = new System.Drawing.Size(54, 60);
            this.RectangleToolStripButton.Text = "RectangleToolStripButton";
            this.RectangleToolStripButton.Click += new System.EventHandler(this.RectangleToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ChangeColorLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.CurrentColorPictureBox);
            this.Controls.Add(this.ChangeColorPictureBox);
            this.Controls.Add(this.AverageSizeOfThickness);
            this.Controls.Add(this.MaxsimumSizeOfThickness);
            this.Controls.Add(this.MinimumSizeOfThickness);
            this.Controls.Add(this.ThicknessTrackBar);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton DotToolStripButton;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.TrackBar ThicknessTrackBar;
        private System.Windows.Forms.Label MinimumSizeOfThickness;
        private System.Windows.Forms.Label MaxsimumSizeOfThickness;
        private System.Windows.Forms.Label AverageSizeOfThickness;
        private System.Windows.Forms.ColorDialog ChangeColorDialog;
        private System.Windows.Forms.PictureBox ChangeColorPictureBox;
        private System.Windows.Forms.PictureBox CurrentColorPictureBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label ChangeColorLabel;
        private System.Windows.Forms.ToolStripButton EllipseToolStripButton;
        private System.Windows.Forms.ToolStripButton CurveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton UndoToolStripButton;
        private System.Windows.Forms.ToolStripButton RedoToolStripButton;
        private System.Windows.Forms.ToolStripButton RectangleToolStripButton;
    }
}

