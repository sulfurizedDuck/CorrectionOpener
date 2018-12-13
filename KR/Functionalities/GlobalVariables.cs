using KR.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Functionalities
{
    class GlobalVariables
    {
        private static GlobalVariables instance = new GlobalVariables();
        public static GlobalVariables getInstance()
        {
            if (instance == null)
            {
                instance = new GlobalVariables();
            }
            return instance;
        }

        public static string rootDirectory;

        private static string _currProject;
        public static string currProject
        {
            get
            {
                return _currProject;
            }
            set
            {
                string path = rootDirectory + @"\" + value;
                _currProject = path;
            }
        }

        private static List<Matkul> _matkuls;
        public static List<Matkul> matkuls
        {
            get
            {
                if (_matkuls == null)
                {
                    _matkuls = new List<Matkul>();
                }
                return _matkuls;
            }
            set
            {
                _matkuls = value;
            }
        }

        public static Matkul selectedMatkul;

        #region Forms, Panels, UserControls
        private static Template _formMain;
        public static Template formMain
        {
            get
            {
                if (_formMain == null)
                {
                    _formMain = new Template();
                }
                return _formMain;
            }
            set
            {
                _formMain = value;
            }
        }

        private static PanelDirectory _panelDirectory;
        public static PanelDirectory panelDirectory
        {
            get
            {
                if (_panelDirectory == null)
                {
                    _panelDirectory = new PanelDirectory();
                }
                return _panelDirectory;
            }
            set
            {
                _panelDirectory = value;
            }
        }

        private static PanelFileTabs _panelMain;
        public static PanelFileTabs panelMain
        {
            get
            {
                if (_panelMain == null)
                {
                    _panelMain = new PanelFileTabs();
                }
                return _panelMain;
            }
            set
            {
                _panelMain = value;
            }
        }

        private static PanelProject _panelProject;
        public static PanelProject panelProject
        {
            get
            {
                if (_panelProject == null)
                {
                    _panelProject = new PanelProject();
                }
                return _panelProject;
            }
            set
            {
                _panelProject = value;
            }
        }

        private static PanelSelectedDirectories _panelSelectedDirectories;
        public static PanelSelectedDirectories panelSelectedDirectories
        {
            get
            {
                if (_panelSelectedDirectories == null)
                {
                    _panelSelectedDirectories = new PanelSelectedDirectories();
                }
                return _panelSelectedDirectories;
            }
            set
            {
                _panelSelectedDirectories = value;
            }
        }

        private static SearchFiles _panelSearchFiles;
        public static SearchFiles panelSearchFiles
        {
            get
            {
                if (_panelSearchFiles == null)
                {
                    _panelSearchFiles = new SearchFiles();
                }
                return _panelSearchFiles;
            }
            set
            {
                _panelSearchFiles = value;
            }
        }
        #endregion

    }
}
