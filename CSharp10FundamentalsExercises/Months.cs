using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public static string GetMonthName(int number)
    {
        if (Enum.IsDefined(typeof(Months), number))
        {
            Months month = (Months)number;
            return month.ToString();
        }

        throw new ArgumentException("Invalid month number.");
    }
}
