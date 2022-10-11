/*
 * Created by SharpDevelop.
 * User: tomasbrides
 * Date: 15/02/2019
 * Time: 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Assignment3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Please enter and employees number");
			
			
			int eNum1 = Convert.ToInt32(Console.ReadLine());
			
			var Employee1 = new PermenantEmployee(eNum1);
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}