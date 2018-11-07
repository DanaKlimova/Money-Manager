using System;
using MoneyManager.DAL;
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

            MainPage = new NavigationPage(new MainView());
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
