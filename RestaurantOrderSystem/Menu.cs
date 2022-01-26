using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    class Menu : Panel
    {
        private const int SizeW = 150, SizeH = 140;
        public string Picture { get; set; }

        public Menu(string picture)
        {
            Picture = picture;
            Size = new Size(SizeW, SizeH);
        }
    }
}
