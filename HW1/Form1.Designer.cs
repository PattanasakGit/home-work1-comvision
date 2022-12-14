namespace HW1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.picView_1 = new System.Windows.Forms.PictureBox();
            this.picView_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picView_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView_2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 863);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 88);
            this.button1.TabIndex = 1;
            this.button1.Text = "ประมวณผล";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picView_1
            // 
            this.picView_1.Location = new System.Drawing.Point(21, 12);
            this.picView_1.Name = "picView_1";
            this.picView_1.Size = new System.Drawing.Size(790, 828);
            this.picView_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView_1.TabIndex = 2;
            this.picView_1.TabStop = false;
            // 
            // picView_2
            // 
            this.picView_2.Location = new System.Drawing.Point(830, 12);
            this.picView_2.Name = "picView_2";
            this.picView_2.Size = new System.Drawing.Size(782, 828);
            this.picView_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picView_2.TabIndex = 3;
            this.picView_2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 1057);
            this.Controls.Add(this.picView_2);
            this.Controls.Add(this.picView_1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Home Work 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picView_1;
        private System.Windows.Forms.PictureBox picView_2;
    }
}

