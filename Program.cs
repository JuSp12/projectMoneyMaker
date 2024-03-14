using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("How many money you would like to conver?");
            string money = Console.ReadLine();
            double moneys = Convert.ToDouble(money);

            Console.WriteLine($"{moneys} is equal to...");

            double gold = 10;
            double silver = 5;

            double goldCoins = Math.Floor(moneys / gold);
            double restOfMoney = moneys % gold;
            double silverCoins = Math.Floor(restOfMoney / silver);
            double restOfMoneytwo = restOfMoney % silver;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {restOfMoneytwo}");

        }
    }
}
