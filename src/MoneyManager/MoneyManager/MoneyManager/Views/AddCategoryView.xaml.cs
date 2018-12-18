using Rg.Plugins.Popup.Pages;
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
	public partial class AddCategoryView : PopupPage
	{
        private Action<string> _addCategory;

		public AddCategoryView (Action<string> addCategory)
		{
			InitializeComponent ();
            _addCategory = addCategory;
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            var check = CategoryEntry.Text;
            if (CategoryEntry.Text != null)
            {
                var category = CategoryEntry.Text;
                if (!String.IsNullOrEmpty(category.Trim()))
                {
                    App.Database.AddCategory(new DAL.Models.Category()
                    {
                        Name = category
                    });
                    _addCategory(category);
                }
                DisplayAlert("", "Категория добавлена", "ОK");
                CloseAllPopup();
            }
            else
            {
                DisplayAlert("", "Данные введены некорректно", "ОK");
                CloseAllPopup();
            }

        }
    }
}