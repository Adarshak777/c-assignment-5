using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetassign_5
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 20000.00f;
        float Balance;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Acount Namer {Acc_Name}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposit Amount : ");
            float DepositAmount = Convert.ToSingle(Console.ReadLine());

            if (DepositAmount == 0)
            {
                Console.WriteLine(Acc_Name + "Deposite the minimum amount above 100.00 ");

            }
            else
            {
                Balance = Amount + DepositAmount;
                Console.WriteLine(Acc_Name + "  Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void Amount_Withdraw()
        {

            Console.WriteLine("Enter the WithDraw Amount : ");
            float Withdraw_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdraw_Amount > Balance)
            {
                throw (new WithdrawnException( " You have Insufficent balance"));
            }
            else
            {
                Balance = Balance - Withdraw_Amount;
                Console.WriteLine(" Your Account Balance is After With Draw the amount :" + Balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositeAmount();
                bank.Amount_Withdraw();

            }
            catch (WithdrawnException VY)
            {
                Console.WriteLine(VY.Message);
            }
            catch (FormatException AK)
            {
                Console.WriteLine("Enter only numbers:-  ",  AK);
            }
            Console.ReadLine();
        }
    
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }
    }
    public class Bank
    {
        float Amount = 20000.00f;
        float Balance;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {Acc_Number}, Acount Namer {Acc_Name}, Amount is {Amount}");

        }


        public void DepositeAmount()
        {
            Console.WriteLine("Enter the Deposit Amount : ");
            float DepositAmount = Convert.ToSingle(Console.ReadLine());

            if (DepositAmount == 0)
            {
                Console.WriteLine(Acc_Name + "Deposite the minimum amount above 100.00 ");

            }
            else
            {
                Balance = Amount + DepositAmount;
                Console.WriteLine(Acc_Name + "  Your Account Balance is After amount deposite : " + Balance);
            }
        }

        public void Amount_Withdraw()
        {

            Console.WriteLine("Enter the WithDraw Amount : ");
            float Withdraw_Amount = Convert.ToSingle(Console.ReadLine());


            if (Withdraw_Amount > Balance)
            {
                throw (new WithdrawnException( " You have Insufficent balance"));
            }
            else
            {
                Balance = Balance - Withdraw_Amount;
                Console.WriteLine(" Your Account Balance is After With Draw the amount :" + Balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositeAmount();
                bank.Amount_Withdraw();

            }
            catch (WithdrawnException VY)
            {
                Console.WriteLine(VY.Message);
            }
            catch (FormatException AK)
            {
                Console.WriteLine("Enter only numbers:-  ",  AK);
            }
            Console.ReadLine();
        }
  
    }   
    
}
