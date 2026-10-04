using System.Text.RegularExpressions;

namespace Collections
{
    public static class StringValidationExtensions
    {
        extension(string value)
        {
            public bool IsValidEgyptianPhone()
            {
                if (string.IsNullOrWhiteSpace(value))
                    return false;

                string pattern = @"^(010|011|012|015|\+2010|\+2011|\+2012|\+2015)[0-9]{8}$";

                return Regex.IsMatch(value, pattern);
            }
            public bool IsValidEgyptianNationalId()
            {
                if (string.IsNullOrWhiteSpace(value))
                    return false;
                string pattern = @"^[23][0-9]{13}$";

                return Regex.IsMatch(value, pattern);
            }
        }
    }
}
