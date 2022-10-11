/*
 * Created by SharpDevelop.
 * User: tomasbrides
 * Date: 15/02/2019
 * Time: 11:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Assignment3
{
	/// <summary>
	/// Description of Employee.
	/// </summary>
	public class Employee
	{
		
		//member fields
			
		private int employeeNumber;
		private decimal hourlyRate;
		private decimal standardWorkHours;
		
		//overloaded contsructor for employee
		public Employee(int number)		
		{
			employeeNumber = number;
			
		}
	}
}
