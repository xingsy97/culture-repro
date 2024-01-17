using System;
using System.Globalization;

public class SamplesCultureInfo
{
    public static void Main()
    {
        Console.WriteLine(".NET Version: " + Environment.Version);

        CultureInfo validCultureInfo = new CultureInfo("en-US", false);
        Console.WriteLine("Valid Culture = " + validCultureInfo.Name);

        // SHOULD throw exception. Ref https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.-ctor?view=net-8.0&viewFallbackFrom=dotnet-aspire-8.0#system-globalization-cultureinfo-ctor(system-string)
        CultureInfo invalidCultureInfo = new CultureInfo("123", false);
        Console.WriteLine("Invalid Culture = " + invalidCultureInfo.Name);
    }
}