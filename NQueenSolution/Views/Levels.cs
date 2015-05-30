using NQueenSolution.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueenSolution
{
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MainContentForm form = new MainContentForm();
            this.Hide();
            if (rbtn5x5.Checked)
            {
                form.DrawBoard5();
                form.ShowLeftQueens(rbtn5x5);
                ShowRules(rbtn5x5);
            }
            else if (rbtn6x6.Checked)
            {
                form.DrawBoard6();
                form.ShowLeftQueens(rbtn6x6);
                ShowRules(rbtn6x6);
            }
            else if (rbtn7x7.Checked)
            {
                form.DrawBoard7();
                form.ShowLeftQueens(rbtn7x7);
                ShowRules(rbtn7x7);
            }
            else
            {
                form.DrawBoard8();
                form.ShowLeftQueens(rbtn8x8);
                ShowRules(rbtn8x8);
            }
            form.ShowDialog();
            this.Close();
        }

        public void ShowRules(RadioButton btn)
        {
            int n = btn.Name[6] - '0';
            MessageBox.Show("Rules are simple! \nPlace " + n + " chess queens on an " + n + " x " + n + " chessboard so that no two queens threaten each other.");
        }

    }
}
