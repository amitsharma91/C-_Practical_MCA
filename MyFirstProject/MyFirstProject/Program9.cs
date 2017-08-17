/*	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. 

	Expected Output :
	Enter a number: 1234 
	The sum of the digits of the number 1234 is : 10
*/
using System;

namespace MyFirstProject
{
	public class Program9
	{
		public long sumOfDigits (int num)
		{
			long sum = 0;
			while (num > 0) {
				int l = num % 10;
				sum = sum + l;
				num = num / 10;
			}
			return sum;
		}

		/*static void Main (string[] args)
		{
			Console.WriteLine ("Enter a Number: ");
			int num = Convert.ToInt32 (Console.ReadLine ());

			Program9 obj = new Program9 ();
			Console.WriteLine ("Sum of Digits of numbers is: " + obj.sumOfDigits (num));
		}*/
	}
}	