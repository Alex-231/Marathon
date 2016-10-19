using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marathon;
using ConsoleControl;
using ConsoleControlAPI;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace Marathon
{
    public partial class Main : Form
    {
        public string MarathonVersion = "V0.06_2";
        public string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));
        public string SettingsTemplateLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettingsTemplate.txt"));

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr window, int message, int wparam, int lparam);
 
        private const int SbBottom = 0x7;
        private const int WmVscroll = 0x115;

        //call this in a method after appending text in the richtextbox
        //dont forget to change richtextbox1 with youre richtextboxcontrol

        public Main()
        {
            InitializeComponent();

            if(!File.Exists(SettingsFileLocation))
            {
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
                    writer.WriteLine(MarathonVersion);
                }
            }

            if((Directory.Exists(System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups")) == false)
            {
                System.IO.Directory.CreateDirectory((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups"));
            }
            if ((Directory.Exists(System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups\u005CDay-Month-Year   Hour;Minute;Second")) == false)
            {
                System.IO.Directory.CreateDirectory((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups\u005CDay-Month-Year   Hour;Minute;Second"));
            }
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
                    writer.WriteLine(MarathonVersion);
                }
            }
        }
        private void Main_Load(Object sender, EventArgs e)
        {
            this.PerformanceBox.Text = "Memory usage: \nAvailable MBytes / DedicatedRam\nAvalible Memory: \nDedicatedRam - Memory " +
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

            if (String.IsNullOrEmpty(ServerJarPath))
            {
                Settings SettingsForm = new Settings();
                SettingsForm.ShowDialog();
            }
            else
            {
                if (String.IsNullOrEmpty(DedicatedRamRaw))
                {
                    Settings SettingsForm = new Settings();
                    SettingsForm.ShowDialog();
                }
                else
                {
                    if (String.IsNullOrEmpty(DefaultJarRaw))
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
        private void AboutButton_Click(Object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.ShowDialog();
        }
        private void SettingsButton_Click(Object sender, EventArgs e)
        {
            Settings SettingsForm = new Settings();
            SettingsForm.ShowDialog();
        }
        private void ShortcutsButton_Click(Object sender, EventArgs e)
        {
            Shortcuts ShortcutsForm = new Shortcuts();
            ShortcutsForm.ShowDialog();
        }
        private void StartButton_Click(Object sender, EventArgs e)
        {
            ServerConsole.StartProcess(((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CMarathonConsole.exe")), "");
        }
        private void StopButton_Click(Object sender, EventArgs e)
        {
            ServerConsole.StopProcess();
            while(ServerConsole.IsProcessRunning == true)
            { 
            }
        }
        private void RestartButton_Click(Object sender, EventArgs e)
        {
            ServerConsole.StopProcess();
            while (ServerConsole.IsProcessRunning == true)
            {
            }
            ServerConsole.StartProcess(((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CMarathonConsole.exe")), "");
        }
        private void ServerConsole_OnConsoleOutput(object sender, ConsoleEventArgs args)
        {
            SendMessage(ServerConsole.InternalRichTextBox.Handle, WmVscroll, SbBottom, 0x0);
        }

        private void ConsoleInButton_Click(object sender, EventArgs e)
        {
            if(ServerConsole.IsProcessRunning)
            {
                ServerConsole.WriteInput(ConsoleInBox.Text + Environment.NewLine, Color.Black , true);
                ConsoleInBox.Text = "";
            }
        }

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
            if (e.KeyChar == (char)13)
            {
                ServerConsole.WriteInput(ConsoleInBox.Text + Environment.NewLine, Color.Black, true);
                ConsoleInBox.Text = "";
            }
            else
            {
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
                string ServerDir = (ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C")));

                new Microsoft.VisualBasic.Devices.Computer().
                    FileSystem.CopyDirectory(ServerDir, (System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CBackups\u005c" + FolderName));

            }
        }
    }
}