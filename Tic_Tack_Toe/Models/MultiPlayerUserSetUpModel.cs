namespace Tic_Tack_Toe.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Tic_Tack_Toe.Exceptions;
    using Tic_Tack_Toe.Interfaces;

    public class MultiPlayerUserSetUpModel : IMultiPlayerUserSetUpModel
    {
        private readonly IEnumerable<string> symbols;

        public MultiPlayerUserSetUpModel()
        {
            this.symbols = new List<string> { "X", "O", "@", "#", "&" };
        }

        public string FirstPlayerName { get; set; }

        public string FirstPlayerSymbol { get; set; }

        public string SecondPlayerName { get; set; }

        public string SecondPlayerSymbol { get; set; }

        public IList<string> GetFirstPlayerAvaliableSymbols()
        {
            return this.symbols.Where(symbol => symbol != this.SecondPlayerSymbol).ToList();
        }

        public IList<string> GetSecondPlayerAvaliableSymbols()
        {
            return this.symbols.Where(symbol => symbol != this.FirstPlayerSymbol).ToList();
        }

        public void ValidatePlayerName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || this.FirstPlayerName == this.SecondPlayerName)
            {
                throw new InvalidPlayerNameException();
            }
        }

        public void ValidatePlayerSymbol(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                throw new InvalidPlayerSymbolException();
            }
        }
    }
}