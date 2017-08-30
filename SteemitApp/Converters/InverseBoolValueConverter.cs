using System;
using MvvmCross.Platform.Converters;

namespace SteemitApp.Core
{
    public class InverseBoolValueConverter : MvxValueConverter<bool, bool>
    {
    	protected override bool Convert(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    	{
    		return !value;
    	}

    	protected override bool ConvertBack(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    	{
    		return !value;
        }
    }
}
