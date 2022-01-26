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
        private Menu[] menuButtons;
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
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 232;
            btCom1.Enabled = true;
            btCom1.Text = "マグロ";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangeButton2()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 120;
            btCom1.Enabled = true;
            btCom1.Text = "唐揚げ";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangeButton3()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 132;
            btCom1.Enabled = true;
            btCom1.Text = "饅頭";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangeButton4()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 100;
            btCom1.Enabled = true;
            btCom1.Text = "麦茶";
            lbPrice1.Text = price1 + "円";
        }

        private void CreateButton1(ref Menu[] menus)
        {
            Button bt1 = new Button();
            TextBox tb1 = new TextBox();
            NumericUpDown nud1 = new NumericUpDown();
            string[] picture1 =
            {
                "ラーメン","焼きそば","牛丼","ハンバーグ","かつ丼定食",
            };
            
            nud1.Maximum = 10;

        }

        private void CreateButton2(ref Menu[] menus)
        {
            Panel pl2 = new Panel();
            TextBox tb2 = new TextBox();
            NumericUpDown nud2 = new NumericUpDown();
            string[] picture2 =
            {
                "唐揚げ","フライドポテト","サラダ","コッペパン",
            };
            pl2.Top = 15;
            pl2.Left = 13;
            pl2.Width = 150;
            pl2.Height = 140;
            nud2.Maximum = 10;
            
        }

        private void CreateButton3(ref Menu[] menus)
        {
            Panel pl3 = new Panel();
            TextBox tb3 = new TextBox();
            NumericUpDown nud3 = new NumericUpDown();
            string[] picture3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ","モンブラン",
            };
            pl3.Top = 15;
            pl3.Left = 13;
            pl3.Width = 150;
            pl3.Height = 140;
            nud3.Maximum = 10;
        }

        private void CreateButton4(ref Menu[] menus)
        {
            Panel pl4 = new Panel();
            TextBox tb4 = new TextBox();
            NumericUpDown nud4 = new NumericUpDown();
            string[] picture4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };
            pl4.Top = 15;
            pl4.Left = 13;
            pl4.Width = 150;
            pl4.Height = 140;
            nud4.Maximum = 10;
        }

        private void btCom1_Click(object sender, EventArgs e)
        {
            int price1 = 232;
            int price2 = 120;
            int price3 = 132;
            int price4 = 100;
            nud1.Enabled = true;
            if (nud1.Value == 0)
            {
                nud1.Value += 1;
            }
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
    }
}
