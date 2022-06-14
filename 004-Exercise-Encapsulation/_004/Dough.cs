namespace _004;

public class Dough
{
    private const string DoughExeptionMessage = "Invalid type of dough.";
    private const string WeightExeptionMessage = "Dough weight should be in the range [1..200].";

    private Dictionary<string, double> flourTypeCalories
        = new()
        {
            {"white", 1.5},
            {"wholegrain", 1.0}
        };

    private Dictionary<string, double> backingTechniqueCalories
        = new()
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    private string FlourType
    {
        get => flourType;
        init
        {
            if (!flourTypeCalories.ContainsKey(value.ToLower())) throw new ArgumentException(DoughExeptionMessage);
            flourType = value;
        }
    }

    private string BakingTechnique
    {
        get => bakingTechnique;
        init
        {
            if (!backingTechniqueCalories.ContainsKey(value.ToLower()))
                throw new ArgumentException(DoughExeptionMessage);
            bakingTechnique = value;
        }
    }

    private double Weight
    {
        get => weight;
        init
        {
            if (value is < 1 or > 200) throw new ArgumentException(WeightExeptionMessage);
            weight = value;
        }
    }

    public double Calories
        => 2 * Weight * flourTypeCalories[FlourType.ToLower()]
           * backingTechniqueCalories[BakingTechnique.ToLower()];
}