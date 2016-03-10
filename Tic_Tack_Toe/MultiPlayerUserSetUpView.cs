namespace Tic_Tack_Toe
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Tic_Tack_Toe.Exceptions;
    using Tic_Tack_Toe.Interfaces;
    using Tic_Tack_Toe.Models;
    using Tic_Tack_Toe.Presenters;

    public partial class MultiPlayerUserSetUpView : Form, IMultiPlayerUserSetUpView
    {
        private IMultiPlayerUserSetUpPresenter presenter;

        public MultiPlayerUserSetUpView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.presenter = new MultiPlayerUserSetUpPresenter(new MultiPlayerUserSetUpModel(), this);
        }

        public event EventHandler FirstPlayerNameEntered;

        public event EventHandler FirstPlayerSymbolClicked;

        public event EventHandler FirstPlayerSymbolSelected;

        public event EventHandler SecondPlayerNameEntered;

        public event EventHandler SecondPlayerSymbolClicked;

        public event EventHandler SecondPlayerSymbolSelected;

        public string FirstPlayerName { get; set; }

        public string FirstPlayerSymbol { get; set; }

        public string SecondPlayerName { get; set; }

        public string SecondPlayerSymbol { get; set; }

        public IList<string> SymbolsList { get; set; }

        public void OnFirstPlayerNameEntered()
        {
            if (this.FirstPlayerNameEntered != null)
            {
                this.FirstPlayerNameEntered(this, System.EventArgs.Empty);
            }
        }

        public void OnFirstPlayerSymbolClicked()
        {
            if (this.FirstPlayerSymbolClicked != null)
            {
                this.FirstPlayerSymbolClicked(this, System.EventArgs.Empty);
            }
        }

        public void OnFirstPlayerSymbolSelected()
        {
            if (this.FirstPlayerSymbolSelected != null)
            {
                this.FirstPlayerSymbolSelected(this, System.EventArgs.Empty);
            }
        }

        public void OnSecondPlayerNameEntered()
        {
            if (this.SecondPlayerNameEntered != null)
            {
                this.SecondPlayerNameEntered(this, System.EventArgs.Empty);
            }
        }

        public void OnSecondPlayerSymbolClicked()
        {
            if (this.SecondPlayerSymbolClicked != null)
            {
                this.SecondPlayerSymbolClicked(this, System.EventArgs.Empty);
            }
        }

        public void OnSecondPlayerSymbolSelected()
        {
            if (this.SecondPlayerSymbolSelected != null)
            {
                this.SecondPlayerSymbolSelected(this, System.EventArgs.Empty);
            }
        }

        private void ButtonBackClicked(object sender, System.EventArgs e)
        {
            this.Hide();
            var menu = new GameEntry();
            menu.ShowDialog();
            this.Close();
        }

        private void ButtonExitClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ButtonPlayClicked(object sender, System.EventArgs e)
        {
            if (this.IsUserInputValid())
            {
                this.Hide();
                var multyPlayer =
                    new MultiPlayerGameBoardView(
                        new HumanPlayer(this.FirstPlayerName, this.FirstPlayerSymbol), 
                        new HumanPlayer(this.SecondPlayerName, this.SecondPlayerSymbol));
                multyPlayer.ShowDialog();
                this.Close();
            }
        }

        private void ComboBoxFirstPlayerSymbolClicked(object sender, System.EventArgs e)
        {
            this.OnFirstPlayerSymbolClicked();
            var clickedBox = (ComboBox)sender;
            clickedBox.DataSource = this.SymbolsList;
        }

        private void ComboBoxFirstPlayerSymbolSelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedBox = (ComboBox)sender;
            this.FirstPlayerSymbol = (string)selectedBox.SelectedItem;
            this.SetFirstPlayerSymbol();
        }

        private void ComboBoxSecondPlayerSymbolClicked(object sender, System.EventArgs e)
        {
            this.OnSecondPlayerSymbolClicked();
            var clickedBox = (ComboBox)sender;
            clickedBox.DataSource = this.SymbolsList;
        }

        private void ComboBoxSecondPlayerSymbolSelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedBox = (ComboBox)sender;
            this.SecondPlayerSymbol = (string)selectedBox.SelectedItem;
            this.SetSecondPlayerSymbol();
        }

        private bool IsUserInputValid()
        {
            var firstName = this.SetFirstPlayerName();
            var firstSymbol = this.SetFirstPlayerSymbol();
            var secondName = this.SetSecondPlayerName();
            var secondSymbol = this.SetSecondPlayerSymbol();
            if (firstName && firstSymbol && secondName && secondSymbol)
            {
                return true;
            }

            return false;
        }

        private void MultiPlayerUserSetUpViewLoad(object sender, System.EventArgs e)
        {
            this.lblFirstSymbolErr.Visible = false;
            this.lblSecondSymbolErr.Visible = false;
            this.llbFirstPlayerNameErr.Visible = false;
            this.lblSecondPlayerNameErr.Visible = false;
        }

        private bool SetFirstPlayerName()
        {
            try
            {
                this.OnFirstPlayerNameEntered();
                this.llbFirstPlayerNameErr.Visible = false;
                return true;
            }
            catch (InvalidPlayerNameException)
            {
                this.txtFirstPlayerName.Focus();
                this.llbFirstPlayerNameErr.Visible = true;
            }

            return false;
        }

        private bool SetFirstPlayerSymbol()
        {
            try
            {
                this.OnFirstPlayerSymbolSelected();
                this.lblFirstSymbolErr.Visible = false;
                return true;
            }
            catch (InvalidPlayerSymbolException)
            {
                this.comboBoxFirstPlayerSymbol.Focus();
                this.lblFirstSymbolErr.Visible = true;
            }

            return false;
        }

        private bool SetSecondPlayerName()
        {
            try
            {
                this.OnSecondPlayerNameEntered();
                this.lblSecondPlayerNameErr.Visible = false;
                return true;
            }
            catch (InvalidPlayerNameException)
            {
                this.txtSecondPlayerName.Focus();
                this.lblSecondPlayerNameErr.Visible = true;
            }

            return false;
        }

        private bool SetSecondPlayerSymbol()
        {
            try
            {
                this.OnSecondPlayerSymbolSelected();
                this.lblSecondSymbolErr.Visible = false;
                return true;
            }
            catch (InvalidPlayerSymbolException)
            {
                this.comboBoxSecondPlayerSymbol.Focus();
                this.lblSecondSymbolErr.Visible = true;
            }

            return false;
        }

        private void ТxtFirstPlayerNameTextChanged(object sender, System.EventArgs e)
        {
            var textbox = (TextBox)sender;

            this.FirstPlayerName = textbox.Text;
            this.SetFirstPlayerName();
        }

        private void ТxtSecondPlayerNameTextChanged(object sender, System.EventArgs e)
        {
            var textbox = (TextBox)sender;
            this.SecondPlayerName = textbox.Text;

            this.SetSecondPlayerName();
        }
    }
}