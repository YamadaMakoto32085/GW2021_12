using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu4 : NumericUpDown
    {
        private const int SizeW = 39, SizeH = 19;

        public Menu4()
        {
            Maximum = 10;
            Size = new Size(SizeW, SizeH);
            Enabled = false;
        }
    }
}
