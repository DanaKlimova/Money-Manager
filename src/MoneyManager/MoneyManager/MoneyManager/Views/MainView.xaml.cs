using MoneyManager.Controllers;
using MoneyManager.DAL.Models;
using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyManager.Views
{
    public partial class MainView : ContentPage
    {
        private readonly MainController _mainController;

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
            _mainController = new MainController();
            BindingContext = _mainController;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _mainController.GetListOfChartData();
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

        private async void MinusTap()
        {
            await Navigation.PushAsync(new AddCashVoucherView(false));
        }

        private async void PlusTap()
        {
            await Navigation.PushAsync(new AddCashVoucherView(true));
        }
        
    }
}

//    public ChartData(string name, double amount)
//    {
//        _name = name;
//        _amount = amount;
//    }
//}

//        public static List<ChartData> GetListOfChartData()
//        {
//            List <ChartData> list= new List<ChartData>();
//            var categories = App.Database.GetAllCategories().ToList();
//            foreach (var category in categories)
//            {
//                list.Add(new ChartData(category.Name, 0));
//            }
//            List<CashVoucher> cashVouchers = App.Database.GetAllCashVouchers().ToList();
//            foreach (var cashVoucher in cashVouchers)
//            {

//            }

//            //IEnumerable<Category, CashVoucher> 
//            var k = cashVouchers.GroupBy(c => c.Category, (key, values) => new { Name = key.Name, Sum = values.Sum(x => x.Amount) });
//            foreach(var a in k)
//            {
//                Console.WriteLine(a.Name, a.Sum);
//            }


//            return list;
//        }
//    }
//}
