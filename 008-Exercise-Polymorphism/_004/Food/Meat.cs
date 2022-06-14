namespace _004.Food;

public class Meat : Food
{
    public Meat(int quantity) : base(quantity)
    {
    }

    public override int Quantity { get; set; }
}