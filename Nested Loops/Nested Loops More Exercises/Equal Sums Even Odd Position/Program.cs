using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                oddSum = 0;
                evenSum = 0;

                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(currentNum + " ");
                }
            }

            
        }
    }
}
