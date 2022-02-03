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
        private Menu2[] menuTexts;
        private Menu3 menuNud;
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
            CreateText1(ref menuTexts);
            CreateNud(ref menuNud);

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 144;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(btoffX + i % 8 * sizeW, btoffY + i / 8 * sizeH);
                menuButtons[i].Click += MenuButtons_Click;
            }

            for (int i = 0; i < menuTexts.Length; i++)
            {
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            Controls.AddRange(menuButtons);
            Controls.AddRange(menuTexts);
            Controls.Add(menuNud);
            ResumeLayout(false);

            btMain.Enabled = false;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void BtSub_Click(object sender, EventArgs e)
        {
            CreateButton2(ref menuButtons);
            CreateText2(ref menuTexts);
            CreateNud(ref menuNud);

            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        
        private void BtDessert_Click(object sender, EventArgs e)
        {
            CreateButton3(ref menuButtons);
            CreateText3(ref menuTexts);
            CreateNud(ref menuNud);

            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        
        private void BtDrink_Click(object sender, EventArgs e)
        {
            CreateButton4(ref menuButtons);
            CreateText4(ref menuTexts);
            CreateNud(ref menuNud);

            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
        }

        private void MenuButtons_Click(object sender, EventArgs e)
        {

        }


        private void ChangePanels1()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 232;
            btCom1.Enabled = true;
            btCom1.Text = "マグロ";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangePanels2()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 120;
            btCom1.Enabled = true;
            btCom1.Text = "唐揚げ";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangePanels3()
        {
            nud1.Value = 0;
            nud1.Enabled = false;
            int price1 = 132;
            btCom1.Enabled = true;
            btCom1.Text = "饅頭";
            lbPrice1.Text = price1 + "円";
        }

        private void ChangePanels4()
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

            menus = new Menu[picture1.Length * 4];
            for (int i = 0, j = 0; i < menus.Length; i += 2, j++)
            {
                menus[i] = new Menu(picture1[j]);
                menus[i + 1] = new Menu(picture1[j]);
            }
        }

        private void CreateButton2(ref Menu[] menus)
        {
            string[] picture2 =
            {
                "唐揚げ","フライドポテト","サラダ","コッペパン",
            };

            menus = new Menu[picture2.Length * 4];
            for (int i = 0, j = 0; i < menus.Length; i += 2, j++)
            {
                menus[i] = new Menu(picture2[j]);
                menus[i + 1] = new Menu(picture2[j]);
            }
        }

        private void CreateButton3(ref Menu[] menus)
        {
            string[] picture3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ","モンブラン",
            };

            menus = new Menu[picture3.Length * 4];
            for (int i = 0, j = 0; i < menus.Length; i += 2, j++)
            {
                menus[i] = new Menu(picture3[j]);
                menus[i + 1] = new Menu(picture3[j]);
            }
        }

        private void CreateButton4(ref Menu[] menus)
        {
            string[] picture4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };

            menus = new Menu[picture4.Length * 4];
            for (int i = 0, j = 0; i < menus.Length; i += 2, j++)
            {
                menus[i] = new Menu(picture4[j]);
                menus[i + 1] = new Menu(picture4[j]);
            }
        }

        private void CreateText1(ref Menu2[] texts)
        {
            string[] name1 =
            {
                "ラーメン","焼きそば","牛丼","ハンバーグ","かつ丼定食",
            };

            texts = new Menu2[name1.Length];
            for (int i = 0, j = 0; i < texts.Length; i += 2, j++)
            {
                texts[i] = new Menu2(name1[j]);
                texts[i + 1] = new Menu2(name1[j]);
            }
        }

        private void CreateText2(ref Menu2[] texts)
        {
            string[] name2 =
            {
                "唐揚げ","フライドポテト","サラダ","コッペパン",
            };

            texts = new Menu2[name2.Length];
            for (int i = 0, j = 0; i < texts.Length; i += 2, j++)
            {
                texts[i] = new Menu2(name2[j]);
                texts[i + 1] = new Menu2(name2[j]);
            }
        }

        private void CreateText3(ref Menu2[] texts)
        {
            string[] name3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ","モンブラン",
            };

            texts = new Menu2[name3.Length];
            for (int i = 0, j = 0; i < texts.Length; i += 2, j++)
            {
                texts[i] = new Menu2(name3[j]);
                texts[i + 1] = new Menu2(name3[j]);
            }
        }

        private void CreateText4(ref Menu2[] texts)
        {
            string[] name4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };

            texts = new Menu2[name4.Length];
            for (int i = 0, j = 0; i < texts.Length; i += 2, j++)
            {
                texts[i] = new Menu2(name4[j]);
                texts[i + 1] = new Menu2(name4[j]);
            }
        }

        private void CreateNud(ref Menu3 menus)
        {
            
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.Clear();
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
