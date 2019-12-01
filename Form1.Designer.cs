namespace Zapamietywanie_gra
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn_container = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer_endgame = new System.Windows.Forms.Timer(this.components);
            this.lbl_endinfo = new System.Windows.Forms.Label();
            this.lbl_end_time = new System.Windows.Forms.Label();
            this.btn_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1.Location = new System.Drawing.Point(9, 10);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 100);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn4.Location = new System.Drawing.Point(9, 116);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 100);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.Location = new System.Drawing.Point(221, 10);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 100);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.Location = new System.Drawing.Point(115, 10);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 100);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn5.Location = new System.Drawing.Point(115, 116);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 100);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn6.Location = new System.Drawing.Point(221, 116);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 100);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn8.Location = new System.Drawing.Point(115, 222);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 100);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn7.Location = new System.Drawing.Point(9, 222);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 100);
            this.btn7.TabIndex = 9;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn9.Location = new System.Drawing.Point(221, 222);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 100);
            this.btn9.TabIndex = 10;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn_container
            // 
            this.btn_container.Controls.Add(this.btn9);
            this.btn_container.Controls.Add(this.btn7);
            this.btn_container.Controls.Add(this.btn8);
            this.btn_container.Controls.Add(this.btn6);
            this.btn_container.Controls.Add(this.btn5);
            this.btn_container.Controls.Add(this.btn2);
            this.btn_container.Controls.Add(this.btn3);
            this.btn_container.Controls.Add(this.btn4);
            this.btn_container.Controls.Add(this.btn1);
            this.btn_container.Location = new System.Drawing.Point(31, 51);
            this.btn_container.Name = "btn_container";
            this.btn_container.Size = new System.Drawing.Size(330, 344);
            this.btn_container.TabIndex = 12;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(31, 13);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 13;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(121, 18);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(19, 13);
            this.lbl_time.TabIndex = 14;
            this.lbl_time.Text = "00";
            // 
            // timer_endgame
            // 
            this.timer_endgame.Interval = 1000;
            this.timer_endgame.Tick += new System.EventHandler(this.timer_endgame_Tick);
            // 
            // lbl_endinfo
            // 
            this.lbl_endinfo.AutoSize = true;
            this.lbl_endinfo.Location = new System.Drawing.Point(249, 18);
            this.lbl_endinfo.Name = "lbl_endinfo";
            this.lbl_endinfo.Size = new System.Drawing.Size(74, 13);
            this.lbl_endinfo.TabIndex = 15;
            this.lbl_endinfo.Text = "Koniec gry za:";
            // 
            // lbl_end_time
            // 
            this.lbl_end_time.AutoSize = true;
            this.lbl_end_time.Location = new System.Drawing.Point(330, 18);
            this.lbl_end_time.Name = "lbl_end_time";
            this.lbl_end_time.Size = new System.Drawing.Size(19, 13);
            this.lbl_end_time.TabIndex = 16;
            this.lbl_end_time.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 459);
            this.Controls.Add(this.lbl_end_time);
            this.Controls.Add(this.lbl_endinfo);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.btn_container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Panel btn_container;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer_endgame;
        private System.Windows.Forms.Label lbl_endinfo;
        private System.Windows.Forms.Label lbl_end_time;
    }
}

