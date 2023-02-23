﻿namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class cardHolder
        {
            String cardNum;
            int pin;
            String firstName;
            String lastName;
            double balance;
        
            public cardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
            {
                this.cardNum = cardNum;
                this.pin = pin;
                this.firstName = firstName;
                this.lastName = lastName;
                this.balance = balance;
            }

            public String getNum() 
            { 
                return cardNum;
            } 
            public int getPin() 
            { 
                return pin;
            }

            public String getFirstName()
            {
                return firstName;
            }

            public String getLastName()
            {
                return lastName;   
            }

            public double getBalance()
            {
                return balance;
            }

            public void setNum(String newCardNum)
            {
                cardNum = newCardNum;
            }

            public void setPin(int newPin)
            { pin = newPin; }

            public void setFirstName(String newFirstName) 
            { 
                firstName = newFirstName; 
            }
            public void setLastName(String newLastName) 
            { 
                lastName = newLastName; 
            } 

            public void setBalance(double newBalance)
            {
                balance = newBalance;   
            }

            public static void Main(String[] args)
            {
                void printOptions()
                {
                    Console.WriteLine("Please choose from one of the following options...");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Show Balance");
                    Console.WriteLine("4. Exit");
                }

                void deposit(cardHolder currentUser)
                {
                    Console.WriteLine("How mych $$ would you like to deposit? ");
                    double deposit = Double.Parse(Console.ReadLine());
                    currentUser.setBalance(deposit);
                    Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
                }

                void withdraw(cardHolder currentUser)
                {
                    Console.WriteLine("How much $$ would you like to withdraw: ");
                    double withdrawal = Double.Parse(Console.ReadLine());
                    //Check if the user has enough money
                    if(currentUser.getBalance() > withdrawal)
                    {
                        Console.WriteLine("Insufficient balance :(");
                    }
                    else
                    {
                        
                        currentUser.setBalance(currentUser.getBalance() - withdrawal);
                        Console.WriteLine("You're good to go! Thank you :)");
                    }
                }

                void balance(cardHolder currentUser)
                {
                    Console.WriteLine("Current balance: " + currentUser.getBalance());
                }

                List<cardHolder> cardHolders = new List<cardHolder>();
                cardHolders.Add(new cardHolder("4532772818527395", 1234, "John", "Griffith", 150.31));
                cardHolders.Add(new cardHolder("4532734576523466", 4321, "Ashley", "Jones", 321.13));
                cardHolders.Add(new cardHolder("4532772235778945", 9999, "Frida", "Dickerson", 105.59));
                cardHolders.Add(new cardHolder("4532779657535455", 2468, "Muneeb", "Harding", 851.84));
                cardHolders.Add(new cardHolder("4532772812359965", 4826, "Dawn", "Smith", 54.27));

                //Prompt user
                Console.WriteLine("Welcome to SimpleATM");
                Console.WriteLine("Please insert your debit card: ");
                String debitCardNum = "";
                cardHolder currentUser;

                while(true)
                {
                    try
                    {
                        debitCardNum = Console.ReadLine();
                        // Check against our db
                        currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                        if (currentUser != null) { break; }
                        else { Console.WriteLine("Card not recognized. Please try again"); }
                    }
                    catch { Console.WriteLine("Card not recognized. Please try again"); }

                }
            }
        }

        }
    }

