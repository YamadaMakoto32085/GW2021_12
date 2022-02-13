
namespace RestaurantOrderSystem
{
    partial class Form2
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btDecision = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文を確定させます。よろしいですか？";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(17, 91);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 46);
<<<<<<< HEAD
=======
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "注文を確定します。よろしいですか？";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCancel.Location = new System.Drawing.Point(15, 83);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 39);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
>>>>>>> 1c840de (途中)
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDecision
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btDecision.Location = new System.Drawing.Point(205, 91);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(105, 46);
=======
            this.btDecision.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDecision.Location = new System.Drawing.Point(164, 83);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(75, 39);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
            this.btDecision.Location = new System.Drawing.Point(205, 91);
            this.btDecision.Name = "btDecision";
            this.btDecision.Size = new System.Drawing.Size(105, 46);
>>>>>>> 1c840de (途中)
            this.btDecision.TabIndex = 1;
            this.btDecision.Text = "確定";
            this.btDecision.UseVisualStyleBackColor = true;
            this.btDecision.Click += new System.EventHandler(this.btDecision_Click);
            // 
            // Form2
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 159);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 140);
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 159);
>>>>>>> 1c840de (途中)
            this.ControlBox = false;
            this.Controls.Add(this.btDecision);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
<<<<<<< HEAD
<<<<<<< HEAD
            this.Text = "Form2";
=======
            this.Text = "注文確定";
>>>>>>> 069bc0a93294017602a2403c65947f12c0d1af20
=======
            this.Text = "Form2";
>>>>>>> 1c840de (途中)
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDecision;
    }
}