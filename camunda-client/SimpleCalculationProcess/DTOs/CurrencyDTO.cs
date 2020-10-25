using System;
using System.Collections.Generic;
using System.Text;

namespace CamundaClientTest
{
    class CurrencyDTO
    {
        public String Code, Symbol, ThousandSeparator, DecimalSeparator;
        public bool SymbolOnLeft, SpaceBetweenAmountANdSymbol;
        public int RoundingCoefficient, DecimalDigits;

        public CurrencyDTO(string code, string symbol, string thousandSeparator, string decimalSeparator, bool symbolOnLeft, bool spaceBetweenAmountANdSymbol, int roundingCoefficient, int decimalDigits)
        {
            Code = code;
            Symbol = symbol;
            ThousandSeparator = thousandSeparator;
            DecimalSeparator = decimalSeparator;
            SymbolOnLeft = symbolOnLeft;
            SpaceBetweenAmountANdSymbol = spaceBetweenAmountANdSymbol;
            RoundingCoefficient = roundingCoefficient;
            DecimalDigits = decimalDigits;
        }
    }
}
