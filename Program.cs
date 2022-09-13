using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class cardHolder
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        int balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, int balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public int getBalance()
        {
            return balance;
        }

        public void setNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }
        
        public void setBalance(int newBalance)
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
                Console.WriteLine("How much $$ would you like to deposit: ");
                int deposit = int.Parse(Console.ReadLine());
                currentUser.setBalance(deposit);
                Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
            }

            void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to withdraw: ");
                int withdraw = int.Parse(Console.ReadLine());
                if (currentUser.getBalance() <= withdraw)
                {
                    Console.WriteLine("Insufficient balance :(");
                } else
                {
                    int newBalance = currentUser.getBalance() - withdraw;
                    currentUser.setBalance(newBalance);
                    Console.WriteLine("You're good to go! Thank you :)");
                }
            }

            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());

            }

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("9684651984651", 1275, "Brian", "Trinh", 100000));
            cardHolders.Add(new cardHolder("9846531265415", 4613, "Tracey", "Ngo", 100000));
            cardHolders.Add(new cardHolder("8867534984985", 4673, "Nick", "Heng", 100000));
            cardHolders.Add(new cardHolder("9876516251965", 4976, "Danny", "Phan", 100000));
            cardHolders.Add(new cardHolder("9849516546546", 4673, "Vivian", "Pham", 100000));

            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Please insert your debit card: ");
            string debitCardNum = "";
            cardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if(currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }

        }
    }
}
