namespace Marathon
{
    partial class Main
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
            this.ServerConsole = new ConsoleControl.ConsoleControl();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsoleInButton = new System.Windows.Forms.Button();
            this.ConsoleInBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShortcutsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.UpdatesButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PerformanceBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerConsole);
            this.groupBox1.Controls.Add(this.ConsoleInButton);
            this.groupBox1.Controls.Add(this.ConsoleInBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // ServerConsole
            // 
            this.ServerConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerConsole.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerConsole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServerConsole.IsInputEnabled = false;
            this.ServerConsole.Location = new System.Drawing.Point(6, 14);
            this.ServerConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerConsole.Name = "ServerConsole";
            this.ServerConsole.SendKeyboardCommandsToProcess = false;
            this.ServerConsole.ShowDiagnostics = true;
            this.ServerConsole.Size = new System.Drawing.Size(608, 390);
            this.ServerConsole.TabIndex = 4;
            this.ServerConsole.OnConsoleOutput += new ConsoleControl.ConsoleEventHandler(this.ServerConsole_OnConsoleOutput);
            // 
            // ConsoleInButton
            // 
            this.ConsoleInButton.Location = new System.Drawing.Point(539, 403);
            this.ConsoleInButton.Name = "ConsoleInButton";
            this.ConsoleInButton.Size = new System.Drawing.Size(75, 22);
            this.ConsoleInButton.TabIndex = 2;
            this.ConsoleInButton.Text = "Send";
            this.ConsoleInButton.UseVisualStyleBackColor = true;
            this.ConsoleInButton.Click += new System.EventHandler(this.ConsoleInButton_Click);
            // 
            // ConsoleInBox
            // 
            this.ConsoleInBox.Location = new System.Drawing.Point(6, 404);
            this.ConsoleInBox.Name = "ConsoleInBox";
            this.ConsoleInBox.Size = new System.Drawing.Size(538, 20);
            this.ConsoleInBox.TabIndex = 1;
            this.ConsoleInBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConsoleInBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShortcutsButton);
            this.groupBox2.Controls.Add(this.SettingsButton);
            this.groupBox2.Controls.Add(this.AboutButton);
            this.groupBox2.Controls.Add(this.BackupButton);
            this.groupBox2.Controls.Add(this.UpdatesButton);
            this.groupBox2.Location = new System.Drawing.Point(632, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marathon";
            // 
            // ShortcutsButton
            // 
            this.ShortcutsButton.Location = new System.Drawing.Point(6, 104);
            this.ShortcutsButton.Name = "ShortcutsButton";
            this.ShortcutsButton.Size = new System.Drawing.Size(188, 23);
            this.ShortcutsButton.TabIndex = 6;
            this.ShortcutsButton.Text = "Shortcuts";
            this.ShortcutsButton.UseVisualStyleBackColor = true;
            this.ShortcutsButton.Click += new System.EventHandler(this.ShortcutsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(6, 133);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(188, 23);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(6, 46);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(188, 23);
            this.AboutButton.TabIndex = 6;
            this.AboutButton.Text = "About Marathon";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(6, 75);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(188, 23);
            this.BackupButton.TabIndex = 4;
            this.BackupButton.Text = "Create Backup";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // UpdatesButton
            // 
            this.UpdatesButton.Enabled = false;
            this.UpdatesButton.Location = new System.Drawing.Point(6, 17);
            this.UpdatesButton.Name = "UpdatesButton";
            this.UpdatesButton.Size = new System.Drawing.Size(188, 23);
            this.UpdatesButton.TabIndex = 0;
            this.UpdatesButton.Text = "Check For Updates";
            this.UpdatesButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RestartButton);
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Controls.Add(this.StartButton);
            this.groupBox3.Location = new System.Drawing.Point(632, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Controls";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(134, 19);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(60, 23);
            this.RestartButton.TabIndex = 2;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(71, 19);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(59, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(6, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(60, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PerformanceBox);
            this.groupBox4.Location = new System.Drawing.Point(632, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 204);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Performance";
            // 
            // PerformanceBox
            // 
            this.PerformanceBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PerformanceBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PerformanceBox.Location = new System.Drawing.Point(6, 19);
            this.PerformanceBox.Name = "PerformanceBox";
            this.PerformanceBox.ReadOnly = true;
            this.PerformanceBox.Size = new System.Drawing.Size(188, 84);
            this.PerformanceBox.TabIndex = 1;
            this.PerformanceBox.Text = "Memory usage: \nMemoryUsed / DedicatedRam\nAvalible Memory: \nDedicatedRam - Memory " +
    "Used\nCPU Usage:\nCPUUsage";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(838, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Marathon Minecraft Server GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConsoleInButton;
        private System.Windows.Forms.TextBox ConsoleInBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UpdatesButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox PerformanceBox;
        private System.Windows.Forms.Button ShortcutsButton;
        private ConsoleControl.ConsoleControl ServerConsole;
    }
}

