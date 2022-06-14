using System.Linq;
using _003;

namespace Telephony;

public class StationaryPhone : ICalling
{
    public string Call(string number)
    {
        if (number.All(char.IsDigit)) return $"Dialing... {number}";

        return "Invalid number!";
    }
}