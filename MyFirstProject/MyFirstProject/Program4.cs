/*	Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string. 

	Expected Output : 
	Please input a string : This is a test string. 
	"This is a test string." contains 4 spaces
*/

using System;

namespace MyFirstProject
{
	public class Program4
	{
		public void countSpaces (String str)
		{
			int count = 0;

			foreach (char i in str) {
//				if(char.IsWhiteSpace(i)){
				if (i == ' ') {
					++count;
				}
			}

			Console.WriteLine ("Space count is: " + count);
		}

		/*static void Main (string[] args)
		{
			Console.WriteLine ("Enter any String: ");
			String str = Console.ReadLine ();
			Program4 obj = new Program4 ();
			obj.countSpaces (str);
		}*/
	}
}