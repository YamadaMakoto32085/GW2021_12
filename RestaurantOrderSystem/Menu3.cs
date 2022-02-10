using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu3 : TextBox
    {
        private const int SizeW = 197, SizeH = 19;
        public Color TbColor { get; } = Color.SkyBlue;

        public Menu3(string tips)
        {
            Text = tips;
            Size = new Size(SizeW, SizeH);
            BackColor = TbColor;
            Font = new Font("MS UI Gothic", 9, FontStyle.Bold);
            ReadOnly = true;
        }
    }
}
