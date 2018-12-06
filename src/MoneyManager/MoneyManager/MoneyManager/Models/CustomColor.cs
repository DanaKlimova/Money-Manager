using System;
using System.Drawing;
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
        private Xamarin.Forms.Color _backgroundColor;
        public Xamarin.Forms.Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged(nameof(BackgroundColor));
            }
        }

        private Xamarin.Forms.Color _borderColor;
        public Xamarin.Forms.Color BorderColor
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
            BackgroundColor = new Xamarin.Forms.Color();
            //BackgroundColor = Resources["AppBackground"];
            BackgroundColor = Xamarin.Forms.Color.FromHex("#d05bff");
            BorderColor = new Xamarin.Forms.Color();
            BorderColor = Xamarin.Forms.Color.FromHex("#5c2572");
            
            //BorderColor = Resources["AppBorder"];
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
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#ea422c");
                    BorderColor = Xamarin.Forms.Color.FromHex("#a3392c");
                    break;
                }
                case 1: //оранжевый
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#f2862e");
                    BorderColor = Xamarin.Forms.Color.FromHex("#b75607");
                    break;
                }
                case 2: //желтый
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#f4ee44");
                    BorderColor = Xamarin.Forms.Color.FromHex("#a8a328");
                    break;
                }
                case 3: //зеленый
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#1ab243"); ;
                    BorderColor = Xamarin.Forms.Color.FromHex("#177c33"); ;
                    break;
                }
                case 4: //голубой
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#31c7ed"); ;
                    BorderColor = Xamarin.Forms.Color.FromHex("#1d778e"); ;
                    break;
                }
                case 5: //синий
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#1e29ed"); ;
                    BorderColor = Xamarin.Forms.Color.FromHex("#222784"); ;
                    break;
                }
                case 6: //фиолетовый
                    {
                    BackgroundColor = Xamarin.Forms.Color.FromHex("#D05BFF");
                    BorderColor = Xamarin.Forms.Color.FromHex("#5c2572");
                    break;
                }
            }

        }
    }
}
