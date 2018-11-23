using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Functionalities
{
    class Matkul
    {
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
        private String matkulName;
        private List<String> checkedDirectories;
        public Matkul(String matkulName, List<String> checkedDirectories=null)
        {
            this.matkulName = matkulName;
            if (checkedDirectories == null)
            {
                this.checkedDirectories = new List<string>();
            }
            else
            {
                this.checkedDirectories = checkedDirectories;
            }
        }

        public String getMatkulName()
        {
            return this.matkulName;
        }

        public List<String> getCheckedDirectories()
        {
            return this.checkedDirectories;
        }
    }
}
