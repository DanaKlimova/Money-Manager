using MoneyManager.Controllers;
using MoneyManager.DAL.Models;
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
    public partial class AddCashVoucherView : ContentPage
    {
        private bool _type;
        private readonly AddCashVoucherController _addCashVoucherController;

        public AddCashVoucherView(bool type)
        {
            InitializeComponent();
            _type = type;
            NavigationPage.SetHasNavigationBar(this, false);            
            _addCashVoucherController = new AddCashVoucherController();
            BindingContext = _addCashVoucherController;
            CategoryPicker.SelectedIndex = 0;
        }

        private void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is Picker picker)
            {
                var item = picker.Items[picker.SelectedIndex];
                if (item == "Добавить категорию")
                {
                    PopupNavigation.Instance.PushAsync(new AddCategoryView(_addCashVoucherController.AddCategory));
                }
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var amount = Convert.ToInt32(CashEntry.Text);
                var category = (string)CategoryPicker.SelectedItem;

                if (category == "Добавить категорию" || amount == 0)
                {
                    await DisplayAlert("Внимание", "Данные введены неверно", "ОК");
                }
                else
                {
                    var cashVoucher = new CashVoucher()
                    {
                        Amount = amount,
                        Date = DateTime.Now,
                        Type = _type
                    };
                    var categ = App.Database.GetCategoryByName(category);
                    categ.CashVoucher = cashVoucher;
                    cashVoucher.Category = categ;
                    App.Database.AddCashVoucher(cashVoucher);
                    await DisplayAlert("", "Чек добавлен", "ОK");
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Внимание", "Данные введены неверно", "ОК");
            }
            
        }
    }
}