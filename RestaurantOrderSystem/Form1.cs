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
        private Menu3[] menuTips;
        private Menu4[] menuNud;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton1(ref Menu[] menus)
        {
            string[] picture1 =
            {
                "\\th1.jpg","\\th2.jpg","\\th3.jpg",
            };

            menus = new Menu[picture1.Length];
            for (int i = 0, j = 0; i < menus.Length; i += 1, j++)
            {
                menus[i] = new Menu(picture1[j]);
            }
        }

        private void CreateButton2(ref Menu[] menus)
        {
            string[] picture2 =
            {
                "◇","◆","□",
            };

            menus = new Menu[picture2.Length];
            for (int i = 0, j = 0; i < menus.Length; i += 1, j++)
            {
                menus[i] = new Menu(picture2[j]);
            }
        }

        private void CreateButton3(ref Menu[] menus)
        {
            string[] picture3 =
            {
                "◇","◆","□",
            };

            menus = new Menu[picture3.Length];
            for (int i = 0, j = 0; i < menus.Length; i += 1, j++)
            {
                menus[i] = new Menu(picture3[j]);
            }
        }

        private void CreateButton4(ref Menu[] menus)
        {
            string[] picture4 =
            {
                "◇","◆","□",
            };

            menus = new Menu[picture4.Length];
            for (int i = 0, j = 0; i < menus.Length; i += 1, j++)
            {
                menus[i] = new Menu(picture4[j]);
            }
        }

        private void CreateText1(ref Menu2[] names)
        {
            string[] text1 =
            {
                "ラーメン","焼きそば","牛丼",
            };

            int[] price1 =
            {
                439,396,388,
            };

            names = new Menu2[text1.Length];
            for (int i = 0, j = 0; i < names.Length; i += 1, j++)
            {
                names[i] = new Menu2(text1[j],price1[j]);
            }
        }

        private void CreateText2(ref Menu2[] names)
        {
            string[] text2 =
            {
                "唐揚げ","フライドポテト","サラダ",
            };

            int[] price2 =
            {
                243,259,231,
            };

            names = new Menu2[text2.Length];
            for (int i = 0, j = 0; i < names.Length; i += 1, j++)
            {
                names[i] = new Menu2(text2[j],price2[j]);
            }
        }

        private void CreateText3(ref Menu2[] names)
        {
            string[] text3 =
            {
                "イチゴパフェ","ショートケーキ","ホットケーキ",
            };

            int[] price3 =
            {
                213,208,210,
            };

            names = new Menu2[text3.Length];
            for (int i = 0, j = 0; i < names.Length; i += 1, j++)
            {
                names[i] = new Menu2(text3[j],price3[j]);
            }
        }

        private void CreateText4(ref Menu2[] names)
        {
            string[] text4 =
            {
                "コーラ","メロンソーダ","コーヒー",
            };

            int[] price4 =
            {
                103,109,105,
            };

            names = new Menu2[text4.Length];
            for (int i = 0, j = 0; i < names.Length; i += 1, j++)
            {
                names[i] = new Menu2(text4[j],price4[j]);
            }
        }

        private void CreatePrices1(ref Menu3[] tips)
        {
            string[] text1 =
            {
                "今週のオススメ！","定番と言ったらコレ！","今日のイチオシ！"
            };

            tips = new Menu3[text1.Length];
            for (int i = 0, j = 0; i < tips.Length; i += 1, j++)
            {
                tips[i] = new Menu3(text1[j]);
            }
        }

        private void CreatePrices2(ref Menu3[] tips)
        {

            string[] text2 =
            {
                "今週のオススメ！","定番と言ったらコレ！","今日のイチオシ！"
            };

            tips = new Menu3[text2.Length];
            for (int i = 0, j = 0; i < tips.Length; i += 1, j++)
            {
                tips[i] = new Menu3(text2[j]);
            }
        }

        private void CreatePrices3(ref Menu3[] tips)
        {

            string[] text3 =
            {
                "今週のオススメ！","定番と言ったらコレ！","今日のイチオシ！"
            };

            tips = new Menu3[text3.Length];
            for (int i = 0, j = 0; i < tips.Length; i += 1, j++)
            {
                tips[i] = new Menu3(text3[j]);
            }
        }

        private void CreatePrices4(ref Menu3[] tips)
        {

            string[] text4 =
            {
                "今週のオススメ！","定番と言ったらコレ！","今日のイチオシ！"
            };

            tips = new Menu3[text4.Length];
            for (int i = 0, j = 0; i < tips.Length; i += 1, j++)
            {
                tips[i] = new Menu3(text4[j]);
            }
        }

        private void CreateNud1(ref Menu4[] nuds)
        {
            int[] nud1 =
            {
                0,0,0,
            };

            nuds = new Menu4[nud1.Length];
            for (int i = 0, j = 0; i < nuds.Length; i += 1, j++)
            {
                nuds[i] = new Menu4(nud1[j]);
            }
        }

        private void CreateNud2(ref Menu4[] nuds)
        {
            int[] nud2 =
            {
                0,0,0,
            };

            nuds = new Menu4[nud2.Length];
            for (int i = 0, j = 0; i < nuds.Length; i += 1, j++)
            {
                nuds[i] = new Menu4(nud2[j]);
            }
        }

        private void CreateNud3(ref Menu4[] nuds)
        {
            int[] nud3 =
            {
                0,0,0,
            };

            nuds = new Menu4[nud3.Length];
            for (int i = 0, j = 0; i < nuds.Length; i += 1, j++)
            {
                nuds[i] = new Menu4(nud3[j]);
            }
        }

        private void CreateNud4(ref Menu4[] nuds)
        {
            int[] nud4 =
            {
                0,0,0,
            };

            nuds = new Menu4[nud4.Length];
            for (int i = 0, j = 0; i < nuds.Length; i += 1, j++)
            {
                nuds[i] = new Menu4(nud4[j]);
            }
        }

        private void DeleteMenu()
        {
            plCmWindow.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btMain_Click(object sender, EventArgs e)
        {
            DeleteMenu();
            CreateButton1(ref menuButtons);
            CreateText1(ref menuTexts);
            CreatePrices1(ref menuTips);
            CreateNud1(ref menuNud);
            
            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 159;
            const int proffX = 15, proffY = 175;
            const int nudoffX = 15, nudoffY = 194;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(btoffX + i % 8 * sizeW, btoffY + i / 8 * sizeH);
                menuButtons[i].Click += menuButton1_Click;
            }

            for (int i = 0; i < menuTexts.Length; i++)
            {
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuTips.Length; i++)
            {
                menuTips[i].Name = "price" + i;
                int sizeW = menuTips[i].Size.Width;
                int sizeH = menuTips[i].Size.Height;
                menuTips[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuNud.Length; i++)
            {
                menuNud[i].Name = "nud" + i;
                int sizeW = menuNud[i].Size.Width;
                int sizeH = menuNud[i].Size.Height;
                menuNud[i].Location = new Point(nudoffX + i % 8 * sizeW, nudoffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuTips);
            plCmWindow.Controls.AddRange(menuNud);
            ResumeLayout(false);
            btMain.Enabled = false;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            DeleteMenu();
            CreateButton2(ref menuButtons);
            CreateText2(ref menuTexts);
            CreatePrices2(ref menuTips);
            CreateNud2(ref menuNud);
            
            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 159;
            const int proffX = 15, proffY = 175;
            const int nudoffX = 15, nudoffY = 194;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(btoffX + i % 8 * sizeW, btoffY + i / 8 * sizeH);
                menuButtons[i].Click += menuButton2_Click;
            }

            for (int i = 0; i < menuTexts.Length; i++)
            {
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuTips.Length; i++)
            {
                menuTips[i].Name = "price" + i;
                int sizeW = menuTips[i].Size.Width;
                int sizeH = menuTips[i].Size.Height;
                menuTips[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuNud.Length; i++)
            {
                menuNud[i].Name = "nud" + i;
                int sizeW = menuNud[i].Size.Width;
                int sizeH = menuNud[i].Size.Height;
                menuNud[i].Location = new Point(nudoffX + i % 8 * sizeW, nudoffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuTips);
            plCmWindow.Controls.AddRange(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = false;
            btDessert.Enabled = true;
            btDrink.Enabled = true;
        }

        private void btDessert_Click(object sender, EventArgs e)
        {
            DeleteMenu();
            CreateButton3(ref menuButtons);
            CreateText3(ref menuTexts);
            CreatePrices3(ref menuTips);
            CreateNud3(ref menuNud);

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 159;
            const int proffX = 15, proffY = 175;
            const int nudoffX = 15, nudoffY = 194;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(btoffX + i % 8 * sizeW, btoffY + i / 8 * sizeH);
                menuButtons[i].Click += menuButton3_Click;
            }

            for (int i = 0; i < menuTexts.Length; i++)
            {
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuTips.Length; i++)
            {
                menuTips[i].Name = "price" + i;
                int sizeW = menuTips[i].Size.Width;
                int sizeH = menuTips[i].Size.Height;
                menuTips[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuNud.Length; i++)
            {
                menuNud[i].Name = "nud" + i;
                int sizeW = menuNud[i].Size.Width;
                int sizeH = menuNud[i].Size.Height;
                menuNud[i].Location = new Point(nudoffX + i % 8 * sizeW, nudoffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuTips);
            plCmWindow.Controls.AddRange(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = false;
            btDrink.Enabled = true;
        }

        private void btDrink_Click(object sender, EventArgs e)
        {
            DeleteMenu();
            CreateButton4(ref menuButtons);
            CreateText4(ref menuTexts);
            CreatePrices4(ref menuTips);
            CreateNud4(ref menuNud);

            SuspendLayout();
            const int btoffX = 15, btoffY = 13;
            const int tboffX = 15, tboffY = 159;
            const int proffX = 15, proffY = 175;
            const int nudoffX = 15, nudoffY = 194;
            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].Name = "menu" + i;
                int sizeW = menuButtons[i].Size.Width;
                int sizeH = menuButtons[i].Size.Height;
                menuButtons[i].Location = new Point(btoffX + i % 8 * sizeW, btoffY + i / 8 * sizeH);
                menuButtons[i].Click += menuButton4_Click;
            }

            for (int i = 0; i < menuTexts.Length; i++)
            {
                menuTexts[i].Name = "name" + i;
                int sizeW = menuTexts[i].Size.Width;
                int sizeH = menuTexts[i].Size.Height;
                menuTexts[i].Location = new Point(tboffX + i % 8 * sizeW, tboffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuTips.Length; i++)
            {
                menuTips[i].Name = "price" + i;
                int sizeW = menuTips[i].Size.Width;
                int sizeH = menuTips[i].Size.Height;
                menuTips[i].Location = new Point(proffX + i % 8 * sizeW, proffY + i / 8 * sizeH);
            }

            for (int i = 0; i < menuNud.Length; i++)
            {
                menuNud[i].Name = "nud" + i;
                int sizeW = menuNud[i].Size.Width;
                int sizeH = menuNud[i].Size.Height;
                menuNud[i].Location = new Point(nudoffX + i % 8 * sizeW, nudoffY + i / 8 * sizeH);
            }

            plCmWindow.Controls.AddRange(menuButtons);
            plCmWindow.Controls.AddRange(menuTexts);
            plCmWindow.Controls.AddRange(menuTips);
            plCmWindow.Controls.AddRange(menuNud);
            ResumeLayout(false);
            btMain.Enabled = true;
            btSub.Enabled = true;
            btDessert.Enabled = true;
            btDrink.Enabled = false;
        }

        private void menuButton1_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.AddRange(menuTexts);
            lbOrderList.Items.AddRange(menuNud);
        }

        private void menuButton2_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.AddRange(menuTexts);
            lbOrderList.Items.AddRange(menuNud);
        }

        private void menuButton3_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.AddRange(menuTexts);
            lbOrderList.Items.AddRange(menuNud);
        }

        private void menuButton4_Click(object sender, EventArgs e)
        {
            lbOrderList.Items.AddRange(menuTexts);
            lbOrderList.Items.AddRange(menuNud);
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
