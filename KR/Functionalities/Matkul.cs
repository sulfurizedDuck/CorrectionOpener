using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Functionalities
{
    class Matkul
    {
        #region Static Variables
        public static List<Matkul> matkuls =  new List<Matkul>();
        private static Matkul SelectedMatkul;

        public static Matkul getSelectedMatkul()
        {
            return SelectedMatkul;
        }
        public static void setSelectedMatkul(Matkul matkul)
        {
            SelectedMatkul = matkul;
            #region Set The Got Directories
            
            #endregion
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
    }
}
