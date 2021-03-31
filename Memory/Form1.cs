using System;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        private int moves = 0;
        private int[] tile = new int[16];
        private Boolean[] tileDisplay = new Boolean[16];
        private Boolean firstShot = true;

        private int firstIndex;
        private int secondIndex;

        public Form1()
        {
            InitializeComponent();

            StartGame();
        }

        private void StartGame()
        {
            moves = 0;
            firstIndex = -1;
            secondIndex = -1;

            ResetTiles();
            GenerateColors();
            HideText();
        }

        private void ResetTiles()
        {
            for (int i = 0; i < 16; i++)
            {
                tile[i] = 0;
            }
        }

        private void GenerateColors()
        {
            for (int i = 1; i <= 8; i++)
            {
                // losuj pierwszy kafel
                int[] pair = GetEmptyTilesPair();
                tile[pair[0]] = i;
                tile[pair[1]] = i;
            }
        }

        private void HideText()
        {
            for (int i = 0; i < 16; i++)
            {
                tileDisplay[i] = false;
            }
            Render();
        }

        private int[] GetEmptyTilesPair()
        {
            Random rand = new Random();
            int first = -1, second = -1;
            int j = 0;

            do
            {
                first = rand.Next(0, 16);
                j++;
                if (tile[first] == 0) break;
            } while (true);

            j = 0;
            do
            {
                second = rand.Next(0, 15);
                j++;
                if (tile[second] == 0 && second != first) break;
            } while (true);

            return new int[] { first, second };
        }

        private void Check()
        {
            if (tile[firstIndex] == tile[secondIndex])
            {
                tileDisplay[firstIndex] = true;
                tileDisplay[secondIndex] = true;

                CheckIfEnd();
            }
            else
            {
                MessageBox.Show("Pudło");
                tileDisplay[firstIndex] = false;
                tileDisplay[secondIndex] = false;
            }

            firstIndex = -1;
            secondIndex = -1;
            firstShot = true;
            moves++;

            Render();
        }

        private void CheckIfEnd()
        {
            Boolean flag = true;

            for (int i = 0; i < 16; i++)
            {
                if (tileDisplay[i] == false) flag = false;
            }

            if (flag) MessageBox.Show("BRAWO!");
        }

        private void Render()
        {
            if (tileDisplay[0]) button1.Text = Convert.ToString(tile[0]);
            else button1.Text = "";

            if (tileDisplay[1]) button2.Text = Convert.ToString(tile[1]);
            else button2.Text = "";

            if (tileDisplay[2]) button3.Text = Convert.ToString(tile[2]);
            else button3.Text = "";

            if (tileDisplay[3]) button4.Text = Convert.ToString(tile[3]);
            else button4.Text = "";

            if (tileDisplay[4]) button5.Text = Convert.ToString(tile[4]);
            else button5.Text = "";

            if (tileDisplay[5]) button6.Text = Convert.ToString(tile[5]);
            else button6.Text = "";

            if (tileDisplay[6]) button7.Text = Convert.ToString(tile[6]);
            else button7.Text = "";

            if (tileDisplay[7]) button8.Text = Convert.ToString(tile[7]);
            else button8.Text = "";

            if (tileDisplay[8]) button9.Text = Convert.ToString(tile[8]);
            else button9.Text = "";

            if (tileDisplay[9]) button10.Text = Convert.ToString(tile[9]);
            else button10.Text = "";

            if (tileDisplay[10]) button11.Text = Convert.ToString(tile[10]);
            else button11.Text = "";

            if (tileDisplay[11]) button12.Text = Convert.ToString(tile[11]);
            else button12.Text = "";

            if (tileDisplay[12]) button13.Text = Convert.ToString(tile[12]);
            else button13.Text = "";

            if (tileDisplay[13]) button14.Text = Convert.ToString(tile[13]);
            else button14.Text = "";

            if (tileDisplay[14]) button15.Text = Convert.ToString(tile[14]);
            else button15.Text = "";

            if (tileDisplay[15]) button16.Text = Convert.ToString(tile[15]);
            else button16.Text = "";

            label2.Text = Convert.ToString(moves);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(tile[0]);
            int index = 0;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Convert.ToString(tile[1]);
            int index = 1;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Convert.ToString(tile[2]);
            int index = 2;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = Convert.ToString(tile[3]);
            int index = 3;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = Convert.ToString(tile[4]);
            int index = 4;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = Convert.ToString(tile[5]);
            int index = 5;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Convert.ToString(tile[6]);
            int index = 6;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = Convert.ToString(tile[7]);
            int index = 7;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                tileDisplay[i] = true;
            }

            Render();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = Convert.ToString(tile[8]);
            int index = 8;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = Convert.ToString(tile[9]);
            int index = 9;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = Convert.ToString(tile[10]);
            int index = 10;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = Convert.ToString(tile[11]);
            int index = 11;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = Convert.ToString(tile[12]);
            int index = 12;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = Convert.ToString(tile[13]);
            int index = 13;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = Convert.ToString(tile[14]);
            int index = 14;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = Convert.ToString(tile[15]);
            int index = 15;

            if (firstShot == true)
            {
                firstIndex = index;
                firstShot = false;
            }
            else
            {
                secondIndex = index;
                Check();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}