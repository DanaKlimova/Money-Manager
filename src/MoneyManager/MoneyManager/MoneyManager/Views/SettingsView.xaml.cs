using MoneyManager.Models;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyManager.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsView : ContentPage
	{
        public SettingsView ()
		{
			InitializeComponent ();
		    NavigationPage.SetHasNavigationBar(this, false);
        }

	    private async void ListOfCashVoucherButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new CashVoucherView());
	    }

	    private async void MainButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PopToRootAsync();
        }

	    private void SettingsButton_OnClicked(object sender, EventArgs e)
	    {
	    }

        private async void ChangeFontButton_OnClicked(object sender, EventArgs e)
        { 
            await PopupNavigation.Instance.PushAsync(new ChangeFontView());                
        }

        private async void ChangeColorButton_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new ChangeColorView());
        }

        private async void AboutButton_OnClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new About());
        }
    }
}