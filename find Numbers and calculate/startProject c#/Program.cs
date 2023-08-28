using System;

namespace startProject_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find smallest number:
            int num1 = 35;
            int num2 = 45;
            int num3 = 75;

            if (num1<num2 && num1 < num3)
            {
                Console.WriteLine(num1);
            }
            else if(num2 < num1 && num2 < num3)

            {
                Console.WriteLine(num2);
            }
            else 
                Console.WriteLine(num2);

            //Find biggest number in mention below:
            int[] numbArray = { 3, 6, 7, 9, 16, 175 };
            int biggestNumber = numbArray[0];
            for(int i = 0; i < numbArray.Length; i++)
            {
                if (biggestNumber < numbArray[i])
                {
                    biggestNumber = numbArray[i];
                }
            }
            Console.WriteLine(biggestNumber);

            //Finds the numerical mean (average) of numbers divisible by 3 in a given list of numbers:
            int[] numbersArray = { 3, 6, 7, 9, 16 };
            int numbersDivideBy3 = 0;
            int numbersDivideBy3Quantity = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 3 == 0)
                {
                    numbersDivideBy3 = numbersDivideBy3 + numbersArray[i];
                    numbersDivideBy3Quantity++;
                }
            }
            Console.WriteLine(numbersDivideBy3/numbersDivideBy3Quantity);

            //Find 3 digits number in Array: 
            int[] ArrayExample = { 3, 6, 7, 9, 16,777 };
            for (int i = 0; i < ArrayExample.Length; i++)
            {
                if (99 < ArrayExample[i] && ArrayExample[i]<1000)
                {
                    Console.WriteLine(ArrayExample[i]);
                }
            }
            // Find digit in string
            FindNumInString("Azer6baycan1");
        }
        static void FindNumInString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]))
                {
                    Console.WriteLine(str[i] + " " + "Is Digit");
                    
                }
            }
        }
    }
}
