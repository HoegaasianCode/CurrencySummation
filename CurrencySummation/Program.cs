using System;

namespace CurrencySummation
{
    class Program
    {
        // https://edabit.com/challenge/RrPW2X9Bkbkr4FLWD
        // I misread the assignment: currency symbols occur at the end, which led
        // to an inverse loop..
        // SOLVED

        static void Main(string[] args)
        {
            CurrencyCalc sum = new("24$, 59$, 60k£, 20£, 5k$"); // -> ( 24 + 59 + 5000 ) = 5083 $
            sum.ReplaceWhiteSpaces();
            sum.ReplaceKWithThousand();
            sum.ConvertToArray();
            Console.Write(sum.SumToList());
        }
    }
}
