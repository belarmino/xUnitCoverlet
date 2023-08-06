using System.Text.RegularExpressions;

namespace xUnitCoverletLib;
public class Numbers
{
    public static bool IsValid(String checkNumer)
    {
        if (!IsNumber(checkNumer))
        {
            return false;
        }
        if (checkNumer.Trim().Length > 10)
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
