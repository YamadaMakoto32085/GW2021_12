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
        private const int plSizeW = 150, plSizeH = 140;
        private const int btSizeW = 150, btSizeH = 105;
        private const int tbSizeW = 150, tbSizeH = 19;
        private const int lbSizeH = 12;
        public string Picture { get; set; }
        public Color PanelColor { get; } = Color.PaleGreen;

        public Menu()
        {
            Size = new Size(plSizeW, plSizeH);
            BackColor = PanelColor;
        }

        public void Button1(string picture1)
        {
            Button bt1 = new Button();
            bt1.Location = new Point(0, 0);
            bt1.Text = picture1;
            bt1.Size = new Size(btSizeW, btSizeH);
            this.Controls.Add(bt1);
        }

        public void Button2(string picture2)
        {
            Button bt2 = new Button();
            bt2.Location = new Point(0, 0);
            bt2.Text = picture2;
            bt2.Size = new Size(btSizeW, btSizeH);
            this.Controls.Add(bt2);
        }

        public void Button3(string picture3)
        {
            Button bt3 = new Button();
            bt3.Location = new Point(0, 0);
            bt3.Text = picture3;
            bt3.Size = new Size(btSizeW, btSizeH);
            this.Controls.Add(bt3);
        }

        public void Button4(string picture4)
        {
            Button bt4 = new Button();
            bt4.Location = new Point(0, 0);
            bt4.Text = picture4;
            bt4.Size = new Size(btSizeW, btSizeH);
            this.Controls.Add(bt4);
        }

        public void TextBox1(string name1)
        {
            TextBox tb1 = new TextBox();
            tb1.Location = new Point(0, 102);
            tb1.Text = name1;
            tb1.Size = new Size(tbSizeW, tbSizeH);
            this.Controls.Add(tb1);
        }

        public void TextBox2(string name2)
        {
            TextBox tb2 = new TextBox();
            tb2.Location = new Point(0, 102);
            tb2.Text = name2;
            tb2.Size = new Size(tbSizeW, tbSizeH);
            this.Controls.Add(tb2);
        }

        public void TextBox3(string name3)
        {
            TextBox tb3 = new TextBox();
            tb3.Location = new Point(0, 102);
            tb3.Text = name3;
            tb3.Size = new Size(tbSizeW, tbSizeH);
            this.Controls.Add(tb3);
        }

        public void TextBox4(string name4)
        {
            TextBox tb4 = new TextBox();
            tb4.Location = new Point(0, 102);
            tb4.Text = name4;
            tb4.Size = new Size(tbSizeW, tbSizeH);
            this.Controls.Add(tb4);
        }

        public void Label1(string price1)
        {
            Label lb1 = new Label();
            lb1.Location = new Point(51, 123);
            lb1.Text = price1;
            lb1.Size = new Size(lb1.Text.Length, lbSizeH);
            this.Controls.Add(lb1);
        }

        public void Label2(string price2)
        {
            Label lb2 = new Label();
            lb2.Location = new Point(51, 123);
            lb2.Text = price2;
            lb2.Size = new Size(lb2.Text.Length, lbSizeH);
            this.Controls.Add(lb2);
        }

        public void Label3(string price3)
        {
            Label lb3 = new Label();
            lb3.Location = new Point(51, 123);
            lb3.Text = price3;
            lb3.Size = new Size(lb3.Text.Length, lbSizeH);
            this.Controls.Add(lb3);
        }

        public void Label4(string price4)
        {
            Label lb4 = new Label();
            lb4.Location = new Point(51, 123);
            lb4.Text = price4;
            lb4.Size = new Size(lb4.Text.Length, lbSizeH);
            this.Controls.Add(lb4);
        }

        public void NumericUpDown()
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Location = new Point(0, 121);
            nud.Maximum = 10;
            nud.Size = new Size(45, 19);
            nud.Enabled = false;
            this.Controls.Add(nud);
        }

    }
}
