﻿
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
            this.tbCmWindow = new System.Windows.Forms.TextBox();
            this.tbOrdertList = new System.Windows.Forms.TextBox();
            this.btMain = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btDessert = new System.Windows.Forms.Button();
            this.btDrink = new System.Windows.Forms.Button();
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
            // tbCmWindow
            // 
            this.tbCmWindow.BackColor = System.Drawing.Color.White;
            this.tbCmWindow.Location = new System.Drawing.Point(14, 28);
            this.tbCmWindow.Multiline = true;
            this.tbCmWindow.Name = "tbCmWindow";
            this.tbCmWindow.ReadOnly = true;
            this.tbCmWindow.Size = new System.Drawing.Size(737, 708);
            this.tbCmWindow.TabIndex = 1;
            // 
            // tbOrdertList
            // 
            this.tbOrdertList.BackColor = System.Drawing.Color.White;
            this.tbOrdertList.Location = new System.Drawing.Point(768, 28);
            this.tbOrdertList.Multiline = true;
            this.tbOrdertList.Name = "tbOrdertList";
            this.tbOrdertList.ReadOnly = true;
            this.tbOrdertList.Size = new System.Drawing.Size(358, 708);
            this.tbOrdertList.TabIndex = 2;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 821);
            this.ControlBox = false;
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDrink);
            this.Controls.Add(this.btDessert);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btMain);
            this.Controls.Add(this.tbOrdertList);
            this.Controls.Add(this.tbCmWindow);
            this.Controls.Add(this.lbNowTime);
            this.Name = "Form1";
            this.Text = "飲食店専用注文システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.TextBox tbCmWindow;
        private System.Windows.Forms.TextBox tbOrdertList;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDessert;
        private System.Windows.Forms.Button btDrink;
    }
}

