using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.Style
{
    class MenuStripColor : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get
            {
                return Color.Red;
            }
        }
    }
}
