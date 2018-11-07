using System;
using Xamarin.Forms;

namespace MoneyManager.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            MinusImage.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(MinusTap)
            });
            PlusImage.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(PlusTap)
            });

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ListOfCashVoucherButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CashVoucherView());
        }

        private void MainButton_OnClicked(object sender, EventArgs e)
        {
        }

        private async void SettingsButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsView());
        }

        private void MinusTap()
        {
        }

        private void PlusTap()
        {
        }
    }
}
