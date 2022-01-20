
namespace RestaurantOrderSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNowTime = new System.Windows.Forms.Label();
            this.btMain = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btDessert = new System.Windows.Forms.Button();
            this.btDrink = new System.Windows.Forms.Button();
            this.plCmWindow = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbPrice4 = new System.Windows.Forms.Label();
            this.btCom4 = new System.Windows.Forms.Button();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPrice3 = new System.Windows.Forms.Label();
            this.btCom3 = new System.Windows.Forms.Button();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.btCom2 = new System.Windows.Forms.Button();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrice1 = new System.Windows.Forms.Label();
            this.btCom1 = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.lbOrderList = new System.Windows.Forms.ListBox();
            this.plCmWindow.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbNowTime.Location = new System.Drawing.Point(12, 9);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(62, 16);
            this.lbNowTime.TabIndex = 0;
            this.lbNowTime.Text = "00:00:00";
            // 
            // btMain
            // 
            this.btMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMain.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMain.Location = new System.Drawing.Point(14, 742);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(153, 67);
            this.btMain.TabIndex = 3;
            this.btMain.Text = "メイン";
            this.btMain.UseVisualStyleBackColor = false;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.White;
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(768, 742);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 67);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.Lime;
            this.btOrder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOrder.Location = new System.Drawing.Point(891, 742);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(235, 67);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "注文";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSub.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSub.Location = new System.Drawing.Point(173, 742);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(153, 67);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "サブ";
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btDessert
            // 
            this.btDessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDessert.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDessert.Location = new System.Drawing.Point(332, 742);
            this.btDessert.Name = "btDessert";
            this.btDessert.Size = new System.Drawing.Size(153, 67);
            this.btDessert.TabIndex = 3;
            this.btDessert.Text = "デザート";
            this.btDessert.UseVisualStyleBackColor = false;
            this.btDessert.Click += new System.EventHandler(this.btDessert_Click);
            // 
            // btDrink
            // 
            this.btDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDrink.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDrink.Location = new System.Drawing.Point(491, 742);
            this.btDrink.Name = "btDrink";
            this.btDrink.Size = new System.Drawing.Size(153, 67);
            this.btDrink.TabIndex = 3;
            this.btDrink.Text = "ドリンク";
            this.btDrink.UseVisualStyleBackColor = false;
            this.btDrink.Click += new System.EventHandler(this.btDrink_Click);
            // 
            // plCmWindow
            // 
            this.plCmWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plCmWindow.Controls.Add(this.panel5);
            this.plCmWindow.Controls.Add(this.panel4);
            this.plCmWindow.Controls.Add(this.panel3);
            this.plCmWindow.Controls.Add(this.panel2);
            this.plCmWindow.Location = new System.Drawing.Point(15, 28);
            this.plCmWindow.Name = "plCmWindow";
            this.plCmWindow.Size = new System.Drawing.Size(726, 708);
            this.plCmWindow.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.lbPrice4);
            this.panel5.Controls.Add(this.btCom4);
            this.panel5.Controls.Add(this.nud4);
            this.panel5.Location = new System.Drawing.Point(558, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 148);
            this.panel5.TabIndex = 3;
            // 
            // lbPrice4
            // 
            this.lbPrice4.AutoSize = true;
            this.lbPrice4.Location = new System.Drawing.Point(63, 121);
            this.lbPrice4.Name = "lbPrice4";
            this.lbPrice4.Size = new System.Drawing.Size(0, 12);
            this.lbPrice4.TabIndex = 2;
            // 
            // btCom4
            // 
            this.btCom4.Enabled = false;
            this.btCom4.Location = new System.Drawing.Point(13, 15);
            this.btCom4.Name = "btCom4";
            this.btCom4.Size = new System.Drawing.Size(121, 98);
            this.btCom4.TabIndex = 0;
            this.btCom4.UseVisualStyleBackColor = true;
            this.btCom4.Click += new System.EventHandler(this.btCom4_Click);
            // 
            // nud4
            // 
            this.nud4.Enabled = false;
            this.nud4.Location = new System.Drawing.Point(13, 119);
            this.nud4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(44, 19);
            this.nud4.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lbPrice3);
            this.panel4.Controls.Add(this.btCom3);
            this.panel4.Controls.Add(this.nud3);
            this.panel4.Location = new System.Drawing.Point(379, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 148);
            this.panel4.TabIndex = 3;
            // 
            // lbPrice3
            // 
            this.lbPrice3.AutoSize = true;
            this.lbPrice3.Location = new System.Drawing.Point(63, 121);
            this.lbPrice3.Name = "lbPrice3";
            this.lbPrice3.Size = new System.Drawing.Size(0, 12);
            this.lbPrice3.TabIndex = 2;
            // 
            // btCom3
            // 
            this.btCom3.Enabled = false;
            this.btCom3.Location = new System.Drawing.Point(13, 15);
            this.btCom3.Name = "btCom3";
            this.btCom3.Size = new System.Drawing.Size(121, 98);
            this.btCom3.TabIndex = 0;
            this.btCom3.UseVisualStyleBackColor = true;
            this.btCom3.Click += new System.EventHandler(this.btCom3_Click);
            // 
            // nud3
            // 
            this.nud3.Enabled = false;
            this.nud3.Location = new System.Drawing.Point(13, 119);
            this.nud3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(44, 19);
            this.nud3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.lbPrice2);
            this.panel3.Controls.Add(this.btCom2);
            this.panel3.Controls.Add(this.nud2);
            this.panel3.Location = new System.Drawing.Point(196, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 148);
            this.panel3.TabIndex = 2;
            // 
            // lbPrice2
            // 
            this.lbPrice2.AutoSize = true;
            this.lbPrice2.Location = new System.Drawing.Point(63, 121);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(0, 12);
            this.lbPrice2.TabIndex = 2;
            // 
            // btCom2
            // 
            this.btCom2.Enabled = false;
            this.btCom2.Location = new System.Drawing.Point(13, 15);
            this.btCom2.Name = "btCom2";
            this.btCom2.Size = new System.Drawing.Size(121, 98);
            this.btCom2.TabIndex = 0;
            this.btCom2.UseVisualStyleBackColor = true;
            this.btCom2.Click += new System.EventHandler(this.btCom2_Click);
            // 
            // nud2
            // 
            this.nud2.Enabled = false;
            this.nud2.Location = new System.Drawing.Point(13, 119);
            this.nud2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(44, 19);
            this.nud2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lbPrice1);
            this.panel2.Controls.Add(this.btCom1);
            this.panel2.Controls.Add(this.nud1);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 148);
            this.panel2.TabIndex = 2;
            // 
            // lbPrice1
            // 
            this.lbPrice1.AutoSize = true;
            this.lbPrice1.Location = new System.Drawing.Point(71, 121);
            this.lbPrice1.Name = "lbPrice1";
            this.lbPrice1.Size = new System.Drawing.Size(0, 12);
            this.lbPrice1.TabIndex = 2;
            // 
            // btCom1
            // 
            this.btCom1.Enabled = false;
            this.btCom1.Location = new System.Drawing.Point(13, 15);
            this.btCom1.Name = "btCom1";
            this.btCom1.Size = new System.Drawing.Size(121, 98);
            this.btCom1.TabIndex = 0;
            this.btCom1.UseVisualStyleBackColor = true;
            this.btCom1.Click += new System.EventHandler(this.btCom1_Click);
            // 
            // nud1
            // 
            this.nud1.Enabled = false;
            this.nud1.Location = new System.Drawing.Point(13, 119);
            this.nud1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(52, 19);
            this.nud1.TabIndex = 1;
            // 
            // lbOrderList
            // 
            this.lbOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOrderList.FormattingEnabled = true;
            this.lbOrderList.ItemHeight = 12;
            this.lbOrderList.Location = new System.Drawing.Point(747, 28);
            this.lbOrderList.Name = "lbOrderList";
            this.lbOrderList.Size = new System.Drawing.Size(394, 580);
            this.lbOrderList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 821);
            this.ControlBox = false;
            this.Controls.Add(this.lbOrderList);
            this.Controls.Add(this.plCmWindow);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDrink);
            this.Controls.Add(this.btDessert);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMain);
            this.Controls.Add(this.lbNowTime);
            this.Name = "Form1";
            this.Text = "飲食店専用注文システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plCmWindow.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDessert;
        private System.Windows.Forms.Button btDrink;
        private System.Windows.Forms.Panel plCmWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Button btCom2;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPrice1;
        private System.Windows.Forms.Button btCom1;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.ListBox lbOrderList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbPrice4;
        private System.Windows.Forms.Button btCom4;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbPrice3;
        private System.Windows.Forms.Button btCom3;
        private System.Windows.Forms.NumericUpDown nud3;
    }
}

