using System.IO;
using MoneyManager.DAL.Interfaces;
using Environment = System.Environment;

[assembly: Xamarin.Forms.Dependency(typeof(MoneyManager.Droid.Helpers.SQLite))]
namespace MoneyManager.Droid.Helpers
{
    public class SQLite : ISQLite
    {
        public string GetDatabasePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}