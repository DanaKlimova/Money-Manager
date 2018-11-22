using MoneyManager.Controllers;
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
        private CashVoucherController _cashVoucherController;

		public CashVoucherView ()
		{
			InitializeComponent ();

		    NavigationPage.SetHasNavigationBar(this, false);

            _cashVoucherController = new CashVoucherController();
            BindingContext = _cashVoucherController;
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