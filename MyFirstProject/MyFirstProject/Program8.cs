/*	Write a program in C# Sharp to create a function to check whether a number is prime or not. 

	Expected Output: 
	Input a number: 31 
	31 is a prime number
*/
using System;

namespace MyFirstProject
{
	public class Program8
	{

		public bool checkPrime (int num)
		{
			int n = 2;
			while (n < num) {

				if (num % n == 0)
					return false;

				n++;
			}

			return true;
		}

		/*static void Main (string[] args)
		{
			Console.WriteLine ("Enter any Number: ");
			int num = Convert.ToInt32 (Console.ReadLine ());

			Program8 obj = new Program8 ();
			if (obj.checkPrime (num))
				Console.WriteLine ("Number is Prime.");
			else
				Console.WriteLine ("Number is NOT Prime.");
		}*/
	}
}