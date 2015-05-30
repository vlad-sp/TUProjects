using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NQueenSolution;

namespace NQueenSolution.Views
{
    public partial class MainContentForm : Form
    {
        private int updatedTextBox;
        public int[,] Board = new int[8, 8];
        public MainContentForm()
        {
            InitializeComponent();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        public void ShowLeftQueens(RadioButton rbutton)
        {
            int leftQueens = (rbutton.Name[6] - '0') - updatedTextBox;
            if (rbutton.Checked)
            {
                txtbox.Text = leftQueens.ToString();
            }
        }

        public void DrawBoard5()
        {
            pb00.BackColor = Color.White;
            pb01.BackColor = Color.Gray;
            pb02.BackColor = Color.White;
            pb03.BackColor = Color.Gray;
            pb04.BackColor = Color.White;
            pb10.BackColor = Color.Gray;
            pb11.BackColor = Color.White;
            pb12.BackColor = Color.Gray;
            pb13.BackColor = Color.White;
            pb14.BackColor = Color.Gray;
            pb20.BackColor = Color.White;
            pb21.BackColor = Color.Gray;
            pb22.BackColor = Color.White;
            pb23.BackColor = Color.Gray;
            pb24.BackColor = Color.White;
            pb30.BackColor = Color.Gray;
            pb31.BackColor = Color.White;
            pb32.BackColor = Color.Gray;
            pb33.BackColor = Color.White;
            pb34.BackColor = Color.Gray;
            pb40.BackColor = Color.White;
            pb41.BackColor = Color.Gray;
            pb42.BackColor = Color.White;
            pb43.BackColor = Color.Gray;
            pb44.BackColor = Color.White;
        }
        public void DrawBoard6()
        {
            DrawBoard5();
            pb05.BackColor = Color.Gray;
            pb15.BackColor = Color.White;
            pb25.BackColor = Color.Gray;
            pb35.BackColor = Color.White;
            pb45.BackColor = Color.Gray;
            pb50.BackColor = Color.Gray;
            pb51.BackColor = Color.White;
            pb52.BackColor = Color.Gray;
            pb53.BackColor = Color.White;
            pb54.BackColor = Color.Gray;
            pb55.BackColor = Color.White;
        }
        public void DrawBoard7()
        {
            DrawBoard6();
            pb06.BackColor = Color.White;
            pb16.BackColor = Color.Gray;
            pb26.BackColor = Color.White;
            pb36.BackColor = Color.Gray;
            pb46.BackColor = Color.White;
            pb56.BackColor = Color.Gray;
            pb60.BackColor = Color.White;
            pb61.BackColor = Color.Gray;
            pb62.BackColor = Color.White;
            pb63.BackColor = Color.Gray;
            pb64.BackColor = Color.White;
            pb65.BackColor = Color.Gray;
            pb66.BackColor = Color.White;
        }
        public void DrawBoard8()
        {
            DrawBoard7();
            pb07.BackColor = Color.Gray;
            pb17.BackColor = Color.White;
            pb27.BackColor = Color.Gray;
            pb37.BackColor = Color.White;
            pb47.BackColor = Color.Gray;
            pb57.BackColor = Color.White;
            pb67.BackColor = Color.Gray;
            pb70.BackColor = Color.Gray;
            pb71.BackColor = Color.White;
            pb72.BackColor = Color.Gray;
            pb73.BackColor = Color.White;
            pb74.BackColor = Color.Gray;
            pb75.BackColor = Color.White;
            pb76.BackColor = Color.Gray;
            pb77.BackColor = Color.White;

        }

        public void ValidatorClick(PictureBox pb)
        {
            Board[pb.Name[2] - '0', pb.Name[3] - '0'] = 1;

            if (txtbox.Text == "0" && pb.Image == null)
            {
                MessageBox.Show("You don't have any queens left! Press check for solution or double click on queen to remove it!");
            }
            else
            {
                if (pb.Image == null)
                {
                    updatedTextBox = int.Parse(txtbox.Text) - 1;
                    txtbox.Text = updatedTextBox.ToString();
                    pb.Image = Properties.Resources.BlackQueen;
                }

            }
        }
        public void ValidatorDoubleClick(PictureBox pb)
        {
            Board[pb.Name[2] - '0', pb.Name[3] - '0'] = 0;

            if (pb.Image != null)
            {
                updatedTextBox = int.Parse(txtbox.Text) + 1;
                txtbox.Text = updatedTextBox.ToString();
                pb.Image = null;
            }
        }

        private void pb00_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb00);
        }
        private void pb00_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb00);
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb01);
        }
        private void pb01_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb01);
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb02);
        }
        private void pb02_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb02);
        }

        private void pb03_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb03);
        }
        private void pb03_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb03);
        }

        private void pb04_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb04);
        }
        private void pb04_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb04);
        }

        private void pb05_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb05);
        }
        private void pb05_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb05);
        }

        private void pb06_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb06);
        }
        private void pb06_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb06);
        }

        private void pb07_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb07);
        }
        private void pb07_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb07);

        }

        private void pb10_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb10);
        }
        private void pb10_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb10);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb11);
        }
        private void pb11_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb11);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb12);
        }
        private void pb12_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb12);
        }

        private void pb13_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb13);
        }
        private void pb13_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb13);
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb14);
        }
        private void pb14_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb14);
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb15);
        }
        private void pb15_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb15);
        }

        private void pb16_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb16);
        }
        private void pb16_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb16);
        }

        private void pb17_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb17);
        }
        private void pb17_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb17);
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb20);
        }
        private void pb20_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb20);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb21);
        }
        private void pb21_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb21);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb22);
        }
        private void pb22_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb22);
        }

        private void pb23_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb23);
        }
        private void pb23_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb23);
        }

        private void pb24_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb24);
        }
        private void pb24_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb24);
        }

        private void pb25_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb25);
        }
        private void pb25_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb25);
        }

        private void pb26_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb26);
        }
        private void pb26_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb26);
        }

        private void pb27_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb27);
        }
        private void pb27_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb27);
        }

        private void pb30_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb30);
        }
        private void pb30_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb30);
        }

        private void pb31_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb31);
        }
        private void pb31_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb31);
        }

        private void pb32_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb32);
        }
        private void pb32_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb32);
        }

        private void pb33_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb33);
        }
        private void pb33_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb33);
        }

        private void pb34_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb34);
        }
        private void pb34_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb34);
        }

        private void pb35_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb35);
        }
        private void pb35_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb35);
        }

        private void pb36_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb36);
        }
        private void pb36_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb36);
        }

        private void pb37_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb37);
        }
        private void pb37_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb37);
        }

        private void pb40_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb40);
        }
        private void pb40_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb40);
        }

        private void pb41_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb41);
        }
        private void pb41_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb41);
        }

        private void pb42_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb42);
        }
        private void pb42_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb42);
        }

        private void pb43_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb43);
        }
        private void pb43_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb43);
        }

        private void pb44_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb44);
        }
        private void pb44_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb44);
        }

        private void pb45_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb45);
        }
        private void pb45_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb45);
        }

        private void pb46_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb46);
        }
        private void pb46_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb46);
        }

        private void pb47_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb47);
        }
        private void pb47_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb47);
        }

        private void pb50_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb50);
        }
        private void pb50_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb50);
        }

        private void pb51_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb51);
        }
        private void pb51_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb51);
        }

        private void pb52_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb52);
        }
        private void pb52_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb52);
        }

        private void pb53_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb53);
        }
        private void pb53_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb53);
        }

        private void pb54_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb54);
        }
        private void pb54_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb54);
        }

        private void pb55_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb55);
        }
        private void pb55_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb55);
        }

        private void pb56_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb56);
        }
        private void pb56_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb56);
        }

        private void pb57_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb57);
        }
        private void pb57_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb57);
        }

        private void pb60_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb60);
        }
        private void pb60_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb60);
        }

        private void pb61_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb61);
        }
        private void pb61_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb61);
        }

        private void pb62_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb62);
        }
        private void pb62_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb62);
        }

        private void pb63_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb63);
        }
        private void pb63_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb63);
        }

        private void pb64_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb64);
        }
        private void pb64_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb64);
        }

        private void pb65_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb65);
        }
        private void pb65_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb65);
        }

        private void pb66_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb66);
        }
        private void pb66_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb66);
        }

        private void pb67_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb67);
        }
        private void pb67_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb67);
        }

        private void pb70_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb70);
        }
        private void pb70_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb70);
        }

        private void pb71_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb71);
        }
        private void pb71_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb71);
        }

        private void pb72_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb72);
        }
        private void pb72_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb72);
        }

        private void pb73_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb73);
        }
        private void pb73_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb73);
        }

        private void pb74_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb74);
        }
        private void pb74_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb74);
        }

        private void pb75_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb75);
        }
        private void pb75_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb75);
        }

        private void pb76_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb76);
        }
        private void pb76_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb76);
        }

        private void pb77_Click(object sender, EventArgs e)
        {
            ValidatorClick(pb77);
        }
        private void pb77_DoubleClick(object sender, EventArgs e)
        {
            ValidatorDoubleClick(pb77);
        }

        private void btnCheckSolution_Click(object sender, EventArgs e)
        {
            if (txtbox.Text != "0")
            {
                MessageBox.Show("You didn't place all the queens!");
            }
            else
            {
                if (CheckSolution(Board))
                {
                    if (MessageBox.Show("Congratulations, you found one of the solution of N queen game! \n Do you want to play again ?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Form1 form = new Form1();
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, your solution is not correct!");
                }
            }

        }

        public int N = 8;
        public bool CheckSolution(int[,] board)
        {//Row check
            for (int i = 0; i < N; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum = sum + board[i, j];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //Main diagonal check
            //above
            for (int i = 0, j = N - 2; j >= 0; j--)
            {
                int sum = 0;
                for (int p = i, q = j; q < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //below
            for (int i = 1, j = 0; i < N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //Minor diagonal check
            //above
            for (int i = 0, j = 1; j < N; j++)
            {
                int sum = 0;
                for (int p = i, q = j; q >= 0; p++, q--)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //below
            for (int i = 1, j = N - 1; i < N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < N; p++, q--)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
