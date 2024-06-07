using Microsoft.Maui.Controls;
using TaxApp1;

namespace TaxApp1
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double amount, string type, double taxRate)
        {
            InitializeComponent();

            double taxAmount = TaxCalc.CalculateTax(amount, type, taxRate);
            ResultLabel.Text = $"Eingegebener Betrag: {amount}\n" +
                               $"Typ: {type}\n" +
                               $"Steuersatz: {taxRate}%\n" +
                               $"Umsatzsteuerbetrag: {taxAmount}";
        }
    }
}
