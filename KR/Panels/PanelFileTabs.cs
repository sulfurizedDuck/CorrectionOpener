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
                FastColoredTextBox fctb = createFCTB(File.ReadAllText(file), file.Substring(file.LastIndexOf('.')+1));
                tabFiles.TabPages.Add(file.Substring(file.LastIndexOf('\\')+1));
                tabFiles.TabPages[tabFiles.TabPages.Count - 1].Controls.Add(fctb);
            }
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
                case "html": fctb.Language = Language.HTML; break;
                case "js": fctb.Language = Language.JS; break;
                case "jsx": fctb.Language = Language.JS; break;
                case "lua": fctb.Language = Language.Lua; break;
                case "php": fctb.Language = Language.PHP; break;
                case "sql": fctb.Language = Language.SQL; break;
                case "vb": fctb.Language = Language.VB; break;
                case "xml": fctb.Language = Language.XML; break;
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
    }
}
