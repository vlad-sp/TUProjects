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
        private List<PictureBox> pbList;
        public MainContentForm()
        {
            InitializeComponent();
            pbList = new List<PictureBox>();
        }

        public void DrawBoard(int rows)
        {
            int startX = 60;
            int startY = 50;
            int x = startX;
            int y = startY;
            int row = 0;

            for (int k = 0; k < rows * rows; k++)
            {
                pbList.Add(new PictureBox());

            }

            for (int i = 0, temp = 0; i < rows * rows; i++, temp++)
            {
                ((ISupportInitialize)(pbList[i])).BeginInit();
                pbList[i].Location = new Point(x, y);
                if (rows % 2 == 0)
                {
                    if ((row + i) % 2 == 0)
                    {
                        pbList[i].BackColor = Color.White;
                    }
                    else
                    {
                        pbList[i].BackColor = Color.Gray;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        pbList[i].BackColor = Color.White;
                    }
                    else
                    {
                        pbList[i].BackColor = Color.Gray;
                    }
                }

                pbList[i].Size = new Size(35, 35);

                pbList[i].Name = "pb" + row + temp;
                pbList[i].Click += new System.EventHandler(this.PictureBox_Click);
                pbList[i].DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
                ((ISupportInitialize)(pbList[i])).EndInit();
                this.Controls.Add(pbList[i]);

                if (temp == rows - 1)
                {
                    temp = -1;
                }
                x += 35;
                if (row == 0)
                {
                    if (i == rows - 1)
                    {
                        row++;
                        y += 35;
                        x = startX;
                    }
                }
                else
                {
                    if (i == (row + 1) * (rows) - 1)
                    {
                        row++;
                        y += 35;
                        x = startX;
                    }
                }
            }
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ValidatorDoubleClick(pb);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            ValidatorClick(pb);
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
