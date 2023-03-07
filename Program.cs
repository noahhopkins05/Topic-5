namespace Topic_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decision;
            double balance, deposit, withdrawal, wallet;
            double fee = 0.75;
            int loop = 1;
            Random generator = new Random();

            // Pt 1

            balance = generator.NextDouble() * 1000;
            wallet = generator.NextDouble() * 100;
            balance = Math.Round(balance, 2);
            wallet = Math.Round(wallet, 2);
            Console.WriteLine("Hello! Welcome to Noah's ATM!");

            while (loop == 1)
            { 
                Console.WriteLine(" ");
                Console.WriteLine("If you would like deposit enter 1");
                Console.WriteLine("If you would like to withdraw enter 2");
                Console.WriteLine("If you would like to pay a bill enter 3");
                Console.WriteLine("If you like to check your balance enter 4");
                Console.WriteLine("If you would like to exit enter any other number");
                Console.WriteLine("You have " + wallet + "$ in your wallet.");
                Console.WriteLine("You have " + balance + "$ in your account.");
                if (Int32.TryParse(Console.ReadLine(), out decision))
                {

                }
                else
                {
                    Console.WriteLine("Thank you for choosing Noah's ATM. Have a great day!");
                }
                while (decision == 1)
                {
                    Console.WriteLine("Enter the amount you would like to deposit:");
                    deposit = Double.Parse(Console.ReadLine());

                    if (deposit > wallet)
                    {
                        Console.WriteLine("You don't have enough money to deposit that amount. Please try again.");
                    }
                    else
                    {
                        wallet = wallet - deposit;
                        balance = balance - fee + deposit;
                        wallet = Math.Round(wallet, 2);
                        Console.WriteLine("Your new balance is " + balance + "$ and you deposited " + deposit + "$");
                        Console.WriteLine("You have " + wallet + "$ in your wallet");

                        Console.WriteLine(" ");
                        Console.WriteLine("If you would like deposit enter 1");
                        Console.WriteLine("If you would like to withdraw enter 2");
                        Console.WriteLine("If you would like to pay a bill enter 3");
                        Console.WriteLine("If you like to check your balance enter 4");
                        Console.WriteLine("If you would like to exit enter any other number");
                        Console.WriteLine("You have " + wallet + "$ in your wallet.");
                        Console.WriteLine("You have " + balance + "$ in your account.");
                        if (Int32.TryParse(Console.ReadLine(), out decision))
                        {

                        }
                    }

                }

                while (decision == 2)
                {
                    Console.WriteLine("Enter the amount you would like to withdraw:");
                    withdrawal = Double.Parse(Console.ReadLine());
                    if (withdrawal > balance + fee)
                    {
                        Console.WriteLine("You don't have enough money in your account to withdraw that amount please try again.");
                    }
                    else
                    {
                        balance = balance - fee - withdrawal;
                        wallet = wallet + withdrawal;
                        balance = Math.Round(balance, 2);
                        Console.WriteLine("Your new balance is " + balance + "$ and you withdrew " + withdrawal + "$");
                        Console.WriteLine("You have " + wallet + "$ in your wallet");

                        Console.WriteLine(" ");
                        Console.WriteLine("If you would like deposit enter 1");
                        Console.WriteLine("If you would like to withdraw enter 2");
                        Console.WriteLine("If you would like to pay a bill enter 3");
                        Console.WriteLine("If you like to check your balance enter 4");
                        Console.WriteLine("If you would like to exit enter any other number");
                        Console.WriteLine("You have " + wallet + "$ in your wallet.");
                        Console.WriteLine("You have " + balance + "$ in your account.");
                        if (Int32.TryParse(Console.ReadLine(), out decision))
                        {

                        }
                     
                    }

                }

                while (decision == 3)
                {
                    Console.WriteLine("Enter the amount you wish to pay to your bill");
                    balance = balance - fee;

                    Console.WriteLine(" ");
                    Console.WriteLine("If you would like deposit enter 1");
                    Console.WriteLine("If you would like to withdraw enter 2");
                    Console.WriteLine("If you would like to pay a bill enter 3");
                    Console.WriteLine("If you like to check your balance enter 4");
                    Console.WriteLine("If you would like to exit enter any other number");
                    Console.WriteLine("You have " + wallet + "$ in your wallet.");
                    Console.WriteLine("You have " + balance + "$ in your account.");
                    if (Int32.TryParse(Console.ReadLine(), out decision))
                    {

                    }

                }

                if (decision == 4)
                {
                    Console.WriteLine("Your balance is " + balance);

                    Console.WriteLine(" ");
                    Console.WriteLine("If you would like deposit enter 1");
                    Console.WriteLine("If you would like to withdraw enter 2");
                    Console.WriteLine("If you would like to pay a bill enter 3");
                    Console.WriteLine("If you like to check your balance enter 4");
                    Console.WriteLine("If you would like to exit enter any other number");
                    Console.WriteLine("You have " + wallet + "$ in your wallet.");
                    Console.WriteLine("You have " + balance + "$ in your account.");
                    if (Int32.TryParse(Console.ReadLine(), out decision))
                    {

                    }
                



                }
                else
                {
                    Console.WriteLine("Thank you for choosing Noah's ATM. Have a great day!");
                    Environment.Exit(0);
                }



            }


        }
    }
}