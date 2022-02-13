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
        private const int SizeW = 197, SizeH = 19;

        public Menu4(int nud)
        {
            Value = nud;
            Maximum = 10;
            Size = new Size(SizeW, SizeH);
            TextAlign = HorizontalAlignment.Right;
        }
    }
}
