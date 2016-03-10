namespace Tic_Tack_Toe.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IMultiPlayerUserSetUpView
    {
        event EventHandler FirstPlayerNameEntered;

        event EventHandler FirstPlayerSymbolClicked;

        event EventHandler FirstPlayerSymbolSelected;

        event EventHandler SecondPlayerNameEntered;

        event EventHandler SecondPlayerSymbolClicked;

        event EventHandler SecondPlayerSymbolSelected;

        string FirstPlayerName { get; set; }

        string FirstPlayerSymbol { get; set; }

        string SecondPlayerName { get; set; }

        string SecondPlayerSymbol { get; set; }

        IList<string> SymbolsList { get; set; }
    }
}