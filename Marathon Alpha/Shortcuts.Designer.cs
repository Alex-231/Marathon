namespace Marathon
{
    partial class Shortcuts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shortcuts));
            this.PluginsButton = new System.Windows.Forms.Button();
            this.PropertiesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderButton = new System.Windows.Forms.Button();
            this.MarathonButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.ShortcutsClose = new System.Windows.Forms.Button();
            this.BackupsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ConsoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PluginsButton
            // 
            this.PluginsButton.Location = new System.Drawing.Point(12, 25);
            this.PluginsButton.Name = "PluginsButton";
            this.PluginsButton.Size = new System.Drawing.Size(125, 23);
            this.PluginsButton.TabIndex = 0;
            this.PluginsButton.Text = "Plugins Folder";
            this.PluginsButton.UseVisualStyleBackColor = true;
            this.PluginsButton.Click += new System.EventHandler(this.PluginsButton_Click);
            // 
            // PropertiesButton
            // 
            this.PropertiesButton.Location = new System.Drawing.Point(147, 25);
            this.PropertiesButton.Name = "PropertiesButton";
            this.PropertiesButton.Size = new System.Drawing.Size(125, 23);
            this.PropertiesButton.TabIndex = 1;
            this.PropertiesButton.Text = "Server Properties";
            this.PropertiesButton.UseVisualStyleBackColor = true;
            this.PropertiesButton.Click += new System.EventHandler(this.PropertiesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The buttons below open their corresponding files/folders.";
            // 
            // FolderButton
            // 
            this.FolderButton.Location = new System.Drawing.Point(12, 54);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(125, 23);
            this.FolderButton.TabIndex = 3;
            this.FolderButton.Text = "Server Folder";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // MarathonButton
            // 
            this.MarathonButton.Location = new System.Drawing.Point(147, 54);
            this.MarathonButton.Name = "MarathonButton";
            this.MarathonButton.Size = new System.Drawing.Size(125, 23);
            this.MarathonButton.TabIndex = 4;
            this.MarathonButton.Text = "Marathon Folder";
            this.MarathonButton.UseVisualStyleBackColor = true;
            this.MarathonButton.Click += new System.EventHandler(this.MarathonButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(12, 83);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(125, 23);
            this.LogButton.TabIndex = 8;
            this.LogButton.Text = "Logs Folder";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // ShortcutsClose
            // 
            this.ShortcutsClose.Location = new System.Drawing.Point(183, 151);
            this.ShortcutsClose.Name = "ShortcutsClose";
            this.ShortcutsClose.Size = new System.Drawing.Size(89, 23);
            this.ShortcutsClose.TabIndex = 9;
            this.ShortcutsClose.Text = "Close";
            this.ShortcutsClose.UseVisualStyleBackColor = true;
            this.ShortcutsClose.Click += new System.EventHandler(this.ShortcutsClose_Click);
            // 
            // BackupsButton
            // 
            this.BackupsButton.Location = new System.Drawing.Point(147, 83);
            this.BackupsButton.Name = "BackupsButton";
            this.BackupsButton.Size = new System.Drawing.Size(125, 23);
            this.BackupsButton.TabIndex = 10;
            this.BackupsButton.Text = "Backups Folder";
            this.BackupsButton.UseVisualStyleBackColor = true;
            this.BackupsButton.Click += new System.EventHandler(this.BackupsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 112);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(125, 23);
            this.SettingsButton.TabIndex = 11;
            this.SettingsButton.Text = "Settings File";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.Location = new System.Drawing.Point(147, 112);
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.Size = new System.Drawing.Size(125, 23);
            this.ConsoleButton.TabIndex = 12;
            this.ConsoleButton.Text = "Marathon Console";
            this.ConsoleButton.UseVisualStyleBackColor = true;
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // Shortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.ConsoleButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.BackupsButton);
            this.Controls.Add(this.ShortcutsClose);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.MarathonButton);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PropertiesButton);
            this.Controls.Add(this.PluginsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shortcuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shortcuts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PluginsButton;
        private System.Windows.Forms.Button PropertiesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Button MarathonButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Button ShortcutsClose;
        private System.Windows.Forms.Button BackupsButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ConsoleButton;
    }
}