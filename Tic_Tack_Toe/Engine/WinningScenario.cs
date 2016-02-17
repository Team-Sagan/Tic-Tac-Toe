namespace Tic_Tack_Toe.Engine
{
    using Interfaces;
    using System.Windows.Forms;

    public class WinningScenario : IWinningScenario
    {
        private bool turn = true;

        public IEngine Engine { get; set; }

        public void WinMessage()
        {
            if (this.turn)
            {
                MessageBox.Show("Player O wins!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Player X wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Engine.Reset();
        }
    }
}