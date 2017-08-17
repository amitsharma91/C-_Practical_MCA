/*	Write a program in C# Sharp to create a function to swap the values of two integer numbers. 

	Expected Output :
	Enter a number: 5 
	Enter another number: 6 
	Now the 1st number is : 6 , and the 2nd number is : 5
*/
using System;

namespace MyFirstProject
{
	public class Program5
	{
		int a, b;

		public Program5 (int a, int b)
		{
			this.a = a;
			this.b = b;
		}

		public void printData ()
		{
			Console.WriteLine ("a: " + this.a + "\tb: " + this.b);
		}

		public void swap (int a, int b)
		{
			int temp = a;
			this.a = b;
			this.b = temp;
		}

		/*static void Main(string[] args){
			Console.WriteLine ("Enter First Number: ");
			int a = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Enter Last Number: ");
			int b = Convert.ToInt32 (Console.ReadLine ());

			Program5 obj = new Program5 (a,b);
			Console.WriteLine ("Before Swap:");
			obj.printData ();

			obj.swap (a, b);
			Console.WriteLine ("After Swap:");
			obj.printData ();
		}*/
	}
}