using System;

//I am aware I added an additional method generateAccountID() I felt it was
//an intresting idea to implement for this. Additional methods are used due to GUI implementation

namespace Bank_Account_GUI
{
    class BankAccount
    {
        string accountID = "null";
        double balance = 0;
        bool accountType = true; //a bool was chosen since an account can only be two options, where true means checking and false is saving

        private void generateAccountID()
        {
            Random key = new Random();
            accountID = "";

            for (int i = 0; i <= 8; i++)
            {
                accountID = accountID + Convert.ToChar(key.Next(33, 127)); //picks a random ascii symbol from the more visual ones.
            }
        }

        private void generateAccountID(string ID)
        {
            string temp = ID;
            accountID = "";
            Random key = new Random();

            for (int i = 0; i <= 8; i++) //ensures that if the user inputs an ID too short, it will still have some level of protection and be at proper length
            {
                temp = temp + Convert.ToChar(key.Next(33, 127)); //picks a random ascii symbol from the more visual ones.
            }

            for (int i = 0; i <= 8; i++)
            {
                accountID = accountID + temp[i]; //this adds a character to the accountID and prevents the user from inputing more than max characters
            }

            if (accountID == "_________")
            {
                Console.WriteLine("That username was unacceptable, we will generate one for you.\n");
                generateAccountID(); //calls the non-parameter function
            }
        }

        public void withdraw(double m)
        {
            balance = balance - Math.Round(m, 2);
            display_balance();
        }

        public void deposit(double m)
        {
            balance = balance + Math.Round(m, 2);
            display_balance();
        }

        public void display_balance()
        {
            Console.WriteLine("Account ID: {0} has a balance of {1}.\n", accountID, balance);
        }

        public string getID()
        {
            return accountID;
        }

        public double getBalance()
        {
            return balance;
        }

        public bool getAccountType()
        {
            return accountType;
        }

        public BankAccount()
        {
            generateAccountID();
            balance = 0;
            accountType = true;
        }

        public BankAccount(double b, bool aT)
        {
            generateAccountID();
            balance = Math.Round(b, 2);
            accountType = aT;
        }
        public BankAccount(string ID, double b, bool aT)
        {
            generateAccountID(ID);
            balance = Math.Round(b, 2);
            accountType = aT;
        }
    }
}