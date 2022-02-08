using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu2 : TextBox
    {
        private const int SizeW = 197, SizeH = 19;
        public Color TbColor { get; } = Color.PaleGreen;

        public Menu2(string text)
        {
            Text = text;
            Size = new Size(SizeW, SizeH);
            BackColor = TbColor;
        }
    }
}
