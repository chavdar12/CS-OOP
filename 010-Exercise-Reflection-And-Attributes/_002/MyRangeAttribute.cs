namespace _002;

public class MyRangeAttribute : MyValidationAttribute
{
    private int minValue;
    private int maxValue;

    public MyRangeAttribute(int minValue, int maxValue)
    {
        this.minValue = minValue;
        this.maxValue = maxValue;
    }

    public override bool IsValid(object obj)
    {
        if (!int.TryParse(obj.ToString(), out var numberToValidate)) return true;
        return numberToValidate >= minValue && numberToValidate <= maxValue;
    }
}