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
        public Main()
        {
            if (Properties.Settings.Default.firstLaunch)
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.ShowDialog();

                Properties.Settings.Default.firstLaunch = false;
                Properties.Settings.Default.Save();
            }

            InitializeComponent();
        }

        private void StartServer()
        {
            ServerConsole.StartProcess("java", " -Xmx" + Settings.Singleton.dedicatedRam.ToString() + " -jar \"" + Settings.Singleton.serverJarPath + "\" nogui");
        }

        private void StopServer()
        {

        }

        private void Main_Load(Object sender, EventArgs e)
        {
            //NO
            PerformanceBox.Text = "Memory usage: \nAvailable MBytes / DedicatedRam\nAvalible Memory: \nDedicatedRam - Memory " +
    "Used\nCPU Usage:\n% Processor Time";

        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm SettingsForm = new SettingsForm();
            SettingsForm.ShowDialog();
        }
        private void ShortcutsButton_Click(object sender, EventArgs e)
        {
            Shortcuts ShortcutsForm = new Shortcuts();
            ShortcutsForm.ShowDialog();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartServer();
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
            ServerConsole.StartProcess(Settings.Singleton.serverJarPath, "");
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