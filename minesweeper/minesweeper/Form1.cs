using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        int allBombs = 0;
        int score = 0;
        int W = 30;
        int H = 30;

        public Random rng = new Random();

        ButtonExtended[,] allButtons;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";

            Size = new Size(356, 400);
<<<<<<< HEAD
<<<<<<< HEAD

            checkBox1.Visible = false;
=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int W = 30;
            int H = 30;
<<<<<<< HEAD
<<<<<<< HEAD

            button1.Visible = false;
            checkBox1.Visible = true;

=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
            allButtons = new ButtonExtended[W, H];
            ButtonExtended[,] button = new ButtonExtended[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    button[i, j] = new ButtonExtended();
                    button[i, j].Name = "Buttons";
                    button[i, j].Size = new Size(W, H);
                    button[i, j].Location = new Point(20 + W * i, 50 + H * j);
                    button[i, j].Click += new EventHandler(btn_Click);
                    button[i, j].Text = "";
                    button[i, j].Tag = new Point(i, j);
<<<<<<< HEAD
<<<<<<< HEAD
                    button[i, j].BackColor = Color.LightGray;
                    button[i, j].isNotTouched = true;

                    if (rng.Next(0, 101) < 20)
=======
                    Controls.Add(button[i, j]);
                    if (rng.Next(0, 101) < 90)
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
=======
                    Controls.Add(button[i, j]);
                    if (rng.Next(0, 101) < 90)
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
                    {
                        button[i, j].isBomb = true;
                        button[i, j].isOpened = false;

                    }

                    Controls.Add(button[i, j]);
                    allButtons[i, j] = button[i, j];
                }
        }
        void btn_Click(object sender, EventArgs e)
        {
            ButtonExtended button = (ButtonExtended)sender;
<<<<<<< HEAD
<<<<<<< HEAD

            if (checkBox1.Checked && !button.isChecked)
            {
                button.BackColor = Color.Green;
                button.isChecked = true;
            }
            else if (checkBox1.Checked && button.isChecked)
            {
                button.BackColor = Color.LightGray;
                button.isChecked = false;
            }
            else if (button.isBomb && !button.isChecked)
=======
            if (button.isBomb)
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
=======
            if (button.isBomb)
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
            {
                Explode(button);
            }
            else if (!button.isOpened)
            {
                EmptyFieldClick(button);
                button.isOpened = true;
                score++;
            }
            else
            {
                EmptyFieldClick(button);

            }

            int allBombs = 0;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (allButtons[i, j].isBomb)
                    {
                        allBombs++;
                    }
                }


            if (100 - allBombs == score)
            {
                Win();
            }

            label1.Text = allBombs.ToString();
            label2.Text = score.ToString();
        }

        void Win()
        {
            MessageBox.Show("Вы победили");
        }
        void Explode(ButtonExtended button)
        {
            MessageBox.Show("Вы проиграли");
            for  (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (allButtons[i, j].isBomb)
                    {
                        allButtons[i, j].Text = "*";
                        allButtons[i, j].BackColor = Color.Red;
                    }
                }
        }

        void EmptyFieldClick(ButtonExtended button)
        {
            for (int i = 0; i < 10; i++)
                for(int j = 0; j < 10; j++)
                {
                    if (allButtons[i, j] == button)
                    {
                        if (CountBombs(i, j) == 0 && allButtons[i, j].isNotTouched)
                        {
                            for (int a = i - 1; a <= i + 1; a++)
                                for (int b = j - 1; b <= j + 1; b++)
                                {
                                    if (a >= 0 && a < 10 && b >= 0 && b < 10)
                                    {
                                        allButtons[i, j].isNotTouched = false;
                                        EmptyFieldClick(allButtons[a, b]);
                                         
                                    }
                                }
                        }
                        else
                        {
                            button.Text = "" + CountBombs(i, j);
                            button.BackColor = Color.Gray;
                        }
                    }
                }
        }

        int CountBombs(int iB, int jB)
        {
            int bombCount = 0;
            for (int i = iB-1; i <= iB + 1; i++)
                for (int j = jB - 1; j <= jB + 1; j++)
                {
                    if (i >= 0 && i < 10 && j >= 0 && j < 10)
                    {
                        if (allButtons[i, j].isBomb)
                        {
                            bombCount++;
                        }
                    }
                }
            return bombCount;
        }
    }

    class ButtonExtended:Button
    {
        public bool isBomb;
        public bool isOpened;
<<<<<<< HEAD
<<<<<<< HEAD
        public bool isChecked;
        public bool isNotTouched;
=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
=======
>>>>>>> parent of 75d5b14 (minesweeper 0.5)
    }
}
