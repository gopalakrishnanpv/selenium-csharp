﻿using selenium_csharp;
using log4net;
using log4net.Config;
using System.Xml.Linq;

namespace csharp_selenium
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Object
			Person person1 = new Person();
			person1.name = "Prasad";
			Console.WriteLine(person1.Age);
			person1.Age = -30;
			Console.WriteLine(person1.Age);
			person1.Greet();

			Person person2 = new Person();
			person2.name = "Gopal";
			person2.Greet();

			Employee employee1 = new Employee();
			employee1.name = "Gopi";
			employee1.Salary = 1000;
			employee1.Greet();
			employee1.PrintSalary();

			Employee employee2 = new Employee();
			employee2.SayHello();

			CollegeStudent collegeStudent = new CollegeStudent();
			collegeStudent.CalculateMarks();
		}
	}
}