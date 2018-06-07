using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Marathon.Types;

namespace Marathon
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            ReloadFormData();
        }

        private void ReloadFormData()
        {
            Settings.LoadSettingsFile();

            JarPathBox.Text = Settings.Singleton.serverJarPath;
            VanillaJarBox.Checked = Settings.Singleton.defaultJar;
            RamBox.Text = Settings.Singleton.dedicatedRam.value.ToString();
            RamUnitBox.Text = Settings.Singleton.dedicatedRam.unit.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(JarPathBox.Text, DigitalStorageValue.Parse(RamBox.Text + RamUnitBox.Text), VanillaJarBox.Checked);
            settings.SaveSettingsFile();
            Settings.LoadSettingsFile();
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogJarPath.ShowDialog();
            JarPathBox.Text = openFileDialogJarPath.FileName;
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show("Are you sure you want a new settings file?" + Environment.NewLine + "The old one will be deleted.", "Marathon Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result1 == DialogResult.OK)
            {
                Settings.SaveSettingsDefaultFile();
                ReloadFormData();
            }
        }

        private void SettingsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
