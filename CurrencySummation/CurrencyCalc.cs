using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencySummation
{
    public class CurrencyCalc
    {
        private string _transactions;
        private string[] _transactionArray;

        public CurrencyCalc(string transactions) 
        {
            _transactions = transactions;
        }

        public void ReplaceWhiteSpaces()
        {
            _transactions = _transactions.Replace(" ", "");
        }

        public void ReplaceKWithThousand()
        {
            _transactions = _transactions.Replace("k", "000");
        }

        public void ConvertToArray()
        {
            _transactionArray = _transactions.Split(',');
        }

        public int SumDollarTransactions() // "24$, 59$, 60k£, 20£, 5k$"
        {
            int intSum = 0;
            for (int i = 0; i < _transactionArray.Length; i++)
            {
                string sum = _transactionArray[i];
                for(int j = sum.Length - 1; j >= 0; j--)
                {
                    char c = sum[j];
                    if (c == '$')
                    {
                        string trimmedSum = sum.Remove(sum.Length - 1);
                        int x = Int32.Parse(trimmedSum);
                        intSum += x;
                    }
                }
            }
            return intSum;
        }
    }
}
