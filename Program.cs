using System;

namespace AlphaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Question 1-----");
            Console.WriteLine("=====\n Write a program that gets the value of two words from an input:\n a. Get the lenght of each word\n b. Add the result of the two lenghts gotten from (a)\n c. Using the tenary operator, check if the resultant value for (b) is greater than 20\n i. If true multiply the result by 3\n ii. Otherwise add 20 to the result.\n@@@@@");
            Console.WriteLine();
            
            Console.Write("Enter first word: ");
            string span = Console.ReadLine();
            Console.WriteLine("Lenght of the word is: " + span.Length);
            Console.WriteLine();

            Console.Write("Enter second word: ");
            string span1 = Console.ReadLine();
            Console.WriteLine("Lenght of the word is: " + span1.Length);
            Console.WriteLine();

            string span2 = span + span1; 
            int span2Lenght = span2.Length;
            Console.WriteLine("The result of the two lenght gotten is: " + span2Lenght);
            Console.WriteLine();

            int right = span2Lenght * 3;
            int wrong = span2Lenght + 20;
            Console.WriteLine((span2Lenght > 20) ? "The resultant value is greater than 20. Hence the lenght of the two words: " + span2Lenght + " * 3 = " + right : "The resultant value is less than 20. Hence the lenght of the words: " + span2Lenght + " + 20 = " + wrong);
            Console.WriteLine();

            Console.WriteLine("-----Question 2-----");
            Console.WriteLine("=====\n Write a program to calculate the profit between the cost price\n of a product of $200.876 whose selling price is $255.425.\n The result should be in two decimal places.\n@@@@@");
            Console.WriteLine();
            
            decimal costPrice = 200.876M;
            decimal sellingPrice = 255.425M;
            decimal profit = Math.Round(sellingPrice - costPrice, 2);
            Console.WriteLine("The profit between selling price of a product of $" + sellingPrice + " and cost price of $" + costPrice + " = $" + profit);
            Console.WriteLine();

            Console.WriteLine("-----Question 3-----");
            Console.WriteLine("=====\n Get the index of the third character of any given string.\n a. Add the value of the index to the lenght of the whole string.\n b. Convert the result of the above to a character.\n@@@@@");
            Console.WriteLine();

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int index = word.IndexOf(word[2]);
            int wordLenght = word.Length;
            int newLenght = index + wordLenght;
            char result = (char)newLenght;

            Console.WriteLine($"The index of the third character in {word} is: {word[2]}");
            Console.WriteLine($"The value of index {2} added to lenght of string {wordLenght} is: {result}");
            Console.WriteLine($"The result {newLenght} converted to character is: {result}");
            Console.WriteLine();

            Console.WriteLine("-----Question 4-----"); 
            Console.WriteLine("=====\n Write a program that reads two numbers from the console and prints the greater of them.\n Solve the problem without using conditional or the tenary operator statements.\n@@@@@");
            Console.WriteLine();

            Console.Write("Enter the 1st number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int greaterNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("Number {0} is greater", greaterNumber);
            Console.WriteLine();

            Console.WriteLine("-----Question 5-----");
            Console.WriteLine("=====\n Write a program that reads five integer number and prints their sum. If an invalid number is entered,\n the program should prompt the user to enter another number.\n Hint: use a while loop to solve the problem here. Also read about the Parse(), TryParse() method.\n@@@@@");
            Console.WriteLine();

            int sum = 0;
            int i = 0;
            while (i <= 4)
            {
                Console.Write("Enter first number: ");
                string input = Console.ReadLine();
                int a;
                bool parseSuccess = int.TryParse(input, out a);

                if (!parseSuccess)
                {
                    i--;
                    Console.Write("Invalid input!");
                }

                sum +=a;
                i++;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");

            Console.WriteLine("-----Question 6-----");
            Console.WriteLine("=====\nThe sum of two numbers collected from user input, subtracted from a constant value of 5.\n(Sample expression: number 1 + number 2 - 5).\nWrite a program to prompt the user to input the correct answer from the above given expression.\na. If the user provides the correct answer print the text \"Correct answer\" to the console output.\nb. Otherwise print the text \"Wrong answer!\" alongside the correct answer.\n@@@@@");
            Console.WriteLine();

            const int value = 5; 
            Console.Write("Pls enter the 1st number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Pls enter the 2nd number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            int sum1 = number + number1 - value;
            Console.Write("Enter the answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            string result1 = (answer == sum1) ? "You've entered the correct answer!" :  $"Wrong answer! The correct answer is: {sum1}";
            Console.WriteLine(result1);
            Console.WriteLine();
            
            Console.WriteLine("-----Question 7-----");
            Console.WriteLine("=====\n Write a program that asks for a digit (0-9), and depending on the input,\n shows the digit as a word (in English). \n Use a switch statement. \n=====");
            Console.WriteLine();

            Console.Write("Please enter a number between 0 and 9: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            
            switch (digit)
            {
                case 0: 
                    Console.WriteLine("Zero"); 
                    break;
                case 1: 
                    Console.WriteLine("One"); 
                    break;
                case 2: 
                    Console.WriteLine("Two"); 
                    break;
                case 3: 
                    Console.WriteLine("Three"); 
                    break;
                case 4: 
                    Console.WriteLine("Four"); 
                    break;
                case 5: 
                    Console.WriteLine("Five"); 
                    break;
                case 6: 
                    Console.WriteLine("Six"); 
                    break;
                case 7: 
                    Console.WriteLine("Seven"); 
                    break;
                case 8: 
                    Console.WriteLine("Eight"); 
                    break;
                case 9: 
                    Console.WriteLine("Nine"); 
                    break;
                default: 
                    Console.WriteLine("Invalid number! \nPlease try again..."); 
                    break;
            }
            Console.WriteLine();
            
            

            
        }

        
    }
}
