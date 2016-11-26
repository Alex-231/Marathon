using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Marathon
{
    public partial class Main : Form
    {
        public string SettingsFileLocation = "\\Resources\\Settings.txt";
        //This should be in the executable.
        public string SettingsTemplateLocation = "\\Resources\\SettingsTemplate.txt";

        public Main()
        {
            InitializeComponent();

            //If the settings file doesnt exist, make a template.
            //This should be in it's own method.
            //The template should be copied from a resource contained within the executable.
            if(!File.Exists(SettingsFileLocation))
            {
                using (StreamWriter writer =
                new StreamWriter(File.OpenRead(Settings.SettingsFileLocation)))
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

            //If the backups folder doesn't exist, make it.
            //Again, this should be in a seperate method.
            if(!Directory.Exists("\\Backups"))
            {
                Directory.CreateDirectory("\\Backups");
            }
            //^^^
            if (!Directory.Exists("\\Backups\\Day-Month-Year   Hour;Minute;Second"))
            {
                Directory.CreateDirectory("\\Backups\\Day-Month-Year   Hour;Minute;Second");
            }
            //Again, this template needs to be copied from the exe rather than created here.
            if (!File.Exists(SettingsTemplateLocation))
            {
                using (StreamWriter writer =
                new StreamWriter(SettingsTemplateLocation))
                {
                    writer.WriteLine("Marathon Settings (Template, Please edit Settings.txt. Any changes made to this file will be lost.)");
                    writer.WriteLine("");
                    writer.WriteLine("Server Jar Path:");
                    writer.WriteLine(@"C:\Example\bukkit.jar");
                    writer.WriteLine("");
                    writer.WriteLine("Dedicated Ram (Any unit is accepted, so you can use 1GB):");
                    writer.WriteLine("1024MB");
                    writer.WriteLine("");
                    writer.WriteLine("Backups Enabled (if backups are enabled a backup of the server will be created upon launch. This wont work in alpha.):");
                    writer.WriteLine("true");
                    writer.WriteLine("");
                    writer.WriteLine("File created at " + DateTime.Now.ToString("h:mm:ss tt") + " on " + DateTime.Now.Date.ToString("dddd dd MMMM, yyyy"));
                    //writer.WriteLine(MarathonVersion);
                }
            }
        }
        private void Main_Load(Object sender, EventArgs e)
        {
            //NO
            PerformanceBox.Text = "Memory usage: \nAvailable MBytes / DedicatedRam\nAvalible Memory: \nDedicatedRam - Memory " +
    "Used\nCPU Usage:\n% Processor Time";

            //Reads settings
            StreamReader sr = new StreamReader((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];
            string DedicatedRamRaw = lines[6];
            string DefaultJarRaw = lines[9];

            //If the server jar path is empty, the user is probably launching for the first time,
            //so open up the settings form.
            if (string.IsNullOrEmpty(ServerJarPath))
            {
                Settings SettingsForm = new Settings();
                SettingsForm.ShowDialog();
            }
            //Also if any of these settings are missing or incorrect, show the settings form.
            else
            {
                if (string.IsNullOrEmpty(DedicatedRamRaw))
                {
                    Settings SettingsForm = new Settings();
                    SettingsForm.ShowDialog();
                }
                else
                {
                    if (string.IsNullOrEmpty(DefaultJarRaw))
                    {
                        Settings SettingsForm = new Settings();
                        SettingsForm.ShowDialog();
                    }
                    else
                    {
                        if (Regex.IsMatch(DedicatedRamRaw, @"^[a-zA-Z]+$"))
                        {
                            Settings SettingsForm = new Settings();
                            SettingsForm.ShowDialog();
                        }
                        else
                        {
                            if (Regex.IsMatch(DedicatedRamRaw, @"^-?\d+$"))
                            {
                                Settings SettingsForm = new Settings();
                                SettingsForm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings SettingsForm = new Settings();
            SettingsForm.ShowDialog();
        }
        private void ShortcutsButton_Click(object sender, EventArgs e)
        {
            Shortcuts ShortcutsForm = new Shortcuts();
            ShortcutsForm.ShowDialog();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            ServerConsole.StartProcess(((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CMarathonConsole.exe")), "");
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            ServerConsole.StopProcess();
            //If the process doesn't stop, this will freeze Marathon!
            //Really need to stop doing this.
            //Maybe I could implement a callback?
            while(ServerConsole.IsProcessRunning == true)
            { 
            }
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            ServerConsole.StopProcess();
            //If the process doesn't stop, this will freeze Marathon!
            //Again, this is bad!
            while (ServerConsole.IsProcessRunning == true)
            {
            }
            ServerConsole.StartProcess(((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CMarathonConsole.exe")), "");
        }

        //Console input.
        private void ConsoleInButton_Click(object sender, EventArgs e)
        {
            if(ServerConsole.IsProcessRunning)
            {
                ServerConsole.WriteInput(ConsoleInBox.Text + Environment.NewLine, Color.Black , true);
                ConsoleInBox.Text = "";
            }
        }

        //If Marathon is closing, close the server too.
        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            if (ServerConsole.IsProcessRunning == true)
            {
                ServerConsole.WriteInput("stop" + Environment.NewLine, Color.FromArgb(255,122,0,0), true);
                ServerConsole.StopProcess();
            }
        }

        private void ConsoleInBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If the user presses enter, send the input.
            if (e.KeyChar == (char)13)
            {
                ServerConsole.WriteInput(ConsoleInBox.Text + Environment.NewLine, Color.Black, true);
                ConsoleInBox.Text = "";
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            var BackupBox = MessageBox.Show("Are you sure you would like to start a backup?" + Environment.NewLine + "Backups can take a few minutes, and Marathon will be unusable during this time.", "Marathon Backups", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (BackupBox == DialogResult.OK)
            {

                //Reads settings
                StreamReader sr = new StreamReader((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));
                List<string> lines = new List<string>();
                while (!sr.EndOfStream)
                    lines.Add(sr.ReadLine());
                sr.Close();

                string FolderName = DateTime.Now.Date.ToString("dd-MMMM-yy   ") + DateTime.Now.ToString("HH;mm;ss");
                Directory.CreateDirectory(System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups\u005c" + FolderName);

                //settings variables
                string ServerJarPath = lines[3];
                string ServerDir = (ServerJarPath.Remove(ServerJarPath.LastIndexOf("\\")));

                //WHAT WAS I THINKING!
                //Also, this takes a very long time, and freezes Marathon.
                //I need to fix this.
                new Microsoft.VisualBasic.Devices.Computer().
                    FileSystem.CopyDirectory(ServerDir, (System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups\u005c" + FolderName));

            }
        }
    }
}