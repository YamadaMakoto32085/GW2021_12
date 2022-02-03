using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu3 : NumericUpDown
    {
        private const int SizeW = 44, SizeH = 19;

        public Menu3()
        {
            Maximum = 10;
            Size = new Size(SizeW, SizeH);
            Enabled = false;
        }
    }
}
