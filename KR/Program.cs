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
            String aName = "COMP6153 - Operating System";
            List<String> aCheckedList = new List<string>();
            List<String> aIgnoredList = new List<string>();
            List<String> aExtensions = new List<string>();
            aCheckedList.Add(@"\app\src\main");
            aIgnoredList.Add("AndroidManifest.xml");
            aExtensions.Add("java");
            aExtensions.Add("xml");
            Matkul.matkuls.Add(new Matkul(aName, aExtensions, aCheckedList, aIgnoredList));

            Matkul.setSelectedMatkul(Matkul.matkuls[0]);
        }
    }
}
