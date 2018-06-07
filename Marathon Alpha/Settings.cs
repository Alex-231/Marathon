using Marathon.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    public class Settings
    {
        static Settings()
        {
            SaveSettingsTemplateFile();

            try
            {
                singleton = LoadSettingsFile(settingsFileLocation);
            }
            catch (FileNotFoundException)
            {
                SaveSettingsDefaultFile();
                singleton = LoadSettingsFile(settingsFileLocation);
            }
        }

        private static string settingsFileLocation = Environment.CurrentDirectory + "\\Resources\\Settings.txt";
        private static string settingsTemplateLocation = Environment.CurrentDirectory + "\\Resources\\SettingsTemplate.txt";

        private static Settings singleton;
        public static Settings Singleton
        {
            get
            {
                if (singleton == null)
                    LoadSettingsFile();

                return singleton;
            }
        }

        public string serverJarPath;
        public DigitalStorageValue dedicatedRam;
        public bool defaultJar;
        //public DateTime configDate;
        //public Version configVersion;

        public Settings(string serverJarPath, DigitalStorageValue dedicatedRam, bool defaultJar)
        {
            this.serverJarPath = serverJarPath;
            this.dedicatedRam = dedicatedRam;
            this.defaultJar = defaultJar;
        }

        public static void LoadSettingsFile()
        {
            singleton = LoadSettingsFile(settingsFileLocation);
        }

        public void SaveSettingsFile()
        {
            SaveSettingsFile(settingsFileLocation);
        }

        public static void SaveSettingsTemplateFile()
        {
            SaveSettingsTemplateFile(settingsTemplateLocation);
        }

        public static void SaveSettingsDefaultFile()
        {
            SaveSettingsDefaultFile(settingsFileLocation);
        }

        private static Settings LoadSettingsFile(string settingsFilePath)
        {
            if (!File.Exists(settingsFilePath))
                throw new FileNotFoundException("Settings file " + settingsFilePath + " could not be found.");

            //Reads settings
            StreamReader sr = new StreamReader(settingsFilePath);
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            string serverJarPath = lines[3];
            DigitalStorageValue dedicatedRam = DigitalStorageValue.Parse(lines[6]);
            bool defaultJar = Boolean.Parse(lines[9]);

            return new Settings(serverJarPath, dedicatedRam, defaultJar);
        }

        private void SaveSettingsFile(string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine("Marathon Settings (Please read the template before editing this file.)");
                writer.WriteLine("");
                writer.WriteLine("Server Jar Path:");
                writer.WriteLine(serverJarPath);
                writer.WriteLine("");
                writer.WriteLine("Dedicated Ram:");
                writer.WriteLine(dedicatedRam.ToString());
                writer.WriteLine("");
                writer.WriteLine("Default Jar?:");
                writer.WriteLine(defaultJar);
                writer.WriteLine("");
                writer.WriteLine("File created at " + DateTime.Now.ToString("h:mm:ss tt") + " on " + DateTime.Now.Date.ToString("dddd dd MMMM, yyyy"));
                writer.WriteLine("File created by Marathon v" + Assembly.GetEntryAssembly().GetName().Version);
            }
        }

        private static void SaveSettingsDefaultFile(string settingsFilePath)
        {
            using (StreamWriter writer = new StreamWriter(settingsFilePath))
            {
                writer.WriteLine("Marathon Settings (Please read the template before editing this file.)");
                writer.WriteLine("");
                writer.WriteLine("Server Jar Path:");
                writer.WriteLine("C:\\Example\\bukkit.jar");
                writer.WriteLine("");
                writer.WriteLine("Dedicated Ram:");
                writer.WriteLine(new DigitalStorageValue(1024, DigitalStorageValue.DigitalStorageUnit.MB).ToString());
                writer.WriteLine("");
                writer.WriteLine("Default Jar?:");
                writer.WriteLine(false);
                writer.WriteLine("");
                writer.WriteLine("File created at " + DateTime.Now.ToString("h:mm:ss tt") + " on " + DateTime.Now.Date.ToString("dddd dd MMMM, yyyy"));
                writer.WriteLine("File created by Marathon v" + Assembly.GetEntryAssembly().GetName().Version);
            }
        }

        private static void SaveSettingsTemplateFile(string settingsTemplateFilePath)
        {
            //Template....
            using (StreamWriter writer = new StreamWriter(settingsTemplateFilePath))
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
                writer.WriteLine("File created by Marathon v" + Assembly.GetEntryAssembly().GetName().Version);
            }
        }
    }
}
