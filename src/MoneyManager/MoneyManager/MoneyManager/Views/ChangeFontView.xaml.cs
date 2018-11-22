using System;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangeFontView : PopupPage
	{
		public ChangeFontView ()
		{
		}

        private void FontSizePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FontSizePicker.SelectedIndex)
            {
                case 0:
                    {
                        App.Current.Resources["Style.ButtonFontStyle"] = Device.GetNamedSize(NamedSize.Small, typeof(Button));
                        App.Current.Resources["Style.EntryFontStyle"] = Device.GetNamedSize(NamedSize.Small, typeof(Entry));
                        App.Current.Resources["Style.PickerFontStyle"] = Device.GetNamedSize(NamedSize.Small, typeof(Picker));
                        App.Current.Resources["Style.LabelFontSize"] = Device.GetNamedSize(NamedSize.Small, typeof(Label));
                        break;
                    }
                case 1:
                    {
                        App.Current.Resources["Style.ButtonFontStyle"] = Device.GetNamedSize(NamedSize.Medium, typeof(Button));
                        App.Current.Resources["Style.EntryFontStyle"] = Device.GetNamedSize(NamedSize.Medium, typeof(Entry));
                        App.Current.Resources["Style.PickerFontStyle"] = Device.GetNamedSize(NamedSize.Medium, typeof(Picker));
                        App.Current.Resources["Style.LabelFontSize"] = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
                        break;
                    }
                case 2:
                    {
                        App.Current.Resources["Style.ButtonFontStyle"] = Device.GetNamedSize(NamedSize.Large, typeof(Button));
                        App.Current.Resources["Style.EntryFontStyle"] = Device.GetNamedSize(NamedSize.Large, typeof(Entry));
                        App.Current.Resources["Style.PickerFontStyle"] = Device.GetNamedSize(NamedSize.Large, typeof(Picker));
                        App.Current.Resources["Style.LabelFontSize"] = Device.GetNamedSize(NamedSize.Large, typeof(Label));
                        break;
                    }
            }
            
            CloseAllPopup();
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
    }
}