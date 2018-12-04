﻿using System;
using MoneyManager.Models;
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
            InitializeComponent();
        }

        private void FontSizePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FontSizePicker.SelectedIndex)
            {
                case 0:
                    {
                        App.CustomFontSize.ToSmall();
                        break;
                    }
                case 1:
                    {
                        App.CustomFontSize.ToMedium();
                        break;
                    }
                case 2:
                    {
                        App.CustomFontSize.ToLarge();
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