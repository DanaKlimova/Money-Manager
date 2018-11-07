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
	public partial class CashVoucherView : ContentPage
	{
		public CashVoucherView ()
		{
			InitializeComponent ();

		    NavigationPage.SetHasNavigationBar(this, false);
        }

	    private void ListOfCashVoucherButton_OnClicked(object sender, EventArgs e)
	    {
	    }

	    private async void MainButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PopToRootAsync();
	    }

	    private async void SettingsButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new SettingsView());
	    }
	}
}