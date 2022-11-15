using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private static string step = "O";
        private static string[] moves = new string[9]{"","","","","","","","",""};
        public Form2()
        {
            ResetMoves();
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void ResetMoves()
        {
            for (int i = 0; i < 9; i++)
            {
                moves[i] = "";
            }

        }
        
        public void Display()
        {
            if(step.Equals("X"))
            {
                displayTurn.Text="O's turn";
            }
            else
            {
                displayTurn.Text="X's turn";
            }
        }
        private bool WinCondition()
        {
            if (moves[0] == moves[4] && moves[4] == moves[8] && !moves[4].Equals(""))
            {
                return true;
            }
            if (moves[0] == moves[1] && moves[1] == moves[2] && !moves[1].Equals("") )
            {
                return true;
            }
            if (moves[0] == moves[3] && moves[3] == moves[6] && !moves[3].Equals(""))
            {
                return true;
            }
            if (moves[3] == moves[4] && moves[4] == moves[5] && !moves[4].Equals(""))
            {
                return true;
            }
            if (moves[6] == moves[7] && moves[7] == moves[8] && !moves[7].Equals(""))
            {
                return true;
            }
            if (moves[1] == moves[4] && moves[4] == moves[7] && !moves[4].Equals(""))
            {
                return true;
            }
            if (moves[2] == moves[5] && moves[5] == moves[8] && !moves[5].Equals(""))
            {
                return true;
            }
            if (moves[2] == moves[4] && moves[4] == moves[6] && !moves[4].Equals(""))
            {
                return true;
            }

            return false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button1.Text.Equals(""))
            {
                this.button1.ForeColor = Color.Green;
                this.button1.Text = @"O";
                step = "O";
                moves[0] = "O";
            }
            else if (step.Equals("O") && this.button1.Text.Equals(""))
            {
                this.button1.ForeColor = Color.Red;
                this.button1.Text = @"X";
                step = "X";
                moves[0] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button2.Text.Equals(""))
            {
                this.button2.ForeColor = Color.Green;
                this.button2.Text = @"O";
                step = "O";
                moves[1] = "O";
            }
            else if (step.Equals("O") && this.button2.Text.Equals(""))
            {
                this.button2.ForeColor = Color.Red;
                this.button2.Text = @"X";
                step = "X";
                moves[1] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button3.Text.Equals(""))
            {
                this.button3.ForeColor = Color.Green;
                this.button3.Text = @"O";
                step = "O";
                moves[2] = "O";
            }
            else if (step.Equals("O") && this.button3.Text.Equals(""))
            {
                this.button3.ForeColor = Color.Red;
                this.button3.Text = @"X";
                step = "X";
                moves[2] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button4.Text.Equals(""))
            {
                this.button4.ForeColor = Color.Green;
                this.button4.Text = @"O";
                step = "O";
                moves[3] = "O";
            }
            else if (step.Equals("O") && this.button4.Text.Equals(""))
            {
                this.button4.ForeColor = Color.Red;
                this.button4.Text = @"X";
                step = "X";
                moves[3] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button5.Text.Equals(""))
            {
                this.button5.ForeColor = Color.Green;
                this.button5.Text = @"O";
                step = "O";
                moves[4] = "O";
            }
            else if (step.Equals("O") && this.button5.Text.Equals(""))
            {
                this.button5.ForeColor = Color.Red;
                this.button5.Text = @"X";
                step = "X";
                moves[4] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button6.Text.Equals(""))
            {
                this.button6.ForeColor = Color.Green;
                this.button6.Text = @"O";
                step = "O";
                moves[5] = "O";
            }
            else if (step.Equals("O") && this.button6.Text.Equals(""))
            {
                this.button6.ForeColor = Color.Red;
                this.button6.Text = @"X";
                step = "X";
                moves[5] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button7.Text.Equals(""))
            {
                this.button7.ForeColor = Color.Green;
                this.button7.Text = @"O";
                step = "O";
                moves[6] = "O";
            }
            else if (step.Equals("O") && this.button7.Text.Equals(""))
            {
                this.button7.ForeColor = Color.Red;
                this.button7.Text = @"X";
                step = "X";
                moves[6] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button8.Text.Equals(""))
            {
                this.button8.ForeColor = Color.Green;
                this.button8.Text = @"O";
                step = "O";
                moves[7] = "O";
            }
            else if (step.Equals("O") && this.button8.Text.Equals(""))
            {
                this.button8.ForeColor = Color.Red;
                this.button8.Text = @"X";
                step = "X";
                moves[7] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.Font = new Font("Arial", 72, FontStyle.Bold );
            if (step.Equals("X") && this.button9.Text.Equals(""))
            {
                this.button9.ForeColor = Color.Green;
                this.button9.Text = @"O";
                step = "O";
                moves[8] = "O";
            }
            else if (step.Equals("O") && this.button9.Text.Equals(""))
            {
                this.button9.ForeColor = Color.Red;
                this.button9.Text = @"X";
                step = "X";
                moves[8] = "X";
            }
            if (WinCondition() == true)
            {
                MessageBox.Show(@"Game over");
                ResetMoves();
            };
            Display();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ResetMoves();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        
        
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}