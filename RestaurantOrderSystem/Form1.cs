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

        private void plCmWindow_Layout(object sender, LayoutEventArgs e)
        {
            btMain.Click += BtMain_Click;
            btSub.Click += BtSub_Click;
            btDessert.Click += BtDessert_Click;
            btDrink.Click += BtDrink_Click;
        }

        private void BtMain_Click(object sender, EventArgs e)
        {
            CreateButton1(ref menuButtons);
            SuspendLayout();
            const int offsetX = 15, offsetY = 13;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i % 8 * sizeH);
            }



            btMain.Enabled = false;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void BtSub_Click(object sender, EventArgs e)
        {
            CreateButton2(ref menuButtons);
            SuspendLayout();
            const int offsetX = 15, offsetY = 13;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i % 8 * sizeH);
            }



            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void BtDessert_Click(object sender, EventArgs e)
        {
            CreateButton3(ref menuButtons);
            SuspendLayout();
            const int offsetX = 15, offsetY = 13;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i % 8 * sizeH);
            }



            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        private void BtDrink_Click(object sender, EventArgs e)
        {
            CreateButton4(ref menuButtons);
            SuspendLayout();
            const int offsetX = 15, offsetY = 13;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(offsetX + i % 8 * sizeW, offsetY + i % 8 * sizeH);
            }



            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
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
            string[] picture1 =
            {
                "ラーメン","焼きそば","牛丼","ハンバーグ","かつ丼定食",
            };

            string[] name1 =
            {
                "ラーメン","焼きそば","牛丼","ハンバーグ","かつ丼定食",
            };

            string[] price1 =
            {
               "347円","296円","273円","316円","322円"
            };

        }

        private void CreateButton2(ref Menu[] menus)
        {
            string[] picture2 =
            {
                "唐揚げ","フライドポテト","サラダ","コッペパン",
            };

            string[] name2 =
            {
                "唐揚げ","フライドポテト","サラダ","コッペパン",
            };

            string[] price2 =
            {
                "212円","197円","186円","121円"
            };

        }

        private void CreateButton3(ref Menu[] menus)
        {
            string[] picture3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ","モンブラン",
            };

            string[] name3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ","モンブラン",
            };

            string[] price3 =
            {
                "165円","149円","133円","154円"
            };
        }

        private void CreateButton4(ref Menu[] menus)
        {
            string[] picture4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };

            string[] name4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };

            string[] price4 =
            {
                "100円","100円","100円"
            };
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
