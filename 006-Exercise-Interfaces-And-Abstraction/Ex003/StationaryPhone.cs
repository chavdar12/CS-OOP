using Ex003;

public class StationaryPhone : ICalling
{
    public string Call(string number)
    {
        if (number.All(char.IsDigit)) return $"Dialing... {number}";

        return "Invalid number!";
    }
}