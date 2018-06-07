using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    public static class Backups
    {
        static Backups()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Backups"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Backups");
            }

            if (!Directory.Exists(Environment.CurrentDirectory + "\\Backups\\Day-Month-Year   Hour;Minute;Second"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Backups\\Day-Month-Year   Hour;Minute;Second");
            }
        }
    }
}
