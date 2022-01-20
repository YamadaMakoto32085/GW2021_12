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
            lbOrderList.Items.Clear();
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            ChangeButton1();
            btMain.Enabled = false;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            ChangeButton2();
            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btDessert_Click(object sender, EventArgs e)
        {
            ChangeButton3();
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            ChangeButton4();
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
        }

        private void ChangeButton1()
        {
            nud1.Enabled = false;
            nud2.Enabled = false;
            nud3.Enabled = false;
            nud4.Enabled = false;
            int price1 = 232;
            int price2 = 143;
            int price3 = 210;
            int price4 = 173;
            btCom1.Enabled = true;
            btCom2.Enabled = true;
            btCom3.Enabled = true;
            btCom4.Enabled = true;
            btCom1.Text = "マグロ";
            btCom2.Text = "イカ";
            btCom3.Text = "エビ";
            btCom4.Text = "イクラ";
            lbPrice1.Text = price1 + "円";
            lbPrice2.Text = price2 + "円";
            lbPrice3.Text = price3 + "円";
            lbPrice4.Text = price4 + "円";
        }

        private void ChangeButton2()
        {
            nud1.Enabled = false;
            nud2.Enabled = false;
            nud3.Enabled = false;
            nud4.Enabled = false;
            int price1 = 120;
            int price2 = 103;
            int price3 = 112;
            int price4 = 139;
            btCom1.Enabled = true;
            btCom2.Enabled = true;
            btCom3.Enabled = true;
            btCom4.Enabled = true;
            btCom1.Text = "唐揚げ";
            btCom2.Text = "天ぷら";
            btCom3.Text = "塩むすび";
            btCom4.Text = "かき揚げ";
            lbPrice1.Text = price1 + "円";
            lbPrice2.Text = price2 + "円";
            lbPrice3.Text = price3 + "円";
            lbPrice4.Text = price4 + "円";
        }

        private void ChangeButton3()
        {
            nud1.Enabled = false;
            nud2.Enabled = false;
            nud3.Enabled = false;
            nud4.Enabled = false;
            int price1 = 132;
            int price2 = 122;
            int price3 = 146;
            int price4 = 137;
            btCom1.Enabled = true;
            btCom2.Enabled = true;
            btCom3.Enabled = true;
            btCom4.Enabled = true;
            btCom1.Text = "饅頭";
            btCom2.Text = "羊羹";
            btCom3.Text = "桜餅";
            btCom4.Text = "草餅";
            lbPrice1.Text = price1 + "円";
            lbPrice2.Text = price2 + "円";
            lbPrice3.Text = price3 + "円";
            lbPrice4.Text = price4 + "円";
        }

        private void ChangeButton4()
        {
            nud1.Enabled = false;
            nud2.Enabled = false;
            nud3.Enabled = false;
            nud4.Enabled = false;
            int price1 = 100;
            int price2 = 100;
            int price3 = 100;
            int price4 = 100;
            btCom1.Enabled = true;
            btCom2.Enabled = true;
            btCom3.Enabled = true;
            btCom4.Enabled = true;
            btCom1.Text = "麦茶";
            btCom2.Text = "ほうじ茶";
            btCom3.Text = "甘酒";
            btCom4.Text = "ビール";
            lbPrice1.Text = price1 + "円";
            lbPrice2.Text = price2 + "円";
            lbPrice3.Text = price3 + "円";
            lbPrice4.Text = price4 + "円";
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

        private void btCom1_Click(object sender, EventArgs e)
        {
            int price1 = 232;
            int price2 = 120;
            int price3 = 132;
            int price4 = 100;
            nud1.Enabled = true;
            nud1.Minimum = 1;
            lbOrderList.Items.Add(btCom1.Text);
            lbOrderList.Items.Add(nud1.Value);
            if (lbPrice1.Text == "232円")
            {
                lbOrderList.Items.Add(price1 * nud1.Value);
            }
            else if (lbPrice1.Text == "120円")
            {
                lbOrderList.Items.Add(price2 * nud1.Value);
            }
            else if(lbPrice1.Text == "132円")
            {
                lbOrderList.Items.Add(price3 * nud1.Value);
            }
            else if(lbPrice1.Text == "100円")
            {
                lbOrderList.Items.Add(price4 * nud1.Value);
            }
        }

        private void btCom2_Click(object sender, EventArgs e)
        {
            int price1 = 143;
            int price2 = 103;
            int price3 = 122;
            int price4 = 100;
            nud2.Enabled = true;
            nud2.Minimum = 1;
            lbOrderList.Items.Add(btCom2.Text);
            lbOrderList.Items.Add(nud2.Value);
            if (lbPrice2.Text == "143円")
            {
                lbOrderList.Items.Add(price1 * nud2.Value);
            }
            else if (lbPrice2.Text == "103円")
            {
                lbOrderList.Items.Add(price2 * nud2.Value);
            }
            else if (lbPrice2.Text == "122円")
            {
                lbOrderList.Items.Add(price3 * nud2.Value);
            }
            else if (lbPrice2.Text == "100円")
            {
                lbOrderList.Items.Add(price4 * nud2.Value);
            }
        }

        private void btCom3_Click(object sender, EventArgs e)
        {
            int price1 = 210;
            int price2 = 112;
            int price3 = 146;
            int price4 = 100;
            nud3.Enabled = true;
            nud3.Minimum = 1;
            lbOrderList.Items.Add(btCom3.Text);
            lbOrderList.Items.Add(nud3.Value);
            if (lbPrice3.Text == "210円")
            {
                lbOrderList.Items.Add(price1 * nud3.Value);
            }
            else if (lbPrice3.Text == "112円")
            {
                lbOrderList.Items.Add(price2 * nud3.Value);
            }
            else if (lbPrice3.Text == "146円")
            {
                lbOrderList.Items.Add(price3 * nud3.Value);
            }
            else if (lbPrice3.Text == "100円")
            {
                lbOrderList.Items.Add(price4 * nud3.Value);
            }
        }

        private void btCom4_Click(object sender, EventArgs e)
        {
            int price1 = 173;
            int price2 = 139;
            int price3 = 137;
            int price4 = 100;
            nud4.Enabled = true;
            nud4.Minimum = 1;
            lbOrderList.Items.Add(btCom4.Text);
            lbOrderList.Items.Add(nud4.Value);
            if (lbPrice4.Text == "173円")
            {
                lbOrderList.Items.Add(price1 * nud4.Value);
            }
            else if (lbPrice4.Text == "139円")
            {
                lbOrderList.Items.Add(price2 * nud4.Value);
            }
            else if (lbPrice4.Text == "137円")
            {
                lbOrderList.Items.Add(price3 * nud4.Value);
            }
            else if (lbPrice4.Text == "100円")
            {
                lbOrderList.Items.Add(price4 * nud4.Value);
            }
        }
    }
}
