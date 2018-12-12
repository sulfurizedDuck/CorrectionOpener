using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FastColoredTextBoxNS;

namespace KR.Panels
{
    public partial class PanelFileTabs : UserControl
    {
        public PanelFileTabs()
        {
            InitializeComponent();
            tabFiles.TabPages.Clear();
        }

        public void readFiles(List<String> files)
        {
            tabFiles.TabPages.Clear();
            foreach (String file in files)
            {
                addTab(file);
            }

            if (tabFiles.TabPages.Count > 0)
            {
                Template parent = (Template)Parent.Parent.Parent;
                TabPage selectedTab = tabFiles.SelectedTab;
                parent.setCurrentPath(selectedTab.Name);
            }

        }

        public int addTab(String file)
        {
            int i = 0;
            foreach (TabPage tab in tabFiles.TabPages)
            {
                if (tab.Name.Equals(file))
                {
                    return i;
                }
                i++;
            }

            TabPage newTab = new TabPage(file.Substring(file.LastIndexOf('\\') + 1));
            newTab.Name = file;
            FastColoredTextBox fctb = createFCTB(File.ReadAllText(file), file.Substring(file.LastIndexOf('.') + 1));
            newTab.Controls.Add(fctb);

            tabFiles.TabPages.Add(newTab);
            return tabFiles.TabPages.Count - 1;
        }

        public void switchTab(int tabNumber)
        {
            tabFiles.SelectedTab = tabFiles.TabPages[tabNumber];
        }

        private FastColoredTextBox createFCTB(String text, String language)
        {
            FastColoredTextBox fctb = new FastColoredTextBox();
            fctb.Dock = DockStyle.Fill;
            fctb.Text = text;
            fctb.Font = new Font("Consolas", 14, FontStyle.Regular);
            fctb.WordWrap = true;

            switch(language.ToLower())
            {
                case "cs": fctb.Language = Language.CSharp; break;
                case "cpp": fctb.Language = Language.CSharp; break;
                case "c": fctb.Language = Language.CSharp; break;
                case "html": fctb.Language = Language.HTML; break;
                case "js": fctb.Language = Language.JS; break;
                case "jsx": fctb.Language = Language.JS; break;
                case "lua": fctb.Language = Language.Lua; break;
                case "php": fctb.Language = Language.PHP; break;
                case "sql": fctb.Language = Language.SQL; break;
                case "vb": fctb.Language = Language.VB; break;
                case "xml": fctb.Language = Language.XML; break;
                case "java": fctb.Language = Language.CSharp; break;
                default: fctb.Language = Language.Custom; break;
            }
            fctb.ClearStylesBuffer();
            fctb.Range.ClearStyle(StyleIndex.All);
            fctb.OnSyntaxHighlight(new TextChangedEventArgs(fctb.Range));

            return fctb;
        }

        private void PanelFileTabs_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        public void PanelFileTabs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                if (tabFiles.TabPages.Count != 0)
                {
                    tabFiles.TabPages.Remove(tabFiles.SelectedTab);
                }
            }
        }

        private void tabFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Template parent = (Template)Parent.Parent.Parent;
            TabPage selectedTab = ((TabControl)sender).SelectedTab;

            if (selectedTab != null)
            {
                parent.setCurrentPath(selectedTab.Name);
            }

        }
    }
}
