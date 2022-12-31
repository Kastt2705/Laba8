using System;

namespace Bank_Deposit
{
    class Program
    {
        public static void Main()
        {
            string[] userInput = File.ReadAllLines("input.txt");
            FileReader fileReader = new();
            BankAccount account = fileReader.StructureData(userInput);
            Display display = new();
            display.BeginWork(account);

            Console.ReadKey();
        }

    }

}