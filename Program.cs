using System;
using System.Globalization;

public class SamplesCultureInfo
{
    public static void Main()
    {
        CultureInfo validCultureInfo = new CultureInfo("en-US", false);
        Console.WriteLine(validCultureInfo.Name);
        CultureInfo invalidCultureInfo = new CultureInfo("123", false);
        Console.WriteLine(invalidCultureInfo.Name);
    }
}