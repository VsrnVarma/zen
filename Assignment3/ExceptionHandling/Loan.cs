Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members. Create a method calculate_EMI() for the LoanAmount , with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount. 
The rest of the information to be passed through constructors. Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. If yes then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {
        }
    }

    class LoanProcess
    {
        int Lno;
        string CustName;
        public double LoanAmount;
        double EmiAmount,Balance;

        public LoanProcess(int lno,string name,double bal)
        {
            Lno = lno;
            CustName = name;
            Balance = bal;
        }

        public void CaluculateEMI()
        {
            int rate = 13,n=36;
            double r = ((double)rate / (double)n )/100;

            EmiAmount = LoanAmount * r * (Math.Pow((1 + r), n) / (Math.Pow((1 + r), n) - 1));

        }

        public void CheckBalance()
        {
            if (Balance < EmiAmount)
            {
                throw (new LoanException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("Loan Repayed");
            }
        }

    }

    class Loan
    {
        static void Main()
        {
            LoanProcess loan = new LoanProcess(1234,"Akhil",10000.0);
            Console.WriteLine("Enter the Loan amount: ");
            loan.LoanAmount = Convert.ToDouble(Console.ReadLine());

            loan.CaluculateEMI();
            try
            {
                loan.CheckBalance();
            }
            catch(LoanException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
