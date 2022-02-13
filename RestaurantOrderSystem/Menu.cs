using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu : Button
    {
        private const int SizeW = 197, SizeH = 147;
        public string Picture { get; set; }

        public Menu(string picture)
        {
            Picture = picture;
            Text = picture;
            Size = new Size(SizeW, SizeH);
        }

    }
}
