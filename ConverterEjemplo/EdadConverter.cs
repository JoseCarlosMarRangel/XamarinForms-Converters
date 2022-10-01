using System;
using System.Globalization;
using Xamarin.Forms;

namespace ConverterEjemplo 
{
    public class EdadConverter : IValueConverter
    {
        // ! Metodo que convierte el valor entregando el resultado y que recibe 4 parametros
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            string text = $"{value}";
            if (!string.IsNullOrEmpty(text))
            {
                if (int.Parse(text) >= 18)
                {
                    return "Eres mayor de edad";
                }
                else
                {
                    return "Eres menor de edad";
                }
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Empty;
        }
    }
}
