namespace AudioProcess
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDefaultItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sineParamsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sineWavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeAdjustItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.allHarmonicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddHarmonicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tremoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listenToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.processToolStripMenuItem,
            this.renderFormatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openItem,
            this.openDefaultItem,
            this.saveAsItem,
            this.saveItem,
            this.closeItem,
            this.exitItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.newMenu.Size = new System.Drawing.Size(146, 22);
            this.newMenu.Text = "New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openItem.Size = new System.Drawing.Size(146, 22);
            this.openItem.Text = "Open";
            this.openItem.Click += new System.EventHandler(this.openItem_Click);
            // 
            // openDefaultItem
            // 
            this.openDefaultItem.Name = "openDefaultItem";
            this.openDefaultItem.Size = new System.Drawing.Size(146, 22);
            this.openDefaultItem.Text = "Open Default";
            this.openDefaultItem.Click += new System.EventHandler(this.openDefaultItem_Click);
            // 
            // saveAsItem
            // 
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsItem.Text = "Save As...";
            this.saveAsItem.Click += new System.EventHandler(this.saveAsItem_Click);
            // 
            // saveItem
            // 
            this.saveItem.Name = "saveItem";
            this.saveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveItem.Size = new System.Drawing.Size(146, 22);
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // closeItem
            // 
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(146, 22);
            this.closeItem.Text = "Close";
            this.closeItem.Click += new System.EventHandler(this.closeItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(146, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // listenToolStripMenuItem
            // 
            this.listenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playItem,
            this.stopItem,
            this.pauseItem});
            this.listenToolStripMenuItem.Name = "listenToolStripMenuItem";
            this.listenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.listenToolStripMenuItem.Text = "Listen";
            // 
            // playItem
            // 
            this.playItem.Name = "playItem";
            this.playItem.Size = new System.Drawing.Size(180, 22);
            this.playItem.Text = "Play";
            this.playItem.Click += new System.EventHandler(this.playItem_Click);
            // 
            // stopItem
            // 
            this.stopItem.Name = "stopItem";
            this.stopItem.Size = new System.Drawing.Size(180, 22);
            this.stopItem.Text = "Stop";
            this.stopItem.Click += new System.EventHandler(this.stopItem_Click);
            // 
            // pauseItem
            // 
            this.pauseItem.Name = "pauseItem";
            this.pauseItem.Size = new System.Drawing.Size(180, 22);
            this.pauseItem.Text = "Pause";
            this.pauseItem.Click += new System.EventHandler(this.pauseItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sineItem,
            this.sineParamsItem,
            this.sineWavesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.allHarmonicsToolStripMenuItem,
            this.oddHarmonicsToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // sineItem
            // 
            this.sineItem.Name = "sineItem";
            this.sineItem.Size = new System.Drawing.Size(180, 22);
            this.sineItem.Text = "Make Sine";
            this.sineItem.Click += new System.EventHandler(this.sineItem_Click);
            // 
            // sineParamsItem
            // 
            this.sineParamsItem.Name = "sineParamsItem";
            this.sineParamsItem.Size = new System.Drawing.Size(180, 22);
            this.sineParamsItem.Text = "Sine Parameters";
            this.sineParamsItem.Click += new System.EventHandler(this.sineParamsItem_Click);
            // 
            // sineWavesToolStripMenuItem
            // 
            this.sineWavesToolStripMenuItem.Name = "sineWavesToolStripMenuItem";
            this.sineWavesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sineWavesToolStripMenuItem.Text = "Sine Waves";
            this.sineWavesToolStripMenuItem.Click += new System.EventHandler(this.sineWavesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "234";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenu234_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "357";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenu357_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeAdjustItem,
            this.rampToolStripMenuItem,
            this.tremoloToolStripMenuItem,
            this.halfSpeedToolStripMenuItem,
            this.doubleSpeedToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // volumeAdjustItem
            // 
            this.volumeAdjustItem.Name = "volumeAdjustItem";
            this.volumeAdjustItem.Size = new System.Drawing.Size(180, 22);
            this.volumeAdjustItem.Text = "Volume Adjust";
            this.volumeAdjustItem.Click += new System.EventHandler(this.volumeAdjustItem_Click);
            // 
            // renderFormatToolStripMenuItem
            // 
            this.renderFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeItem,
            this.lightModeItem});
            this.renderFormatToolStripMenuItem.Name = "renderFormatToolStripMenuItem";
            this.renderFormatToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.renderFormatToolStripMenuItem.Text = "Render Format";
            // 
            // darkModeItem
            // 
            this.darkModeItem.Name = "darkModeItem";
            this.darkModeItem.Size = new System.Drawing.Size(135, 22);
            this.darkModeItem.Text = "Dark Mode";
            this.darkModeItem.Click += new System.EventHandler(this.darkModeItem_Click);
            // 
            // lightModeItem
            // 
            this.lightModeItem.Name = "lightModeItem";
            this.lightModeItem.Size = new System.Drawing.Size(135, 22);
            this.lightModeItem.Text = "Light Mode";
            this.lightModeItem.Click += new System.EventHandler(this.lightModeItem_Click);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar.Location = new System.Drawing.Point(0, 433);
            this.hScrollBar.Maximum = 1000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(800, 17);
            this.hScrollBar.TabIndex = 1;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.vScrollBar.Location = new System.Drawing.Point(0, 24);
            this.vScrollBar.Maximum = 1000;
            this.vScrollBar.Minimum = 1;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 409);
            this.vScrollBar.TabIndex = 2;
            this.vScrollBar.Value = 5;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Wave Files (*.wav)|*.wav| MP3 (*.mp3)|*.mp3|All Files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Wave Files (*.wav)|*.wav| MP3 (*.mp3)|*.mp3";
            // 
            // allHarmonicsToolStripMenuItem
            // 
            this.allHarmonicsToolStripMenuItem.Name = "allHarmonicsToolStripMenuItem";
            this.allHarmonicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allHarmonicsToolStripMenuItem.Text = "All Harmonics";
            this.allHarmonicsToolStripMenuItem.Click += new System.EventHandler(this.allHarmonicsToolStripMenuItem_Click);
            // 
            // oddHarmonicsToolStripMenuItem
            // 
            this.oddHarmonicsToolStripMenuItem.Name = "oddHarmonicsToolStripMenuItem";
            this.oddHarmonicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oddHarmonicsToolStripMenuItem.Text = "Odd Harmonics";
            this.oddHarmonicsToolStripMenuItem.Click += new System.EventHandler(this.oddHarmonicsToolStripMenuItem_Click);
            // 
            // rampToolStripMenuItem
            // 
            this.rampToolStripMenuItem.Name = "rampToolStripMenuItem";
            this.rampToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rampToolStripMenuItem.Text = "Ramp";
            this.rampToolStripMenuItem.Click += new System.EventHandler(this.rampToolStripMenuItem_Click);
            // 
            // tremoloToolStripMenuItem
            // 
            this.tremoloToolStripMenuItem.Name = "tremoloToolStripMenuItem";
            this.tremoloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tremoloToolStripMenuItem.Text = "Tremolo";
            this.tremoloToolStripMenuItem.Click += new System.EventHandler(this.tremoloToolStripMenuItem_Click);
            // 
            // halfSpeedToolStripMenuItem
            // 
            this.halfSpeedToolStripMenuItem.Name = "halfSpeedToolStripMenuItem";
            this.halfSpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.halfSpeedToolStripMenuItem.Text = "Half Speed";
            this.halfSpeedToolStripMenuItem.Click += new System.EventHandler(this.halfSpeedToolStripMenuItem_Click);
            // 
            // doubleSpeedToolStripMenuItem
            // 
            this.doubleSpeedToolStripMenuItem.Name = "doubleSpeedToolStripMenuItem";
            this.doubleSpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleSpeedToolStripMenuItem.Text = "Double Speed";
            this.doubleSpeedToolStripMenuItem.Click += new System.EventHandler(this.doubleSpeedToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tutorial 3 Baker Dalton";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem closeItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem openDefaultItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem listenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playItem;
        private System.Windows.Forms.ToolStripMenuItem stopItem;
        private System.Windows.Forms.ToolStripMenuItem pauseItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sineItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private System.Windows.Forms.ToolStripMenuItem renderFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeItem;
        private System.Windows.Forms.ToolStripMenuItem sineParamsItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeAdjustItem;
        private System.Windows.Forms.ToolStripMenuItem sineWavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem allHarmonicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddHarmonicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tremoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
    }
}

