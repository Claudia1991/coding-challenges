// See https://aka.ms/new-console-template for more information
using LinqClasses;

Console.WriteLine("LINQ and Collections");
Console.WriteLine("Exercise 1: Group a list of students by grade and sort by GPA");
Console.WriteLine("Write a C# method that groups a list of students by their grade and sorts the students within each group by GPA in descending order. " +
    "Each student has a name, grade, and GPA. For example, given the input list of students " +
    "[{ \"Alice\", \"A\", 3.8 }, { \"Bob\", \"B\", 3.5 }, { \"Charlie\", \"A\", 3.9 }], " +
    "the method should group them by grade and sort by GPA, resulting in " +
    "{\"A\": [{ \"Charlie\", 3.9 }, { \"Alice\", 3.8 }], \"B\": [{ \"Bob\", 3.5 }]}. " +
    "You should use LINQ for grouping and sorting. " +
    "Function signature: Dictionary<string, List<Student>> GroupByGradeAndSort(List<Student> students)");
Exercise1 exercise1 = new Exercise1();
exercise1.PrepareData();
Console.WriteLine(exercise1.ShowData(exercise1.students));
Console.WriteLine("Result:" + exercise1.Execute());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 2: Flatten a nested list using LINQ");
Console.WriteLine("Write a C# method that flattens a nested list of integers into a single, flat list using LINQ. " +
    "The nested list can have multiple levels of nested lists. " +
    "For example, given the input [[1, 2], [3, [4, 5], 6], 7], " +
    "the output should be [1, 2, 3, 4, 5, 6, 7]. " +
    "Use LINQ's SelectMany to flatten the list, and ensure that it works for multiple levels of nesting. " +
    "Function signature: List<int> FlattenList(List<object> nestedList)");
Exercise2 exercise2 = new Exercise2();
exercise2.PrepareData();
Console.WriteLine(exercise2.ShowData(exercise2.nestedList));
Console.WriteLine("Result:" + exercise2.Execute());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 3: Get the top N most expensive products from a list:");
Console.WriteLine("Write a C# method that returns the top N most expensive products from a list of products. Each product has a name and a price. For example, given a list of products [{ \"Product A\", 30 }, { \"Product B\", 50 }, { \"Product C\", 20 }] and N = 2, the method should return the two most expensive products: [{ \"Product B\", 50 }, { \"Product A\", 30 }]. Use LINQ's OrderByDescending to sort and select the top N products. Function signature: List<Product> GetTopNExpensiveProducts(List<Product> products, int N)");
Exercise3 exercise3 = new Exercise3();
exercise3.PrepareData();
Console.WriteLine(exercise3.ShowData(exercise3.products));
Console.WriteLine("Result:" + exercise3.Execute());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 4: Find duplicate names across multiple collections:");
Console.WriteLine("Write a C# method that finds duplicate names across multiple collections (e.g., lists) of strings. The method should return a list of names that appear in more than one collection. For example, given the input collections [\"Alice\", \"Bob\", \"Charlie\"] and [\"Bob\", \"David\", \"Eve\"], the output should be [\"Bob\"]. Use LINQ to compare elements across collections and identify duplicates. Function signature: List<string> FindDuplicateNames(List<List<string>> collections)");
Exercise4 exercise4 = new Exercise4();
exercise4.PrepareData();
Console.WriteLine(exercise4.ShowData(exercise4.names));
Console.WriteLine("Result:" + exercise4.Execute());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 5: Join two lists (e.g., customers and orders):");
Console.WriteLine("Write a C# method that joins two lists: one representing customers and the other representing orders. Each customer has an Id and Name, and each order has an OrderId, CustomerId, and Amount. The method should return a list of objects that contains the customer's name, order ID, and amount. For example, given the customers [{1, \"Alice\"}, {2, \"Bob\"}] and orders [{1, 1, 100}, {2, 2, 200}], the result should be [{ \"Alice\", 1, 100 }, { \"Bob\", 2, 200 }]. Use LINQ's Join method for the join operation. Function signature: List<OrderDetails> JoinCustomersAndOrders(List<Customer> customers, List<Order> orders)\r\n");
Exercise5 exercise5 = new Exercise5();
exercise5.PrepareData();
Console.WriteLine(exercise5.ShowData(exercise5.Customers));
Console.WriteLine(exercise5.ShowData(exercise5.Orders));
Console.WriteLine("Result:" + exercise5.Execute());
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 6: Return only unique values from a collection of complex objects:");
Console.WriteLine("Write a C# method that returns only the unique values from a collection of complex objects. The objects could have multiple properties, and you should identify uniqueness based on a specific property. For example, if the input is a list of students with properties Name, Grade, and GPA, the method should return a list with only the unique students by their Name (ignoring duplicates). You can use LINQ’s DistinctBy or implement a custom equality comparer. Function signature: List<Student> GetUniqueStudents(List<Student> students)");
Console.WriteLine("EXERCISE");
Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("Exercise 7: Count how many times each digit appears in a list of numbers:");
Console.WriteLine("Write a C# method that counts how many times each digit (0-9) appears in a list of integers. The method should return a dictionary where the keys are the digits and the values are the counts. For example, given the input [123, 456, 123], the output should be a dictionary like {0: 0, 1: 2, 2: 2, 3: 2, 4: 1, 5: 1, 6: 1}. Use LINQ to count the occurrences of each digit in the list. Function signature: Dictionary<int, int> CountDigitOccurrences(List<int> numbers)");
