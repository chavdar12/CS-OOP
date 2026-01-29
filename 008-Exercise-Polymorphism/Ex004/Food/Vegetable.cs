namespace Ex004.Food;

public class Vegetable : Food
{
    public Vegetable(int quantity) : base(quantity)
    {
    }

    public override int Quantity { get; set; }
}