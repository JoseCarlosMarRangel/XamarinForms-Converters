using System;
using System.Globalization;
using Xamarin.Forms;

namespace ConverterEjemplo 
{
    public class EnanleButtonByEdad : IValueConverter
    {
        // ! Metodo que convierte el valor entregando el resultado y que recibe 4 parametros
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            string text = $"{value}";
            if (!string.IsNullOrEmpty(text))
            {
                if (int.Parse(text) >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
