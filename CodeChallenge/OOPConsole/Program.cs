// See https://aka.ms/new-console-template for more information
Console.WriteLine("4. Object-Oriented Programming");
Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 1: Design a logger with different logging strategies (file, database, console):");
Console.WriteLine("Write a C# class that implements a logger with multiple logging strategies. The logger should have different logging methods: one for writing logs to a file, one for writing logs to a database, and one for writing logs to the console. The logging system should allow the user to configure the desired logging method dynamically and ensure that logs are written according to the selected strategy. Function signature: class Logger { void LogToFile(string message); void LogToDatabase(string message); void LogToConsole(string message); }");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 2: Create a Shape class hierarchy using inheritance and polymorphism:");
Console.WriteLine("Write a C# class hierarchy for different types of shapes. Create a base class Shape with an abstract method CalculateArea(). Implement subclasses for specific shapes like Circle, Rectangle, and Triangle, each with its own implementation of CalculateArea(). Demonstrate polymorphism by creating an array of Shape objects and calculating the area for each shape. Function signature: abstract class Shape { abstract double CalculateArea(); }");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 3: Build a car rental system using OOP principles:");
Console.WriteLine("Design a C# car rental system using object-oriented principles.Use dependency injection. The system should have classes for Car, Customer, Rental, and CarRentalService. The Car class should have attributes like Model, LicensePlate, and RentalPricePerDay. The Customer class should store customer details. The Rental class should handle booking and returning cars, while the CarRentalService class should manage the available cars and the rental process. Implement methods to rent a car, return a car, and calculate the total rental cost based on the rental duration. Function signature: class CarRentalService { void RentCar(Customer customer, Car car, int days); void ReturnCar(Customer customer, Car car); }");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
