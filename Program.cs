using System;

// Define an interface called IQuittable
// This interface forces any implementing class to define a Quit() method
public interface IQuittable
{
    void Quit(); // Method declaration only (no body here)
}

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Basic employee properties
    public string FirstName { Hassib Ullah }
    public string LastName { Wakili
    // Implementing the Quit() method from the interface
    public void Quit()
    {
        // This message simulates an employee quitting their job
        Console.WriteLine(Hassib Ullah + " " + Wakili + " has decided to resign from the company.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an Employee object and assigning values
        Employee emp = new Employee();
        emp.FirstName = "Hassib Ullah";
        emp.LastName = "Wakili";

        // Using polymorphism:
        // Instead of referencing the object as Employee,
        // we reference it as IQuittable (the interface type)
        IQuittable quittableEmployee = emp;

        // Calling the Quit() method using the interface reference
        quittableEmployee.Quit();

        // Pause the console so the output stays visible
        Console.ReadLine();
    }
}