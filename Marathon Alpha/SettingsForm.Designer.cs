namespace Marathon
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.JarPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RamBox = new System.Windows.Forms.TextBox();
            this.RamUnitBox = new System.Windows.Forms.ComboBox();
            this.openFileDialogJarPath = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SettingsClose = new System.Windows.Forms.Button();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.VanillaJarBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // JarPathBox
            // 
            this.JarPathBox.Location = new System.Drawing.Point(12, 25);
            this.JarPathBox.Name = "JarPathBox";
            this.JarPathBox.Size = new System.Drawing.Size(185, 20);
            this.JarPathBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Jar Path";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(197, 24);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 22);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dedicated Ram";
            // 
            // RamBox
            // 
            this.RamBox.Location = new System.Drawing.Point(12, 64);
            this.RamBox.Name = "RamBox";
            this.RamBox.Size = new System.Drawing.Size(74, 20);
            this.RamBox.TabIndex = 5;
            // 
            // RamUnitBox
            // 
            this.RamUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RamUnitBox.FormattingEnabled = true;
            this.RamUnitBox.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.RamUnitBox.Location = new System.Drawing.Point(87, 63);
            this.RamUnitBox.Name = "RamUnitBox";
            this.RamUnitBox.Size = new System.Drawing.Size(74, 21);
            this.RamUnitBox.TabIndex = 6;
            // 
            // openFileDialogJarPath
            // 
            this.openFileDialogJarPath.DefaultExt = "jar";
            this.openFileDialogJarPath.FileName = "Minecraft Server.jar";
            this.openFileDialogJarPath.SupportMultiDottedExtensions = true;
            this.openFileDialogJarPath.Title = "Select Minecraft Server Jar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(190, 128);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsClose
            // 
            this.SettingsClose.Location = new System.Drawing.Point(12, 128);
            this.SettingsClose.Name = "SettingsClose";
            this.SettingsClose.Size = new System.Drawing.Size(75, 23);
            this.SettingsClose.TabIndex = 11;
            this.SettingsClose.Text = "Cancel";
            this.SettingsClose.UseVisualStyleBackColor = true;
            this.SettingsClose.Click += new System.EventHandler(this.SettingsClose_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(90, 128);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(97, 23);
            this.NewFileButton.TabIndex = 12;
            this.NewFileButton.Text = "New Settings File";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // VanillaJarBox
            // 
            this.VanillaJarBox.AutoSize = true;
            this.VanillaJarBox.Location = new System.Drawing.Point(13, 95);
            this.VanillaJarBox.Name = "VanillaJarBox";
            this.VanillaJarBox.Size = new System.Drawing.Size(80, 17);
            this.VanillaJarBox.TabIndex = 16;
            this.VanillaJarBox.Text = "Vanilla Jar?";
            this.VanillaJarBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.VanillaJarBox);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.SettingsClose);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RamUnitBox);
            this.Controls.Add(this.RamBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JarPathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marathon Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JarPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RamBox;
        private System.Windows.Forms.ComboBox RamUnitBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogJarPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SettingsClose;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.CheckBox VanillaJarBox;
    }
}