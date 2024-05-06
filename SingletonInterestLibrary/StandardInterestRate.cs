using System;

namespace SingletonInterestLibrary
{
    public class StandardInterestRate
    {
        private static readonly StandardInterestRate instance = new();
        public int CurrentInterestRate { get; set; } = 3;
        private StandardInterestRate() 
        {
            Console.WriteLine($"Standard Rate started at {CurrentInterestRate}%");
        }
        public static StandardInterestRate GetInstance()
        {
            return instance;
        }
    }
}
