namespace Ex001;

public class Hacker
{
    public string username = "securityGod82";

    private string password = "mySuperSecretPassw0rd";

    public Hacker()
    {
    }

    public Hacker(double bankAccountBalance)
    {
        BankAccountBalance = bankAccountBalance;
    }

    public string Password
    {
        get => password;
        set => password = value;
    }

    private int Id { get; set; }

    private double BankAccountBalance { get; set; }
}