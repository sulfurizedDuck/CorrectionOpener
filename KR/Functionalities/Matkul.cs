using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.Functionalities
{
    class Matkul
    {
        #region Static Variables
        public static List<Matkul> matkuls =  new List<Matkul>();

        private static Matkul _selectedMatkul;
        public static Matkul selectedMatkul {
            get
            {
                return _selectedMatkul;
            }
            set
            {
                if (value == null)
                {
                    value = new Matkul("", null, null);
                }
                _selectedMatkul = value;
            }
        }
        #endregion

        #region Attributes
        private String _matkulName;
        private List<String> _extensions;
        private List<String> _checkedDirectories;
        private List<String> _ignoredDirectories;
        public String matkulName
        {
            get
            {
                return _matkulName;
            }
            set
            {
                _matkulName = value;
            }
        }
        public List<String> extensions
        {
            get
            {
                return _extensions;
            }
            set
            {
                if (value == null)
                {
                    value = new List<string>();
                }
                _extensions = value;
            }
        }
        public List<String> checkedDirectories
        {
            get
            {
                return _checkedDirectories;
            } 
            set
            {
                if (value == null)
                {
                    value = new List<string>();
                }
                _checkedDirectories = value;
            }
        }
        public List<String> ignoredDirectories
        {
            get
            {
                return _ignoredDirectories;
            } 
            set
            {
                if (value == null)
                {
                    value = new List<string>();
                }
                _ignoredDirectories = value;
            }
        }
        #endregion

        public Matkul(String matkulName, List<String> extensions, List<String> checkedDirectories=null, List<String> ignoredDirectories=null)
        {
            this.matkulName = matkulName;
            this.extensions = extensions;
            this.checkedDirectories = checkedDirectories;
            this.ignoredDirectories = ignoredDirectories;
        }

        public static void initMatkuls()
        {
            #region Get All The Matkul Files
            List<String> files = Directory.GetFiles(@"Matkul", "*.txt").ToList();
            #endregion

            #region Read The File Content and Bla2x
            foreach (String file in files)
            {
                String[] fileContent = File.ReadAllLines(file);
                String matkulName = file.Substring
                    (
                        file.LastIndexOf(@"\") + 1,
                        file.LastIndexOf(@".") - file.LastIndexOf(@"\") - 1
                    );

                List<String> checkedDirectories = new List<string>();
                List<String> ignoredDirectories = new List<string>();

                checkedDirectories = fileContent[0].Split('#').ToList();
                ignoredDirectories = fileContent[1].Split('#').ToList();

                if (checkedDirectories.Count == 1 && checkedDirectories[0] == "")
                {
                    checkedDirectories.Clear();
                }
                if (ignoredDirectories.Count == 1 && ignoredDirectories[0] == "")
                {
                    ignoredDirectories.Clear();
                }
                MessageBox.Show(checkedDirectories.Count.ToString());
                MessageBox.Show(ignoredDirectories.Count.ToString());

                Matkul newMatkul = new Matkul(matkulName, checkedDirectories, ignoredDirectories);
                matkuls.Add(newMatkul);
            }
            #endregion

            matkuls.Clear();
            if (matkuls.Count == 0)
            {
                initMatkulDummy();
            }

            selectedMatkul = matkuls.FirstOrDefault();
        }

        public static void initMatkulDummy()
        {
            String aName = "MOBI6006 - Mobile Community Solution";
            List<String> aCheckedList = new List<string>();
            List<String> aIgnoredList = new List<string>();
            List<String> aExtensions = new List<string>();
            aCheckedList.Add(@"\app\src\main");
            aIgnoredList.Add("AndroidManifest.xml");
            aExtensions.Add("java");
            aExtensions.Add("xml");
            Matkul.matkuls.Add(new Matkul(aName, aExtensions, aCheckedList, aIgnoredList));
            
        }
    }
}
