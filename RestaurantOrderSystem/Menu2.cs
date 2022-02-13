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
        public int Price { get; set; }
        public Color TbColor { get; } = Color.PaleGreen;

        public Menu2(string text, int price)
        {
            Price = price;
            Text = text + "   " + price.ToString() + "円";
            Size = new Size(SizeW, SizeH);
            BackColor = TbColor;
            Font = new Font("MS UI Gothic", 9, FontStyle.Bold);
            ReadOnly = true;
        }
    }
}
