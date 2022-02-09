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
        private Menu3[] menuPrices;
        private Menu4 menuNud;
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
            CreatePrice1(ref menuPrices);
            menuNud = new Menu4();

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 158;
            const int proffX = 15, proffY = 177;
            //const int nudoffX = 168, nudoffY = 158;
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
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuPrices.Length; i++)
            {
                menuPrices[i].Name = "price" + i;
                int sizeW = menuPrices[i].Size.Width;
                int sizeH = menuPrices[i].Size.Height;
                menuPrices[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuPrices);
            plCmWindow.Controls.Add(menuNud);
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
            CreatePrices2(ref menuPrices);
            menuNud = new Menu4();

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 158;
            const int proffX = 15, proffY = 177;
            //const int nudoffX = 168, nudoffY = 158;
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
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuPrices.Length; i++)
            {
                menuPrices[i].Name = "price" + i;
                int sizeW = menuPrices[i].Size.Width;
                int sizeH = menuPrices[i].Size.Height;
                menuPrices[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuPrices);
            plCmWindow.Controls.Add(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void BtDessert_Click(object sender, EventArgs e)
        {
            CreateButton3(ref menuButtons);
            CreateText3(ref menuTexts);
            CreatePrices3(ref menuPrices);
            menuNud = new Menu4();

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 158;
            const int proffX = 15, proffY = 177;
            //const int nudoffX = 168, nudoffY = 158;
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
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuPrices.Length; i++)
            {
                menuPrices[i].Name = "name" + i;
                int sizeW = menuPrices[i].Size.Width;
                int sizeH = menuPrices[i].Size.Height;
                menuPrices[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuPrices);
            plCmWindow.Controls.Add(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        private void BtDrink_Click(object sender, EventArgs e)
        {
            CreateButton4(ref menuButtons);
            CreateText4(ref menuTexts);
            CreatePrice4(ref menuPrices);
            menuNud = new Menu4();

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 158;
            const int proffX = 15, proffY = 177;
            //const int nudoffX = 168, nudoffY = 158;
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
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuPrices.Length; i++)
            {
                menuPrices[i].Name = "price" + i;
                int sizeW = menuPrices[i].Size.Width;
                int sizeH = menuPrices[i].Size.Height;
                menuPrices[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuPrices);
            plCmWindow.Controls.Add(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
        }

        private void MenuButtons_Click(object sender, EventArgs e)
        {
            lbOrderList.SelectedItems.Add(menuTexts);
            lbOrderList.SelectedItems.Add(menuNud);
            lbOrderList.SelectedItems.Add(menuPrices);
        }

        private void CreateButton1(ref Menu[] menus)
        {
            string[] picture1 =
            {
                "◇","◆","□","■","☆",
            };

            menus = new Menu[picture1.Length];
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
                "◇","◆","□","■",
            };

            menus = new Menu[picture2.Length];
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
                "◇","◆","□","■",
            };

            menus = new Menu[picture3.Length];
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
                "◇","◆","□",
            };

            menus = new Menu[picture4.Length];
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

        private void CreatePrice1(ref Menu3[] prices)
        {
            int[] price1 =
            {
                439,396,388,412,367,
            };

            prices = new Menu3[price1.Length];
            for (int i = 0, j = 0; i < prices.Length; i += 2, j++)
            {
                prices[i] = new Menu3(price1[j]);
                prices[i + 1] = new Menu3(price1[j]);
            }
        }

        private void CreatePrices2(ref Menu3[] prices)
        {
            int[] price2 =
            {
                243,259,231,265,
            };

            prices = new Menu3[price2.Length];
            for (int i = 0, j = 0; i < prices.Length; i += 2, j++)
            {
                prices[i] = new Menu3(price2[j]);
                prices[i + 1] = new Menu3(price2[j]);
            }
        }

        private void CreatePrices3(ref Menu3[] prices)
        {
            int[] price3 =
            {
                213,208,210,198,
            };

            prices = new Menu3[price3.Length];
            for (int i = 0, j = 0; i < prices.Length; i += 2, j++)
            {
                prices[i] = new Menu3(price3[j]);
                prices[i + 1] = new Menu3(price3[j]);
            }
        }

        private void CreatePrice4(ref Menu3[] prices)
        {
            int[] price4 =
            {
                103,109,105,
            };

            prices = new Menu3[price4.Length];
            for (int i = 0, j = 0; i < prices.Length; i += 2, j++)
            {
                prices[i] = new Menu3(price4[j]);
                prices[i + 1] = new Menu3(price4[j]);
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
