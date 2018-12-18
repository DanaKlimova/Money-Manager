using MoneyManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoneyManager.Controllers
{
    public class AddCashVoucherController : INotifyPropertyChanged
    {
        private string _enterAmount;
        private string _enterCategory;
        private string _buttonText;
        private ObservableCollection<string> _categoryList;

        public string EnterAmountText
        {
            get => _enterAmount;
            set
            {
                if (_enterAmount != value)
                {
                    _enterAmount = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EnterCategoryText
        {
            get => _enterCategory;
            set
            {
                if (_enterCategory != value)
                {
                    _enterCategory = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ButtonText
        {
            get => _buttonText;
            set
            {
                if (_buttonText != value)
                {
                    _buttonText = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<string> CategoryList
        {
            get => _categoryList;
            set
            {
                if (_categoryList != value)
                {
                    _categoryList = value;
                    OnPropertyChanged();
                }
            }
        }

        public AddCashVoucherController()
        {
            InitValues();
        }

        public void AddCategory(string category)
        {
           _categoryList.Add(category);
           //_categoryList.Insert(0, category);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitValues()
        {
            _enterAmount = "Введите сумму";
            _enterCategory = "Выберите категорию";
            _buttonText = "Добавить";
            _categoryList = new ObservableCollection<string>();
            IEnumerable<Category> categories = App.Database.GetAllCategories();
            foreach (var category in categories)
            {
                _categoryList.Add(category.Name);
            }
            _categoryList.Add("Добавить категорию");
            //_categoryList.Reverse();
        }
    }
}
