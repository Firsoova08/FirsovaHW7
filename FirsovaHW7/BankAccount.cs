using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsovaHW7
{
    internal class BankAccount
    {
        public string AccountNumber;
        private decimal Balance;  
        public BankAccount(string accountNumber, decimal initialBalance = 0)
        {
            this.AccountNumber = accountNumber;  
            this.Balance = initialBalance;       
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;  
                Console.WriteLine($"Пополнение: +{amount}");
            }
            else
            {
                Console.WriteLine("Ошибка: сумма должна быть положительной");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ошибка: сумма должна быть положительной");
            }
            else if (amount > this.Balance)  
            {
                Console.WriteLine($"Ошибка: недостаточно средств. Баланс: {this.Balance}");
            }
            else
            {
                this.Balance -= amount;  
                Console.WriteLine($"Снятие: -{amount}₽");
            }
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {this.Balance}");  
        }
    }

}

