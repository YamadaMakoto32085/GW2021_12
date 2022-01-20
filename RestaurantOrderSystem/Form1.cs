using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //画面一番上の時計のプログラム
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += delegate (object s, DoWorkEventArgs ev)
            {
                while (true)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        lbNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
                    });
                }
            };
            bw.RunWorkerAsync();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbOrdertList.Clear();
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            //CreateButton1();
            btMain.Enabled = false;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            //CreateButton2();
            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btDessert_Click(object sender, EventArgs e)
        {
            //CreateButton3();
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            //CreateButton4();
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
        }

        private void CreateButton1()
        {
            PictureBox pb1 = new PictureBox();
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();
            TextBox tb3 = new TextBox();
            Button bt1 = new Button();
            Button bt2 = new Button();
            CheckBox cb1 = new CheckBox();
            bt1.Text = "-";
            bt2.Text = "+";
            pb1.Left = 10;
            tb1.Left = 10;
            tb2.Left = 10;
            tb3.Left = 70;
            bt1.Left = 35;
            bt2.Left = 60;
            cb1.Left = 20;
            pb1.Top = 10;
            tb1.Top = 60;
            tb2.Top = 70;
            tb3.Top = 70;
            bt1.Top = 80;
            bt2.Top = 80;
            cb1.Top = 80;
            pb1.Width = 120;
            tb1.Width = 120;
            tb2.Width = 80;
            tb3.Width = 40;
            bt1.Width = 10;
            bt2.Width = 10;
            cb1.Width = 10;
            pb1.Height = 50;
            tb1.Height = 10;
            tb2.Height = 20;
            tb3.Height = 20;
            bt1.Height = 10;
            bt2.Height = 10;
            cb1.Height = 10;
            this.Controls.Add(pb1);
        }

        private void CreateButton2()
        {
            PictureBox pb2 = new PictureBox();
            TextBox tb4 = new TextBox();
            TextBox tb5 = new TextBox();
            TextBox tb6 = new TextBox();
            Button bt3 = new Button();
            Button bt4 = new Button();
            CheckBox cb2 = new CheckBox();
            bt3.Text = "-";
            bt4.Text = "+";
            pb2.Left = 10;
            tb4.Left = 10;
            tb5.Left = 10;
            tb6.Left = 70;
            bt3.Left = 35;
            bt4.Left = 60;
            cb2.Left = 20;
            pb2.Top = 10;
            tb4.Top = 60;
            tb5.Top = 70;
            tb6.Top = 70;
            bt3.Top = 80;
            bt4.Top = 80;
            cb2.Top = 80;
            pb2.Width = 120;
            tb4.Width = 120;
            tb5.Width = 80;
            tb6.Width = 40;
            bt3.Width = 10;
            bt4.Width = 10;
            cb2.Width = 10;
            pb2.Height = 50;
            tb4.Height = 10;
            tb5.Height = 20;
            tb6.Height = 20;
            bt3.Height = 10;
            bt4.Height = 10;
            cb2.Height = 10;
            this.Controls.Add(pb2);
        }

        private void CreateButton3()
        {
            PictureBox pb3 = new PictureBox();
            TextBox tb7 = new TextBox();
            TextBox tb8 = new TextBox();
            TextBox tb9 = new TextBox();
            Button bt5 = new Button();
            Button bt6 = new Button();
            CheckBox cb3 = new CheckBox();
            bt5.Text = "-";
            bt6.Text = "+";
            pb3.Left = 10;
            tb7.Left = 10;
            tb8.Left = 10;
            tb9.Left = 70;
            bt5.Left = 35;
            bt6.Left = 60;
            cb3.Left = 20;
            pb3.Top = 10;
            tb7.Top = 60;
            tb8.Top = 70;
            tb9.Top = 70;
            bt5.Top = 80;
            bt6.Top = 80;
            cb3.Top = 80;
            pb3.Width = 120;
            tb7.Width = 120;
            tb8.Width = 80;
            tb9.Width = 40;
            bt5.Width = 10;
            bt6.Width = 10;
            cb3.Width = 10;
            pb3.Height = 50;
            tb7.Height = 10;
            tb8.Height = 20;
            tb9.Height = 20;
            bt5.Height = 10;
            bt6.Height = 10;
            cb3.Height = 10;
            this.Controls.Add(pb3);
        }

        private void CreateButton4()
        {
            PictureBox pb4 = new PictureBox();
            TextBox tb10 = new TextBox();
            TextBox tb11 = new TextBox();
            TextBox tb12 = new TextBox();
            Button bt7 = new Button();
            Button bt8 = new Button();
            CheckBox cb4 = new CheckBox();
            bt7.Text = "-";
            bt8.Text = "+";
            pb4.Left = 10;
            tb10.Left = 10;
            tb11.Left = 10;
            tb12.Left = 70;
            bt7.Left = 35;
            bt8.Left = 60;
            pb4.Top = 10;
            tb10.Top = 60;
            tb11.Top = 70;
            tb12.Top = 70;
            pb4.Width = 120;
            tb10.Width = 120;
            tb11.Width = 80;
            tb12.Width = 40;
            pb4.Height = 50;
            tb10.Height = 10;
            tb11.Height = 20;
            tb12.Height = 20;
            this.Controls.Add(pb4);
        }
    }
}
