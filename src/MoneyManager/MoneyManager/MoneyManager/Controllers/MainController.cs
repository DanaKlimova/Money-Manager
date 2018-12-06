using MoneyManager.DAL.Models;
using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MoneyManager.Controllers
{
    public class MainController : INotifyPropertyChanged
    {
        private ObservableCollection<ChartData> _chartDataList;
        private int _selectedIndex = -1;
        private string _selectedItemName;
        private double _selectedItemsPercentage;

        public string SelectedItemName
        {
            get => _selectedItemName;
            set
            {
                _selectedItemName = value;
                OnPropertyChanged();
            }
        }
        
        public double SelectedItemsPercentage
        {
            get { return _selectedItemsPercentage; }
            set
            {
                _selectedItemsPercentage = value;
                OnPropertyChanged();
            }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                if (_selectedIndex == -1) return;

                SelectedItemName = ChartDataList[_selectedIndex].Name;

                var sum = ChartDataList.Sum(item => item.Amount);
                var selectedValue = ChartDataList[_selectedIndex].Amount;

                SelectedItemsPercentage = (selectedValue / sum) * 100;
                SelectedItemsPercentage = Math.Floor(SelectedItemsPercentage * 100) / 100;
            }
        }

        public ObservableCollection<ChartData> ChartDataList
        {
            get => _chartDataList;
            set
            {
                if (_chartDataList != value)
                {
                    _chartDataList = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainController()
        {
            GetListOfChartData();
        }

        public void GetListOfChartData()
        {
            List<CashVoucher> cashVouchers = App.Database.GetAllCashVouchers().ToList();
            var categories = App.Database.GetAllCategories().ToList();
            List<ChartData> list = new List<ChartData>();
            foreach (var category in categories)
            {
                list.Add(new ChartData() { Name = category.Name, Amount = cashVouchers
                    .Where(c => c.Category.Name == category.Name)
                    .Sum(c => c.Amount) });

            }
            
            ChartDataList = new ObservableCollection<ChartData>(list);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
