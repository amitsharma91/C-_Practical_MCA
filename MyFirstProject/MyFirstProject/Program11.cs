/*	Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term. 

	Expected Output :
	Enter a number: 10 
	The Fibonacci of 10 th term is 55 
*/
using System;

namespace MyFirstProject
{
	public class Program11
	{
		public int getNumber (int pos)
		{
			int p = 0, n = 1;

			if (pos == 1)
				return 0;
			if (pos == 2)
				return n;
			if (pos < 1) {
				Console.WriteLine ("Enter valid Position: ");
				return -1;
			}

			int i = 3;
			while (i <= pos) {
				int sum = p + n;
				p = n;
				n = sum;
				i++;
			}		

			return n;
		}

		static void Main (string[] args)
		{
			Console.WriteLine ("Enter the nth Position for Fibonacci Series: ");
			int pos = Convert.ToInt32 (Console.ReadLine ());

			Program11 obj = new Program11 ();
			Console.WriteLine ("Number at position " + pos + " is: " + obj.getNumber (pos));
		}
	}
}