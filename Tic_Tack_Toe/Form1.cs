namespace Tic_Tack_Toe
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int moves;

        private bool turn = true;

        public Form1()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (this.turn && btn.Text == string.Empty)
            {
                btn.Text = "X";
                this.moves++;
            }
            else if (!this.turn && btn.Text == string.Empty)
            {
                btn.Text = "O";
                this.moves++;
            }

            this.turn = !this.turn;
            if (this.moves >= 3)
            {
                this.Check();
            }
        }

        private void Check()
        {
            if (this.A1.Text.Equals(this.A2.Text) && this.A2.Text.Equals(this.A3.Text) && !this.A3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.B1.Text.Equals(this.B2.Text) && this.B2.Text.Equals(this.B3.Text) && !this.B3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.C1.Text.Equals(this.C2.Text) && this.C2.Text.Equals(this.C3.Text) && !this.C3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.A1.Text.Equals(this.B2.Text) && this.B2.Text.Equals(this.C3.Text) && !this.C3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.C1.Text.Equals(this.B2.Text) && this.B2.Text.Equals(this.A3.Text) && !this.A3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.A1.Text.Equals(this.B1.Text) && this.B1.Text.Equals(this.C1.Text) && !this.C1.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.A2.Text.Equals(this.B2.Text) && this.B2.Text.Equals(this.C2.Text) && !this.C2.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.A3.Text.Equals(this.B3.Text) && this.B3.Text.Equals(this.C3.Text) && !this.C3.Text.Equals(string.Empty))
            {
                this.WinMsg();
            }
            else if (this.moves >= 8)
            {
                MessageBox.Show("Draw!");
                this.Reset();
            }
        }

        private void Reset()
        {
            foreach (Control c in this.Controls)
            {
                var btn = (Button)c;
                btn.Text = string.Empty;
            }

            this.turn = true;
            this.moves = 0;
        }

        private void WinMsg()
        {
            if (this.turn)
            {
                MessageBox.Show("Player O wins!");
            }
            else
            {
                MessageBox.Show("Player X wins!");
            }

            this.Reset();
        }
    }
}