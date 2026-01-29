namespace Ex004.Food;

public class Seeds : Food
{
    public Seeds(int quantity) : base(quantity)
    {
    }

    public override int Quantity { get; set; }
}