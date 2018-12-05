using System;
using MoneyManager.DAL;
using MoneyManager.Models;
using MoneyManager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MoneyManager
{
    public partial class App : Application
    {
        private static string DatabaseFileName = "db.db";
        private static Database _db;

        public static CustomFontSize CustomFontSize { get; private set; }
        public static CustomColor CustomColor { get; private set; }

        public static Database Database
        {
            get
            {
                if (_db == null)
                {
                    _db = new Database(DatabaseFileName);
                }

                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            CustomFontSize = new CustomFontSize();
            CustomFontSize.PropertyChanged += CustomFontSize_PropertyChanged;
            CustomFontSize.Init();
            CustomColor = new CustomColor();
            CustomColor.PropertyChanged += CustomColor_PropertyChanged;
            CustomColor.Init();
            try
            {
                MainPage = new NavigationPage(new MainView());
            }
            catch(Exception ex)
            {

            }
            
        }

        private void CustomFontSize_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CustomFontSize.FontSize))
            {
                Resources["FontSize"] = CustomFontSize.FontSize;
            }
        }

        private void CustomColor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CustomColor.BackgroundColor))
            {
                Resources["AppBackground"] = CustomColor.BackgroundColor;
            }
            if (e.PropertyName == nameof(CustomColor.BorderColor))
            {
                Resources["AppBorder"] = CustomColor.BorderColor;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
