namespace homework_8.Classes;


public class BankTransaction
{
    readonly DateTime dateTime;
    readonly decimal amount;
    public decimal Amount { get => amount; }
    public BankTransaction(decimal amount)
    {
        dateTime = DateTime.Now;
        this.amount = amount;
    }
    
}