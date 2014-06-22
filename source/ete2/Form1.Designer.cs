namespace ete2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTimerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.file_exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timers_addTimerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.help_checkForUpdatesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.help_aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timers_clearAllTimersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTimerBtn,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 45);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "eteToolStrip";
            // 
            // addTimerBtn
            // 
            this.addTimerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTimerBtn.Image = global::ete2.Properties.Resources.add_timer;
            this.addTimerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTimerBtn.Name = "addTimerBtn";
            this.addTimerBtn.Size = new System.Drawing.Size(36, 42);
            this.addTimerBtn.Text = "Add a New Timer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ete2.Properties.Resources.remove_timer;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 42);
            this.toolStripButton1.Text = "Clear All Timers";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.timersMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // file_exitMenu
            // 
            this.file_exitMenu.Name = "file_exitMenu";
            this.file_exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.file_exitMenu.Size = new System.Drawing.Size(134, 22);
            this.file_exitMenu.Text = "E&xit";
            // 
            // timersMenu
            // 
            this.timersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timers_addTimerMenu,
            this.timers_clearAllTimersMenu});
            this.timersMenu.Name = "timersMenu";
            this.timersMenu.Size = new System.Drawing.Size(55, 20);
            this.timersMenu.Text = "&Timers";
            // 
            // timers_addTimerMenu
            // 
            this.timers_addTimerMenu.Image = global::ete2.Properties.Resources.add_timer;
            this.timers_addTimerMenu.Name = "timers_addTimerMenu";
            this.timers_addTimerMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.timers_addTimerMenu.Size = new System.Drawing.Size(231, 22);
            this.timers_addTimerMenu.Text = "&Add a New Timer";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_checkForUpdatesMenu,
            this.toolStripSeparator2,
            this.help_aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // help_checkForUpdatesMenu
            // 
            this.help_checkForUpdatesMenu.Name = "help_checkForUpdatesMenu";
            this.help_checkForUpdatesMenu.Size = new System.Drawing.Size(171, 22);
            this.help_checkForUpdatesMenu.Text = "Check for &Updates";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // help_aboutMenu
            // 
            this.help_aboutMenu.Name = "help_aboutMenu";
            this.help_aboutMenu.Size = new System.Drawing.Size(171, 22);
            this.help_aboutMenu.Text = "&About";
            // 
            // timers_clearAllTimersMenu
            // 
            this.timers_clearAllTimersMenu.Image = global::ete2.Properties.Resources.remove_timer;
            this.timers_clearAllTimersMenu.Name = "timers_clearAllTimersMenu";
            this.timers_clearAllTimersMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.timers_clearAllTimersMenu.Size = new System.Drawing.Size(231, 22);
            this.timers_clearAllTimersMenu.Text = "&Clear All Timers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 317);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Egg Timers Elite 2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTimerBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem file_exitMenu;
        private System.Windows.Forms.ToolStripMenuItem timersMenu;
        private System.Windows.Forms.ToolStripMenuItem timers_addTimerMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem help_checkForUpdatesMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem help_aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem timers_clearAllTimersMenu;

    }
}

