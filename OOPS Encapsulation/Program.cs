Account a1 = new Account();

int amount = 0;
string action;

Console.WriteLine("1. Deposit");
Console.WriteLine("2. Withdraw");
Console.Write("Please Select Action: ");
action = Console.ReadLine();
Console.WriteLine();

if(action == "1")
{
    Console.Write("How many balance you want Deposit: ");
    amount = int.Parse(Console.ReadLine());
    a1.Deposit(amount);
}
else if (action == "2")
{
    Console.Write("How many balance you want Withdraw: ");
    amount = int.Parse(Console.ReadLine());
    a1.Withdraw(amount);
}
else
{
    Console.Write("Invalid Action");
    return;
}

a1.Display();