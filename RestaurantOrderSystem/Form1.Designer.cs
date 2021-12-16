
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
            this.btSub = new System.Windows.Forms.Button();
            this.btDessert = new System.Windows.Forms.Button();
            this.btDrink = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNowTime
            // 
            this.lbNowTime.AutoSize = true;
            this.lbNowTime.Location = new System.Drawing.Point(12, 9);
            this.lbNowTime.Name = "lbNowTime";
            this.lbNowTime.Size = new System.Drawing.Size(45, 12);
            this.lbNowTime.TabIndex = 0;
            this.lbNowTime.Text = "00:00:00";
            // 
            // tbCmWindow
            // 
            this.tbCmWindow.Location = new System.Drawing.Point(14, 24);
            this.tbCmWindow.Multiline = true;
            this.tbCmWindow.Name = "tbCmWindow";
            this.tbCmWindow.Size = new System.Drawing.Size(733, 712);
            this.tbCmWindow.TabIndex = 1;
            // 
            // tbOrdertList
            // 
            this.tbOrdertList.Location = new System.Drawing.Point(779, 24);
            this.tbOrdertList.Multiline = true;
            this.tbOrdertList.Name = "tbOrdertList";
            this.tbOrdertList.Size = new System.Drawing.Size(358, 712);
            this.tbOrdertList.TabIndex = 2;
            // 
            // btMain
            // 
            this.btMain.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMain.Location = new System.Drawing.Point(14, 742);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(148, 67);
            this.btMain.TabIndex = 3;
            this.btMain.Text = "メイン";
            this.btMain.UseVisualStyleBackColor = true;
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSub.Location = new System.Drawing.Point(168, 742);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(148, 67);
            this.btSub.TabIndex = 3;
            this.btSub.Text = "サブ";
            this.btSub.UseVisualStyleBackColor = true;
            // 
            // btDessert
            // 
            this.btDessert.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDessert.Location = new System.Drawing.Point(322, 742);
            this.btDessert.Name = "btDessert";
            this.btDessert.Size = new System.Drawing.Size(148, 67);
            this.btDessert.TabIndex = 3;
            this.btDessert.Text = "デザート";
            this.btDessert.UseVisualStyleBackColor = true;
            // 
            // btDrink
            // 
            this.btDrink.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDrink.Location = new System.Drawing.Point(476, 742);
            this.btDrink.Name = "btDrink";
            this.btDrink.Size = new System.Drawing.Size(148, 67);
            this.btDrink.TabIndex = 3;
            this.btDrink.Text = "ドリンク";
            this.btDrink.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(779, 742);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 67);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOrder
            // 
            this.btOrder.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOrder.Location = new System.Drawing.Point(902, 742);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(235, 67);
            this.btOrder.TabIndex = 3;
            this.btOrder.Text = "注文";
            this.btOrder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 821);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNowTime;
        private System.Windows.Forms.TextBox tbCmWindow;
        private System.Windows.Forms.TextBox tbOrdertList;
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDessert;
        private System.Windows.Forms.Button btDrink;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOrder;
    }
}

