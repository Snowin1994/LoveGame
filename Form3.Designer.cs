﻿namespace ForMyLove
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "点我试试？";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "不要点我";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "小心点，还是好的";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(162, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "选一个吧，选完了就要照做哦！\r\n亲情提示：小心点，别乱点！";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "这个我喜欢";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 63);
            this.button5.TabIndex = 5;
            this.button5.Text = "选错了，后果自负哟";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(481, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 63);
            this.button6.TabIndex = 6;
            this.button6.Text = "不要轻易尝试";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(615, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 25);
            this.button7.TabIndex = 7;
            this.button7.Text = "下一章";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 345);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "爱的第二章";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}