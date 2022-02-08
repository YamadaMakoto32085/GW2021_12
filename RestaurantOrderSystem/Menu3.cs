﻿using System;
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
        private const int SizeW = 79, SizeH = 19;
        public Color TbColor { get; } = Color.PaleGreen;

        public Menu3(string price)
        {
            Text = price;
            Size = new Size(SizeW, SizeH);
            BackColor = TbColor;
        }
    }
}
