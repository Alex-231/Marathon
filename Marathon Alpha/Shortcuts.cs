using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    //This class is really dumb.
    //For some reason I kept repeating code.
    //This thing has already been refactored a lot too,
    //I don't want to imagine how it used to be...
    public partial class Shortcuts : Form
    {
        public Shortcuts()
        {
            InitializeComponent();

            #region Settings StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
            lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = (ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C")));
            #endregion

            #region ButtonEnablers

            if (!Directory.Exists(ServerDir + @"\plugins"))
                PluginsButton.Enabled = false;
            else
                PluginsButton.Enabled = true;

            if (!File.Exists(ServerDir + @"\server.properties"))
                PropertiesButton.Enabled = false;
            else
                PropertiesButton.Enabled = true;

            if (!Directory.Exists(ServerDir))
                FolderButton.Enabled = false;
            else
                FolderButton.Enabled = true;

            if (!Directory.Exists(MarathonDir))
                MarathonButton.Enabled = false;
            else
                MarathonButton.Enabled = true;

            if (!Directory.Exists(ServerDir + @"\logs"))
                LogButton.Enabled = false;
            else
                LogButton.Enabled = true;

            if (!Directory.Exists(MarathonDir + @"\Backups"))
                BackupsButton.Enabled = false;
            else
                BackupsButton.Enabled = true;

            #endregion
        }

        

        private void ShortcutsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PluginsButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(ServerDir + @"\plugins");
        }

        private void PropertiesButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(ServerDir + @"\server.properties");
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(ServerDir);
        }

        private void MarathonButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(MarathonDir);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(ServerDir + @"\logs");
        }

        private void BackupsButton_Click(object sender, EventArgs e)
        {
            #region StreamReader
            string SettingsFileLocation = ((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));

            //Reads settings
            StreamReader sr = new StreamReader(SettingsFileLocation);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //settings variables
            string ServerJarPath = lines[3];

            string MarathonDir = System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C"));
            string ServerDir = ServerJarPath.Remove(ServerJarPath.LastIndexOf("\u005C"));
            #endregion

            Process.Start(MarathonDir + @"\Backups");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Process.Start((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CSettings.txt"));
        }

        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            Process.Start((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.LastIndexOf("\u005C")) + "\u005CResources\u005CMarathonConsole.exe"));
        }
    }
}
