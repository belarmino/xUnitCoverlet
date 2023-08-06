using System.Text.RegularExpressions;

namespace xUnitCoverletLib;
public class Numbers
{
    public static bool IsValid(String number)
    {
        if (!IsNumber(number))
        {
            return false;
        }
        if (number.Trim().Length > 10)
        {
            return false;
        }
        return true;
    }
    public static bool IsNumber(string number)
    {
        Regex regex = new(@"^[0-9]+$", RegexOptions.None, TimeSpan.FromMilliseconds(5));
        return regex.IsMatch(number);
    }
}
