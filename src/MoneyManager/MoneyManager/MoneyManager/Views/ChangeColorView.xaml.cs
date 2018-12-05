using System;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyManager.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeColorView : PopupPage
	{
		public ChangeColorView()
		{
			InitializeComponent ();
		}

        private void OnCloseButtonTapped(object sender, EventArgs e)
        {
            CloseAllPopup();
        }

        protected override bool OnBackgroundClicked()
        {
            CloseAllPopup();

            return false;
        }

        private async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }

        private void ChangeColorButton_OnClicked(object sender, EventArgs e)
        {
            App.CustomColor.ChangeCustomColor(ColorPicker.SelectedIndex);
            CloseAllPopup();
        }
    }   
}