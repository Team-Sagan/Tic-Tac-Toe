namespace Tic_Tack_Toe.Interfaces
{
    using System.Collections.Generic;

    public interface IMultiPlayerUserSetUpModel
    {
        string FirstPlayerName { get; set; }

        string FirstPlayerSymbol { get; set; }

        string SecondPlayerName { get; set; }

        string SecondPlayerSymbol { get; set; }

        IList<string> GetFirstPlayerAvaliableSymbols();

        IList<string> GetSecondPlayerAvaliableSymbols();

        void ValidatePlayerName(string name);

        void ValidatePlayerSymbol(string symbol);
    }
}