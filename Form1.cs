using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zapamietywanie_gra
{
    public partial class Form1 : Form
    {
        public List<Button> buttons;
        public List<Color> colors;
        public List<Color> dueColors = new List<Color>();
        public bool[] clickedButtons = new bool[9];

        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            colors = new List<Color>() { Color.Yellow, Color.Green, Color.Red };
            for (int i = 0; i < 9; i++)
            {
                clickedButtons[i] = false;
            }
        }

        public int colorChange = 0;
        public int time = 11;
        public int time_end = 31;
        public int controlSum = 0;
        public int clicked = 0;

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer_endgame.Enabled = true;
            SetBtn();
            btn_start.Enabled = false;
            BtnBlock(Buttonki());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = time.ToString();
            time--;
            if (time == 0)
            {
                timer.Enabled = false;
                Reset(Buttonki());
                BtnUnlock(Buttonki());
            }
            lbl_time.Text = time.ToString();
        }

        private void SetBtn()
        {
            Random col_low = new Random();
            Random col = col_low;
            List<Button> btn_list = Buttonki();
            List<Color> btn_Color = Buttonki_Color(Buttonki());
            for (int i = 0; i < btn_list.Count; i++)
            {
                btn_list.ToArray();
                btn_list[i].BackColor = colors[col.Next(0, colors.Count)];
                btn_Color.Add(btn_list[i].BackColor);
                dueColors.Add(btn_list[i].BackColor);
            }
            btn_Color.ToArray();
        }

        private List<Button> Buttonki()
        {
            List<Button> btn_list = new List<Button>();
            btn_list.Add(btn1);
            btn_list.Add(btn2);
            btn_list.Add(btn3);
            btn_list.Add(btn4);
            btn_list.Add(btn5);
            btn_list.Add(btn6);
            btn_list.Add(btn7);
            btn_list.Add(btn8);
            btn_list.Add(btn9);
            for (int i = 0; i < btn_list.Count; i++)
            {
                btn_list.ToArray();
            }
            return btn_list;
        }

        private List<Color> Buttonki_Color(List<Button> btns)
        {
            List<Color> btn_Color = new List<Color>();
            for (int i = 0; i < btns.Count; i++)
            {
                btn_Color.Add(btns[i].BackColor);
            }
            return btn_Color;
        }

        private void Reset(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].BackColor = Color.Gray;
            }
        }

        private void Klikniety(int index)
        {
            clickedButtons[index] = true;
        }

        private void ChangeColor(Button btnX)
        {
            switch (colorChange)
            {
                case 0:
                case 1:
                    btnX.BackColor = colors[colorChange];
                    colorChange++;
                    break;

                case 2:
                    btnX.BackColor = colors[colorChange];
                    colorChange = 0;
                    break;
            }
            CheckButtons();
        }

        private void BtnBlock(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].Enabled = false;
            }
        }
        private void BtnUnlock(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].Enabled = true;
            }
        }

        private void CheckButtons()
        {
            for (int i = 0; i < 9; i++)
            {
                if (clickedButtons[i] == true)
                {
                    clicked++;
                }
            }
            if (clicked == 9)
            {
                for (int z = 0; z <= buttons.Count - 1; z++)
                {
                    if (buttons.ElementAt(z).BackColor == dueColors.ElementAt(z))
                    {
                        controlSum++;
                    }
                }
                if (controlSum == 9)
                {
                    timer_endgame.Enabled = false;
                    MessageBox.Show("Prawidłowo zapamiętałeś kolory. Brawo!!");
                }
                else
                {
                    controlSum = 0;
                }
            }
            else
            {
                clicked = 0;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Klikniety(0);
            ChangeColor(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Klikniety(1);
            ChangeColor(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Klikniety(2);
            ChangeColor(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Klikniety(3);
            ChangeColor(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Klikniety(4);
            ChangeColor(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Klikniety(5);
            ChangeColor(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Klikniety(6);
            ChangeColor(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Klikniety(7);
            ChangeColor(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Klikniety(8);
            ChangeColor(btn9);
        }

        private void timer_endgame_Tick(object sender, EventArgs e)
        {
            lbl_end_time.Text = time_end.ToString();
            time_end--;
            if (time_end == 0)
            {
                timer_endgame.Enabled = false;
                MessageBox.Show("Niestety nie udało Ci się poprawnie zapamiętać kolorów w podanym czasie");
            }
            lbl_end_time.Text = time_end.ToString();
        }
    }
}