using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MoneyManager.Models
{
    public class CustomFontSize : INotifyPropertyChanged
    {
        private double _fontSize;
        public double FontSize {
            get { return _fontSize;  }
            set
            {
                _fontSize = value;
                OnPropertyChanged(nameof(FontSize));
            }
        }

        public void Init()
        {
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Element));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ToSmall()
        {
            FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Element));
        }

        public void ToMedium()
        {
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Element));
        }

        public void ToLarge()
        {
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Element));
        }
    }
}
