/*	Write a program in C# Sharp to create a function to display the n number Fibonacci sequence. 

	Expected Output : 
	Input number of Fibonacci Series : 5 
	The Fibonacci series of 5 numbers is : 
	0 1 1 2 3
*/
using System;

namespace MyFirstProject
{
	public class Program7
	{
		public void fibonacci (int limit)
		{
			int p = 0, n = 1;

			Console.Write (p + ", " + n + ", ");
			for (int i = 2; i < limit; i++) {
				int temp = p;
				p = n;
				n = temp + n;
				Console.Write (n + ", ");
			}
		}

		/*static void Main (string[] args)
		{
			Console.WriteLine ("Enter the Limit: ");
			int limit = Convert.ToInt32 (Console.ReadLine ());
			Program7 obj = new Program7 ();
			obj.fibonacci (limit);
		}*/
	}
}