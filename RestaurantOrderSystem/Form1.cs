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
    }
}
