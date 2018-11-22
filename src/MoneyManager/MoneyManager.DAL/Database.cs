using System.Collections.Generic;
using System.Linq;
using MoneyManager.DAL.Interfaces;
using MoneyManager.DAL.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using Xamarin.Forms;

namespace MoneyManager.DAL
{
    public class Database
    {
        private SQLiteConnection _db;
        private readonly List<CashVoucher> _cashVouchers;
        private readonly List<Category> _categories;

        public Database(string filename)
        {
            GetConnection(filename);
            _db.CreateTable<Category>();
            _db.CreateTable<CashVoucher>();
            _cashVouchers = _db.GetAllWithChildren<CashVoucher>();
            _categories = _db.Table<Category>().ToList();
        }

        public void AddCashVoucher(CashVoucher cashVoucher)
        {
            _cashVouchers.Add(cashVoucher);
            _db.InsertWithChildren(cashVoucher);
        }

        public void AddCategory(Category category)
        {
            _categories.Add(category);
            _db.Insert(category);
        }

        public IEnumerable<CashVoucher> GetAllCashVouchers()
        {
            return _cashVouchers;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categories;
        }

        public Category GetCategoryByName(string name)
        {
            //return _categories.FirstOrDefault(x => x.Name == name);
            return _db.Table<Category>().ToList().FirstOrDefault(x => x.Name == name);
        }

        private void GetConnection(string filename)
        {
            if (_db == null)
            {
                string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
                _db =  new SQLiteConnection(databasePath);
            }
        }
    }
}
