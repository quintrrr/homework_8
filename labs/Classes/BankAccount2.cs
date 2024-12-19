using System.Collections;

namespace homework_8.Classes;


public class BankAccount2
{
    private static int nextAccountNumber = 1;
    private int accountNumber;
    private decimal balance;
    private AccountType accountType;
    private Queue<BankTransaction> transactions = new Queue<BankTransaction>();
    public int AccountNumber { get => accountNumber; }
    public decimal Balance { get => balance; }
    public AccountType AccountType { get => accountType; }
    
    public BankAccount2()
    {
        SetUniqueAccountNumber();
        balance = 0;
        accountType = AccountType.Current;
    }
    
    public BankAccount2(decimal balance)
    {
        SetUniqueAccountNumber();
        this.balance = balance;
        accountType = AccountType.Current;
    }
    
    public BankAccount2(AccountType accountType)
    {
        SetUniqueAccountNumber();
        balance = 0;
        this.accountType = accountType;
    }
    
    public BankAccount2(decimal balance, AccountType accountType)
    {
        SetUniqueAccountNumber();
        this.balance = balance;
        this.accountType = accountType;
    }
    
    
    

    public void SetUniqueAccountNumber()
    {
        accountNumber = nextAccountNumber++;
    }
    
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Сумма снятия должна быть больше нуля");
            return false;
        }
        if (amount > Balance)
        {
            Console.WriteLine("На счете недостаточно средств");
            return false;
        }
    
        BankTransaction transaction = new BankTransaction(amount);
        transactions.Enqueue(transaction);
        balance -= amount;
        return true;
        
    }

    public void Deposit(decimal amount)
    {
        BankTransaction transaction = new BankTransaction(amount);
        transactions.Enqueue(transaction);
        balance += amount;
    }

    public override string ToString()
    {
        return $"Номер счета: {AccountNumber}, Баланс: {Balance}, Тип счета: {AccountType}";
    }

    public void TransferFrom(BankAccount2 fromAccount, decimal amount)
    {
        if (fromAccount == null)
        {
            Console.WriteLine("Не указан целевой счёт");
            return;
        }
        if (fromAccount.Withdraw(amount))
        {
            Deposit(amount);
            Console.WriteLine($"Совершен перевод {amount} со счета {fromAccount.AccountNumber} на счет {AccountNumber}");
        }
    }
}

