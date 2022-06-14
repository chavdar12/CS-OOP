namespace _003;

public class Hacker
{
    public string username = "securityGod82";

    public Hacker(double bankAccountBalance)
    {
        BankAccountBalance = bankAccountBalance;
    }

    public string Password { get; set; } = "mySuperSecretPassw0rd";

    private int Id { get; set; }

    private double BankAccountBalance { get; set; }
}