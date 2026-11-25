using System;
using System.Collections.Generic;


class Employee
{
    public string Name;
    public decimal BaseSalary;

    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

 
    public virtual decimal CalculateMonthlySalary()
    {
        return BaseSalary;
    }
}


class Manager : Employee
{
    public decimal Bonus;

    public Manager(string name, decimal baseSalary, decimal bonus)
        : base(name, baseSalary)   
    {
        Bonus = bonus;             
    }

    
    public override decimal CalculateMonthlySalary()
    {
        return BaseSalary + Bonus;
    }
}


class Developer : Employee
{
    public int LinesOfCodeWritten;

    public Developer(string name, decimal baseSalary, int lines)
        : base(name, baseSalary)
    {
        LinesOfCodeWritten = lines;
    }

    public override decimal CalculateMonthlySalary()
    {
        return BaseSalary + LinesOfCodeWritten * 0.5m;   
    }
}

class Program
{
    static void Main()
    {

        List<Employee> employees = new List<Employee>();
        employees.Add(new Manager("Иван Петров", 100000m, 5000m));
        employees.Add(new Developer("Анна Сидорова", 90000m, 10500));
        employees.Add(new Manager("Олег Васильев", 120000m, 10000m));

        Console.WriteLine("--- Расчет заработной платы ---");

    
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"Зарплата для {emp.Name}: {emp.CalculateMonthlySalary()}");
        }

        Console.ReadKey();
    }
}