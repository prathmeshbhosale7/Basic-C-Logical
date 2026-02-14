class Account()
{
    private int balance = 1000;

    public void Withdraw(int a)
    {
        if(a <= balance)
        {
            balance -= a;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void Deposit(int a)
    {
        if(a > 0)
        {
            balance += a;
        }
        else
        {
            Console.WriteLine("Invalid Balance");
        }
    }

    public void Display()
    {
        Console.Write("Available Balance is: " + balance);
    }
}