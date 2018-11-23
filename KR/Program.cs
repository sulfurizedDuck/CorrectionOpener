using KR.Functionalities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            initMatkuls();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Template());
        }

        private static void initMatkuls()
        {
            //TODO : Get Matkuls from a file later
            //StreamReader reader = new StreamReader("selectedDirectories.txt");
            List<String> aList = new List<string>();
            aList.Add(@"\app\src\main");
            Matkul.matkuls.Add(new Matkul("COMP6153 - Operating System", aList));

            Matkul.setSelectedMatkul(Matkul.matkuls[0]);
        }
    }
}
