using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Marathon
{
    public partial class Settings : Form
    {
        //Refactor these.
        public const string SettingsFileLocation = "\\Resources\\Settings.txt";
        public const string SettingsTemplateLocation = "\\Resources\\SettingsTemplate.txt";

        //There's a lot of form setup in this constructor.
        //I can probably organize this better.
        public Settings()
        {
            InitializeComponent();

            if (File.Exists(SettingsFileLocation))
            {
                //Reads settings
                StreamReader sr = new StreamReader(SettingsFileLocation);
                List<string> lines = new List<string>();
                while (!sr.EndOfStream)
                    lines.Add(sr.ReadLine());
                sr.Close();

                //settings variables
                string ServerJarPath = lines[3];
                string DedicatedRamRaw = lines[6];
                string DefaultJarRaw = lines[9];

                //I should probably be using a property.
                if(string.IsNullOrEmpty(DefaultJarRaw))
                    VanillaJarBox.Checked = false;
                else
                {
                    bool DefaultJar = Convert.ToBoolean(DefaultJarRaw);
                    VanillaJarBox.Checked = DefaultJar;
                }

                if(string.IsNullOrEmpty(DedicatedRamRaw))
                {
                    RamBox.Text = "";
                    RamUnitBox.Text = "";
                }
                else
                {
                    string DedicatedRam = Regex.Replace(DedicatedRamRaw, "[A-Za-z ]", "");
                    string DedicatedRamUnit = DedicatedRamRaw.Remove(0, DedicatedRam.Length);
                    RamBox.Text = DedicatedRam;
                    RamUnitBox.Text = DedicatedRamUnit;
                }

                if(string.IsNullOrEmpty(ServerJarPath))
                    JarPathBox.Text = "";
                else
                    JarPathBox.Text = ServerJarPath;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Fix the templates...
            using (StreamWriter writer =
            new StreamWriter(SettingsFileLocation))
            {
                writer.WriteLine("Marathon Settings (Please read the template before editing this file.)");
                writer.WriteLine("");
                writer.WriteLine("Server Jar Path:");
                writer.WriteLine(JarPathBox.Text);
                writer.WriteLine("");
                writer.WriteLine("Dedicated Ram:");
                writer.WriteLine(RamBox.Text + RamUnitBox.Text);
                writer.WriteLine("");
                writer.WriteLine("Default Jar?:");
                writer.WriteLine(VanillaJarBox.Checked.ToString());
                writer.WriteLine("");
                writer.WriteLine("File created at " + DateTime.Now.ToString("h:mm:ss tt") + " on " + DateTime.Now.Date.ToString("dddd dd MMMM, yyyy"));
                //writer.WriteLine(MarathonVersion);
            }
            Process.Start((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CMarathon.exe"));
            Environment.Exit(0);
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogJarPath.ShowDialog();
            //Not sure why I made this.
            //if(result == DialogResult.OK)
            //{
            //}
            //Property this?
            JarPathBox.Text = openFileDialogJarPath.FileName;
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show("Are you sure you want a new settings file?" + Environment.NewLine + "The old one will be deleted.", "Marathon Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result1 == DialogResult.OK)
            {
                //Template....
                using (StreamWriter writer =
                new StreamWriter(SettingsFileLocation))
                {
                    writer.WriteLine("Marathon Settings (Please read the template before editing this file.)");
                    writer.WriteLine("");
                    writer.WriteLine("Server Jar Path:");
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("Dedicated Ram:");
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("Default Jar?:");
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("File created at " + DateTime.Now.ToString("h:mm:ss tt") + " on " + DateTime.Now.Date.ToString("dddd dd MMMM, yyyy"));
                    //writer.WriteLine(MarathonVersion);
                }
            }
        }

        private void SettingsClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
