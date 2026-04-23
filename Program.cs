using System;

// This interface represents something that has the ability to quit
// Any class that uses this must define what "quitting" means
public interface IQuittable
{
    void Quit(); // Just the method signature, no logic here
}

// This class represents an employee in a company
// It implements IQuittable, meaning it must define the Quit() method
public class Employee : IQuittable
{
    // Basic properties to store employee information
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // This method is required because of the interface
    // Here we decide what happens when an employee quits
    public void Quit()
    {
        Console.WriteLine($"{Hassib Ullah} {Wakili}  has decided to resign from the company.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new employee object
        Employee employee = new Employee();

        // Assign values to the employee
        employee.FirstName = "Hassibullah";
        employee.LastName = "Wakily";

        // Here is where polymorphism happens:
        // We are storing the Employee object inside a variable of type IQuittable
        IQuittable quitter = employee;

        // Even though the reference type is IQuittable,
        // it still calls the Employee's version of Quit()
        quitter.Quit();

        // Keeps the console window open so we can see the output
        Console.ReadLine();
    }
}
