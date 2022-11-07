using LinqExercise;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
//Static array of integers
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

/*
* 
* Complete every task using Method OR Query syntax. 
* You may find that Method syntax is easier to use since it is most like C#
* Every one of these can be completed using Linq and then printing with a foreach loop.
* Push to your github when completed!
* 
*/

//TODO: Print the Sum of numbers
Console.WriteLine(numbers.Sum());

//TODO: Print the Average of numbers
Console.WriteLine(numbers.Average());
//TODO: Order numbers in ascending order and print to the console
var inOrder = numbers.OrderBy(x => x);
foreach (var num in inOrder)
{
    Console.WriteLine(num);
}
Console.WriteLine("---------------------------------------");
//TODO: Order numbers in decsending order and print to the console
var descOrder = numbers.OrderByDescending(x => x);
foreach (var num in descOrder)
{
    Console.WriteLine(num);
}
Console.WriteLine("--------------------------------");
//TODO: Print to the console only the numbers greater than 6
var largeNum = numbers.Where(x => x > 6).ToList();
foreach (var num in largeNum)
{
    Console.WriteLine(num);
}
Console.WriteLine("--------------------------------");

//foreach(var x in largenum)
//{
//    console.writeline(x);
//}
//TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
foreach (int num in numbers)
{
    if (num > 5)
    {
        Console.WriteLine(num);
    }
}
Console.WriteLine("--------------------------------");

//TODO: Change the value at index 4 to your age, then print the numbers in decsending order
numbers.SetValue(40, 4);
var newValue = numbers.OrderByDescending(x => x);
foreach (double num in newValue)
{
    Console.WriteLine(num);
}
Console.WriteLine("--------------------------------");

// List of employees ****Do not remove this****
var employees = CreateEmployees();

//TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
var empName = employees.Where(emp => emp.FirstName.ToLower().StartsWith('c') || emp.FirstName.ToLower().StartsWith('s'));
empName.OrderBy(empName => empName);

foreach(var emp in empName)
{
    Console.WriteLine(emp.FirstName);
}

Console.WriteLine("---------------------------------------------");



//TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
var eldest = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
foreach(var num in eldest)
{
    Console.WriteLine($" Name: {num.FullName}, Age: {num.Age}");
}
//TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
var sumAndExp = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10);

Console.WriteLine($" The sum of the experience for ages over 35 is: {sumAndExp.Sum(x => x.YearsOfExperience)}");
Console.WriteLine($"The average of the experience of these folks is: {sumAndExp.Average(x => x.YearsOfExperience)}");

Console.WriteLine("---------------------------------------------");


//TODO: Add an employee to the end of the list without using employees.Add()
employees = employees.Append(new Employee("Steve", "Jobs", 53, 1)).ToList();
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine($"Check out the bottom of the list for our newest employee");
foreach (var emp in employees)
{
    Console.WriteLine(emp.FullName);
}
//Console.WriteLine();

Console.ReadLine();

#region CreateEmployeesMethodtake
static List<Employee> CreateEmployees()
{
    List<Employee> employees = new List<Employee>();
    employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
    employees.Add(new Employee("Steven", "Bustamento", 56, 5));
    employees.Add(new Employee("Micheal", "Doyle", 36, 8));
    employees.Add(new Employee("Daniel", "Walsh", 72, 22));
    employees.Add(new Employee("Jill", "Valentine", 32, 43));
    employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
    employees.Add(new Employee("Big", "Boss", 23, 14));
    employees.Add(new Employee("Solid", "Snake", 18, 3));
    employees.Add(new Employee("Chris", "Redfield", 44, 7));
    employees.Add(new Employee("Faye", "Valentine", 32, 10));

    return employees;
    #endregion
}