using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_Account_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Will create the instance later, I want to keep as many methods as possible private.
        BankAccount User_Account = null;
        bool Account_Type = true;
        string Account_Type_Name = "Checking";

        public MainWindow()
        {
            InitializeComponent();
            NewAccount_Page.Visibility = Visibility.Hidden;
            Deposit_Page.Visibility = Visibility.Hidden;
            Withdraw_Page.Visibility = Visibility.Hidden;
            Display_Page.Visibility = Visibility.Hidden;
            Home_Page.Visibility = Visibility.Visible;
        }

        private bool checkInput(string test)
        {
            try
            {
                //attempts to convert the input
                Convert.ToDouble(test);
                return true;
            }

            catch
            {
                //notify the user that they made a mistake and the program is unable to complete the task.
                MessageBox.Show("There was an invalid input for the balance. Please try this again.\n");
                return false;
            }
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            if (User_Account == null)
            {
                MessageBox.Show("Please create an account before attempting this function.\n");
            }
            else
            {
                Home_Page.Visibility = Visibility.Hidden;
                Deposit_Page.Visibility = Visibility.Visible;
            }
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            if (User_Account == null)
            {
                MessageBox.Show("Please create an account before attempting this function.\n");
            }
            else
            {
                Home_Page.Visibility = Visibility.Hidden;
                Withdraw_Page.Visibility = Visibility.Visible;

            }
        }

        private void CA_B_Click(object sender, RoutedEventArgs e)
        {
            //Access The Account Generation Page
            Home_Page.Visibility = Visibility.Hidden;
            NewAccount_Page.Visibility = Visibility.Visible;
            AccountTypeText.Text = "Account: " + Account_Type_Name;
        }

        private void GA_B_Click(object sender, RoutedEventArgs e)
        {
            //Alter Account Details


            //try and catch, I knew as try and except in python, for when the input can not be converted into a number, like if the input was a word.
            if (checkInput(B_TB.Text))
            {
                User_Account = new BankAccount(ID_TB.Text, Math.Round(Convert.ToDouble(B_TB.Text)), Account_Type);
            }

            else
            {
                User_Account = null; //resets the User Account
            }

            //Return To Home Page
            NewAccount_Page.Visibility = Visibility.Hidden;
            Home_Page.Visibility = Visibility.Visible;
        }

        private void Display_Data_Click(object sender, RoutedEventArgs e)
        {
            if (User_Account == null)
            {
                MessageBox.Show("Please create an account before attempting this function.\n");
            }
            else
            {
                DisplayText.Text = "Account ID: " + User_Account.getID() + "\nAccount Type: " + Account_Type_Name + "\nBalance: $" + User_Account.getBalance() + "\n";
                Home_Page.Visibility = Visibility.Hidden;
                Display_Page.Visibility = Visibility.Visible;
            }
        }

        private void CAT_Click(object sender, RoutedEventArgs e)
        {
            if (Account_Type == true)
            {
                Account_Type = false;
                Account_Type_Name = "Saving";
            }
            else
            {
                Account_Type = true;
                Account_Type_Name = "Checking";
            }
            AccountTypeText.Text = "Account: " + Account_Type_Name; 
        }

        private void DM_B_Click(object sender, RoutedEventArgs e)
        {
            if (checkInput(DM_TB.Text))
            {
                if (Convert.ToDouble(DM_TB.Text) < 0)
                {
                    MessageBox.Show("If you wish to subtract funds, use the withdraw feature.\n");
                    Deposit_Page.Visibility = Visibility.Hidden;
                    Home_Page.Visibility = Visibility.Visible;
                    return;
                    
                }
                User_Account.deposit(Math.Round(Convert.ToDouble(DM_TB.Text)));
                Deposit_Page.Visibility = Visibility.Hidden;
                Home_Page.Visibility = Visibility.Visible;
            }
        }

        private void WM_B_Click(object sender, RoutedEventArgs e)
        {
            if (checkInput(WM_TB.Text))
            {
                if (Convert.ToDouble(WM_TB.Text) < 0)
                {
                    MessageBox.Show("If you wish to add funds, use the deposit feature.\n");
                    Withdraw_Page.Visibility = Visibility.Hidden;
                    Home_Page.Visibility = Visibility.Visible;
                    return;

                }
                User_Account.withdraw(Math.Round(Convert.ToDouble(WM_TB.Text)));
                Withdraw_Page.Visibility = Visibility.Hidden;
                Home_Page.Visibility = Visibility.Visible;
            }
        }

        private void GH_B_Click(object sender, RoutedEventArgs e)
        {
            Display_Page.Visibility = Visibility.Hidden;
            Home_Page.Visibility = Visibility.Visible;
        }
    }
}
