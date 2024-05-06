using System;

namespace SingletonInterestLibrary
{
    public class StandardInterestRate
    {
        private static readonly StandardInterestRate instance = new();
        private int CurrentInterestRate { get; set; } = 3;
        private StandardInterestRate() 
        {
            Console.WriteLine($"Standard Rate started at {CurrentInterestRate}%");
        }
        public static StandardInterestRate GetInstance()
        {
            return instance;
        }
        public void UpdateInterestRate(int newInterestRate)
        {
            Console.WriteLine("Updated Interest Rate.\n" +
                $"From: {CurrentInterestRate}%\n" +
                $"To: {newInterestRate}%" +
                $"\n");
            CurrentInterestRate = newInterestRate;
        }
        public override string ToString()
        {
            return $"The current Interest Rate is {CurrentInterestRate}%.";
        }
    }
}
