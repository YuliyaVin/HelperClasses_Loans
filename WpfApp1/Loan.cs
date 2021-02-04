using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
  public static  class Loan
     
    {
        public static double calculateSimpleInterestAmortizedMonthlyPayment(double Principal, double Percent, int Years) => calculateSimpleInterestAmortizedPayment(Principal, Percent, Years, 12);
        public static double calculateSimpleInterestAmortizedMonthlyYears(double Principal, double Percent, double MonthlyPayment) => calculateSimpleInterestAmortizedYears(Principal, Percent, MonthlyPayment, 12);
       

        public static double calculateSimpleInterestAmortizedPayment(double dPrincipal, double dPercent, int iYears, int iPaymentPerYear)
        {
            double R;
            R = dPercent / iPaymentPerYear;
            R =R/ 100;
            return (dPrincipal * R * Math.Pow(1 + R, iPaymentPerYear * iYears)) / (Math.Pow(1 + R, iYears * iPaymentPerYear) - 1);
        }

        public static double calculateSimpleInterestAmortizedYears(double dPrincipal, double dPercent, double dMonthlyPayment, int iPaymentPerYear)
        {
            double R;
            R = dPercent / iPaymentPerYear;
            R = R / 100;

            return (Math.Log(dMonthlyPayment/(dMonthlyPayment - dPrincipal * R), 1 + R)) / iPaymentPerYear;

        }
    }
}
