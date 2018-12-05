using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyManager.Models
{
    public class CustomColor : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Color _backgroundColor;
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged(nameof(BackgroundColor));
            }
        }

        private Color _borderColor;
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                OnPropertyChanged(nameof(BorderColor));
            }
        }

        public void Init()
        {
            BackgroundColor = Color.FromHex("#D05BFF");
            BorderColor = Color.FromHex("#5c2572");
        }
        

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ChangeCustomColor(int color)
        {
            switch (color)
            {
                case 0: //красный
                    {
                    BackgroundColor = Color.FromHex("#ea422c");
                    BorderColor = Color.FromHex("#a3392c");
                    break;
                }
                case 1: //оранжевый
                    {
                    BackgroundColor = Color.FromHex("#f2862e");
                    BorderColor = Color.FromHex("#b75607");
                    break;
                }
                case 2: //желтый
                    {
                    BackgroundColor = Color.FromHex("#f4ee44");
                    BorderColor = Color.FromHex("#a8a328");
                    break;
                }
                case 3: //зеленый
                    {
                    BackgroundColor = Color.FromHex("#1ab243"); ;
                    BorderColor = Color.FromHex("#177c33"); ;
                    break;
                }
                case 4: //голубой
                    {
                    BackgroundColor = Color.FromHex("#31c7ed"); ;
                    BorderColor = Color.FromHex("#1d778e"); ;
                    break;
                }
                case 5: //синий
                    {
                    BackgroundColor = Color.FromHex("#1e29ed"); ;
                    BorderColor = Color.FromHex("#222784"); ;
                    break;
                }
                case 6: //фиолетовый
                    {
                    BackgroundColor = Color.FromHex("#D05BFF");
                    BorderColor = Color.FromHex("#5c2572");
                    break;
                }
            }

        }
    }
}
