using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_07
{
    internal class PersonFixPay : Person
    {
        public double MonthPay { get; set; }
        public double PercentagePay { get; set; }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("Input pay: ");
            MonthPay = double.Parse(Console.ReadLine());

            Console.WriteLine("Input percent of month pay: ");
            PercentagePay = double.Parse(Console.ReadLine());
        }
        public PersonFixPay(string fn, string sn, char s, double sal, int p) : base(fn, sn, s) 
        {
            MonthPay = sal;
            PercentagePay = p; 
        }

        public override string ToString()
        {
            return base.ToString() + " " + MonthPay + " " + PercentagePay + " " + MonthPay + " " + PercentagePay;
        }
        public virtual double SumPay()
        {
            double SumOfPay = MonthPay * PercentagePay / 100 + MonthPay;
            return SumOfPay;
        }

        public double TaxPay()
        {
            double TaxOfPay = SumPay() * 0.13 ;
            return TaxOfPay;
        }


        public double FinalPay()
        {
            double FinalPay = SumPay() - TaxPay();
            return FinalPay;
        }



    }
}
