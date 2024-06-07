using Microsoft.Maui.Controls;
using TaxApp1;

namespace TaxApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            double amount = double.Parse(AmountEntry.Text);
            string type = (string)TypePicker.SelectedItem;
            double taxRate = double.Parse(TaxRateEntry.Text);

            // Werte an ResultPage übergeben
            await Navigation.PushAsync(new ResultPage(amount, type, taxRate));
        }
    }
}
