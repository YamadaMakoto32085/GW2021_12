
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
            this.btMain = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btDessert = new System.Windows.Forms.Button();
            this.btDrink = new System.Windows.Forms.Button();
            this.plCmWindow = new System.Windows.Forms.Panel();
            this.lbOrderList = new System.Windows.Forms.ListBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbNowTime.Location = new System.Drawing.Point(16, 11);
            this.lbNowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(77, 20);
            this.lbNowTime.TabIndex = 0;
            this.lbNowTime.Text = "00:00:00";
            // 
            // tbCmWindow
            // 
            this.tbCmWindow.BackColor = System.Drawing.Color.White;
            this.tbCmWindow.Location = new System.Drawing.Point(19, 35);
            this.tbCmWindow.Margin = new System.Windows.Forms.Padding(4);
            this.tbCmWindow.Multiline = true;
            this.tbCmWindow.Name = "tbCmWindow";
            this.tbCmWindow.ReadOnly = true;
            this.tbCmWindow.Size = new System.Drawing.Size(981, 884);
            this.tbCmWindow.TabIndex = 1;
            // 
            // tbOrdertList
            // 
            this.tbOrdertList.BackColor = System.Drawing.Color.White;
            this.tbOrdertList.Location = new System.Drawing.Point(1024, 35);
            this.tbOrdertList.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrdertList.Multiline = true;
            this.tbOrdertList.Name = "tbOrdertList";
            this.tbOrdertList.ReadOnly = true;
            this.tbOrdertList.Size = new System.Drawing.Size(476, 884);
            this.tbOrdertList.TabIndex = 2;
            // 
=======
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
            // btMain
            // 
            this.btMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMain.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMain.Location = new System.Drawing.Point(19, 928);
            this.btMain.Margin = new System.Windows.Forms.Padding(4);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(204, 84);
            this.btMain.TabIndex = 3;
            this.btMain.Text = "メイン";
            this.btMain.UseVisualStyleBackColor = false;
            this.btMain.Click += new System.EventHandler(this.btMain_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.White;
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(1024, 928);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(156, 84);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOrder
            // 
            this.btOrder.BackColor = System.Drawing.Color.Lime;
            this.btOrder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOrder.Location = new System.Drawing.Point(1188, 928);
            this.btOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(313, 84);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "注文";
            this.btOrder.UseVisualStyleBackColor = false;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSub.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSub.Location = new System.Drawing.Point(231, 928);
            this.btSub.Margin = new System.Windows.Forms.Padding(4);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(204, 84);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "サブ";
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btDessert
            // 
            this.btDessert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btDessert.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDessert.Location = new System.Drawing.Point(443, 928);
            this.btDessert.Margin = new System.Windows.Forms.Padding(4);
            this.btDessert.Name = "btDessert";
            this.btDessert.Size = new System.Drawing.Size(204, 84);
            this.btDessert.TabIndex = 3;
            this.btDessert.Text = "デザート";
            this.btDessert.UseVisualStyleBackColor = false;
            this.btDessert.Click += new System.EventHandler(this.btDessert_Click);
            // 
            // btDrink
            // 
            this.btDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDrink.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDrink.Location = new System.Drawing.Point(655, 928);
            this.btDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btDrink.Name = "btDrink";
            this.btDrink.Size = new System.Drawing.Size(204, 84);
            this.btDrink.TabIndex = 3;
            this.btDrink.Text = "ドリンク";
            this.btDrink.UseVisualStyleBackColor = false;
            this.btDrink.Click += new System.EventHandler(this.btDrink_Click);
<<<<<<< HEAD
<<<<<<< HEAD
=======
            // 
            // plCmWindow
            // 
            this.plCmWindow.AutoScroll = true;
            this.plCmWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.plCmWindow.Location = new System.Drawing.Point(15, 12);
            this.plCmWindow.Name = "plCmWindow";
            this.plCmWindow.Size = new System.Drawing.Size(747, 724);
            this.plCmWindow.TabIndex = 4;
            // 
            // lbOrderList
            // 
            this.lbOrderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbOrderList.FormattingEnabled = true;
            this.lbOrderList.ItemHeight = 12;
            this.lbOrderList.Location = new System.Drawing.Point(768, 12);
            this.lbOrderList.Name = "lbOrderList";
            this.lbOrderList.Size = new System.Drawing.Size(373, 592);
            this.lbOrderList.TabIndex = 5;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(1010, 605);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(131, 19);
            this.tbSum.TabIndex = 6;
            this.tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(959, 605);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 19);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "合計金額";
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
>>>>>>> 1c840de (途中)
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 1c840de (途中)
            this.ClientSize = new System.Drawing.Size(1537, 1026);
            this.ControlBox = false;
=======
            this.ClientSize = new System.Drawing.Size(1153, 821);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lbOrderList);
            this.Controls.Add(this.plCmWindow);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDrink);
            this.Controls.Add(this.btDessert);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMain);
<<<<<<< HEAD
            this.Controls.Add(this.tbOrdertList);
            this.Controls.Add(this.tbCmWindow);
            this.Controls.Add(this.lbNowTime);
            this.Margin = new System.Windows.Forms.Padding(4);
<<<<<<< HEAD
=======
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
>>>>>>> 1c840de (途中)
            this.Name = "Form1";
            this.Text = "飲食店専用注文システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDessert;
        private System.Windows.Forms.Button btDrink;
        private System.Windows.Forms.Panel plCmWindow;
        private System.Windows.Forms.ListBox lbOrderList;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.TextBox textBox5;
    }
}

