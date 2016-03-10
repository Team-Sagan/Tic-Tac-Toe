namespace Tic_Tack_Toe.Presenters
{
    using System;

    using Tic_Tack_Toe.Interfaces;

    public class MultiPlayerUserSetUpPresenter : IMultiPlayerUserSetUpPresenter
    {
        private readonly IMultiPlayerUserSetUpModel model;

        private readonly IMultiPlayerUserSetUpView view;

        public MultiPlayerUserSetUpPresenter(IMultiPlayerUserSetUpModel model, IMultiPlayerUserSetUpView view)
        {
            this.model = model;
            this.view = view;
            this.SetUp();
        }

        public void SecondPlayerSymbolClicked(object sender, EventArgs e)
        {
            this.view.SymbolsList = this.model.GetSecondPlayerAvaliableSymbols();
        }

        private void FirstPlayerNameEntered(object sender, EventArgs e)
        {
            this.model.FirstPlayerName = this.view.FirstPlayerName;
            this.model.ValidatePlayerName(this.view.FirstPlayerName);
        }

        private void FirstPlayerSymbolClicked(object sender, EventArgs e)
        {
            this.view.SymbolsList = this.model.GetFirstPlayerAvaliableSymbols();
        }

        private void FirstPlayerSymbolSelected(object sender, EventArgs e)
        {
            this.model.FirstPlayerSymbol = this.view.FirstPlayerSymbol;
            this.model.ValidatePlayerSymbol(this.view.FirstPlayerSymbol);
        }

        private void SecondPlayerNameEntered(object sender, EventArgs e)
        {
            this.model.SecondPlayerName = this.view.SecondPlayerName;
            this.model.ValidatePlayerName(this.view.SecondPlayerName);
        }

        private void SecondPlayerSymbolSelected(object sender, EventArgs e)
        {
            this.model.SecondPlayerSymbol = this.view.SecondPlayerSymbol;
            this.model.ValidatePlayerSymbol(this.view.SecondPlayerSymbol);
        }

        private void SetUp()
        {
            this.view.SecondPlayerSymbolClicked += this.SecondPlayerSymbolClicked;
            this.view.FirstPlayerSymbolClicked += this.FirstPlayerSymbolClicked;
            this.view.FirstPlayerNameEntered += this.FirstPlayerNameEntered;
            this.view.FirstPlayerSymbolSelected += this.FirstPlayerSymbolSelected;
            this.view.SecondPlayerNameEntered += this.SecondPlayerNameEntered;
            this.view.SecondPlayerSymbolSelected += this.SecondPlayerSymbolSelected;
        }
    }
}