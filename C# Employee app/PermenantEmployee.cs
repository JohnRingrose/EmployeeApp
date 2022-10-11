/*
 * Created by SharpDevelop.
 * User: tomasbrides
 * Date: 15/02/2019
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Assignment3
{
	/// <summary>
	/// The Permenant Employee class is a derived / child class of Employee
	/// </summary>
	public class PermenantEmployee : Employee
	{
		
		//member fields
		private decimal unionDeduction;
		private decimal healthInsuranceDeduction;
		
		public PermenantEmployee(int n) : base(n)
		{
			Console.WriteLine("the employees number is:" +n);
		}
	}
}
