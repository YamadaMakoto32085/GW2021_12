
namespace RestaurantOrderSystem
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 1c840de (途中)
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文が確定しました。";
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(56, 86);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 48);
<<<<<<< HEAD
=======
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文を確定しました。";
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(37, 44);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 38);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
>>>>>>> 1c840de (途中)
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "確認";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // Form3
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 146);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 94);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 146);
>>>>>>> 1c840de (途中)
            this.ControlBox = false;
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCheck;
    }
}