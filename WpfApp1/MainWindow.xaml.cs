using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
 

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculatePayment_Click(object sender, RoutedEventArgs e)
        {
            if (txtYears.Text != "" && txtLoanAmount.Text!="" && txtLoanRate.Text!="")
            { if (StringExtentions.IsNumeric(txtYears.Text) && StringExtentions.IsNumeric(txtLoanAmount.Text) && StringExtentions.IsNumeric(txtLoanRate.Text))
                {
                    lblMonthly_Payment.Content = Loan.calculateSimpleInterestAmortizedMonthlyPayment(double.Parse(txtLoanAmount.Text),double.Parse(txtLoanRate.Text),int.Parse(txtYears.Text));

                }
                else MessageBox.Show("Please enter correct parameters" );

            }


        }

        private void BtnCalculateNumberOfYearsLeft_Click(object sender, RoutedEventArgs e)
        {
            if (txtMonthlyPayment.Text != "" && txtCurrentLoanAmount.Text != "" && txtCurrentLoanRate.Text != "")
            {
                if (StringExtentions.IsNumeric(txtMonthlyPayment.Text) && StringExtentions.IsNumeric(txtCurrentLoanAmount.Text) && StringExtentions.IsNumeric(txtCurrentLoanRate.Text))
                {
                    lblNumberOfYearsLeft.Content = Loan.calculateSimpleInterestAmortizedMonthlyYears(double.Parse(txtCurrentLoanAmount.Text), double.Parse(txtCurrentLoanRate.Text), double.Parse(txtMonthlyPayment.Text));

                }
                else MessageBox.Show("Please enter correct parameters");

            }


        }
    }
}
