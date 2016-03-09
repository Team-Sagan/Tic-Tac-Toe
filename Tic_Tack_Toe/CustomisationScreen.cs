using System;
using System.Windows.Forms;

namespace Tic_Tack_Toe
{
    public partial class CustomisationScreen : Form
    {
        public CustomisationScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Symbols cannot be the same.", "Duplication error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Player names cannot be the same.", "Duplication error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (textBox1.Text.Equals(string.Empty) || textBox2.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter a name.", "Missing names", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
            var multyPlayer = new GameBoardView();
            multyPlayer.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var menu = new GameEntry();
            menu.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            label3.Text = String.Format("Player one selected: {0}", comboBox1.SelectedItem.ToString());
            label3.Visible = true;
        }
    }
}