using MoneyManager.DAL.Models;
using MoneyManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoneyManager.Controllers
{
    public class CashVoucherController : INotifyPropertyChanged
    {
        private List<CashVoucherViewModel> _cashVouchers;

        public List<CashVoucherViewModel> CashVouchers
        {
            get => _cashVouchers;
            set
            {
                if (_cashVouchers != value)
                {
                    _cashVouchers = value;
                    _cashVouchers.Reverse();
                    OnPropertyChanged();
                }
            }
        }

        public CashVoucherController()
        {
            InitCashVouchers();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitCashVouchers()
        {
            _cashVouchers = new List<CashVoucherViewModel>();
            var cashVouchers = App.Database.GetAllCashVouchers().ToList();
            foreach (var cashVoucher in cashVouchers)
            {
                _cashVouchers.Add(new CashVoucherViewModel()
                {
                    Category = cashVoucher.Category.Name,
                    //Date = cashVoucher.Date.ToShortDateString(),
                    Date = cashVoucher.Date.ToString("dd MMMM h:mm tt"),
                    Amount = cashVoucher.Type ? $"+{cashVoucher.Amount}" : $"-{cashVoucher.Amount}"
                });
            }
            _cashVouchers.Reverse();
        }
    }
}
