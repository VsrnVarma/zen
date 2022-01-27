Create a class called Accounts which has data members like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
    D->Deposit
    W->Withdrawal
    -write a function that updates the balance depending upon the transaction type
       -If transaction type is deposit call the credit(int amount) function and update balance
	   -If transaction type is withdraw call debit(int amt)function and update balance
    -Pass the other information like Acount no,name,acc type through constructor
    -call the show data method to display the values.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Account
    {
        long Accno;
        string Name;
        string AccType;
        public string TransType;
        public int Amount;
        int Balance=0;

        public Account(long no, string name,string acctype)
        {
            Accno = no;
            Name = name;
            AccType = acctype;
        }

        public void Credit(int amt)
        {
            Balance += amt;
        }

        public void Debit(int amt)
        {
            Balance -= amt;
        }

        public void Show()
        {
            Console.WriteLine($"Account No: {Accno}");
            Console.WriteLine($"Account Name: {Name} and Type: {AccType}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(1234567,"Yogesh","Savings");
            ac.Show();
            Console.Write("Enter the transaction type: ");
            ac.TransType = Console.ReadLine();

            if(ac.TransType=="Deposit" || ac.TransType == "deposit")
            {
                Console.Write("Enter the amount to deposit: ");
                ac.Amount = Convert.ToInt32(Console.ReadLine());
                ac.Credit(ac.Amount);
            }

            if(ac.TransType=="Withdraw" || ac.TransType == "withdraw")
            {
                Console.Write("Enter the amount to withdraw: ");
                ac.Amount = Convert.ToInt32(Console.ReadLine());
                ac.Debit(ac.Amount);
            }
        }
    }
}
