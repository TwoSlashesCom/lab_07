using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    internal class PersonHourPay : PersonFixPay
    {
        public int CountOfHour { get; set; }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("Input vount of work hour: ");
            CountOfHour = int.Parse(Console.ReadLine());
        }

        public PersonHourPay(string fn, string sn, char s, double sal, int p , int c) : base(fn, sn, s, sal, p)
        {
            CountOfHour = c;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double SumPay()
        {
            double SumOfPay = (MonthPay * PercentagePay / 100 + MonthPay) * CountOfHour;
            return SumOfPay;
        }


    }
}
