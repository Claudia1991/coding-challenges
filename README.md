# Algorithms and Data Structures in C\#

This repository contains a collection of C# exercises covering a wide range of fundamental algorithm and data structure problems. These examples are ideal for practicing technical interview preparation or reinforcing your understanding of common coding patterns, problem-solving, and clean algorithmic thinking.

Each problem is implemented **from scratch**, with constraints like avoiding LINQ or built-in shortcuts unless specified. The focus is on low-level logic using basic language features, loops, recursion, collections, and custom implementations.

## 📚 Table of Contents

1. [String and Array Manipulation](#1-string-and-array-manipulation)
2. [Searching and Sorting](#2-searching-and-sorting)
3. [Dictionaries and Sets](#3-dictionaries-and-sets)
4. [Stacks and Queues](#4-stacks-and-queues)
5. [Recursion](#5-recursion)

## 1. String and Array Manipulation

- **Reverse the Words in a Sentence**
  Reverses the order of words in a sentence (not the characters).
  `string ReverseWords(string sentence)`

- **Compress a String**
  Compresses a lowercase string using character counts (e.g., `"aaabbb"` → `"a3b3"`).
  `string CompressString(string input)`

- **Rotate Array Right by K Steps**
  Rotates an integer array to the right by _k_ steps, in-place with O(1) space.
  `void Rotate(int[] nums, int k)`

- **Remove Duplicates from Array or String**
  Removes duplicates while preserving the order.
  `string RemoveDuplicateChars(string input)`
  `int[] RemoveDuplicateInts(int[] input)`

## 2. Searching and Sorting

- **Merge Sort Implementation**
  Classic recursive divide-and-conquer sorting algorithm.
  `int[] MergeSort(int[] array)`

- **Find the Kth Largest Element**
  Finds the kth largest element in an unsorted array using Quickselect or heap.
  `int FindKthLargest(int[] nums, int k)`

- **Binary Search**
  Manual binary search on a sorted array, O(log n).
  `int BinarySearch(int[] nums, int target)`

- **Search in a 2D Matrix**
  Efficient search for a value in a sorted 2D matrix.
  `bool SearchMatrix(int[][] matrix, int target)`

## 3. Dictionaries and Sets

- **Detect Duplicates Using HashSet**
  Checks if an array has any duplicate elements.
  `bool ContainsDuplicate(int[] nums)`

- **Find Most Frequent Element**
  Identifies the element with the highest frequency in an array.
  `int MostFrequentElement(int[] nums)`

- **Check Anagrams**
  Verifies if two strings are anagrams using dictionaries.
  `bool AreAnagrams(string s1, string s2)`

- **Word Count in a Text File**
  Counts the frequency of words in a file (case-insensitive).
  `Dictionary<string, int> CountWordsInFile(string filePath)`

## 4. Stacks and Queues

- **Custom Stack with Min() in O(1)**
  Stack that supports retrieving the minimum in constant time.
  `class CustomStack { void Push(int val); int Pop(); int Min(); }`

- **Queue Using Two Stacks**
  Emulates a queue using two stack instances.
  `class QueueUsingStacks { void Enqueue(int val); int Dequeue(); }`

- **HTML Tag Nesting Validator**
  Validates if HTML tags are properly nested using a stack.
  `bool AreTagsNested(string html)`

## 5. Recursion

- **Generate Well-Formed Parentheses**
  Produces all combinations of `n` pairs of well-formed parentheses.
  `List<string> GenerateParentheses(int n)`

- **Factorial (Recursive)**
  Recursively calculates the factorial of a non-negative integer.
  `int Factorial(int n)`

- **Permutations and Combinations**
  Recursively generates permutations and all subsets (combinations) of a list.
  `List<List<int>> GetPermutations(List<int> nums)`
  `List<List<int>> GetCombinations(List<int> nums)`

## 2. Logic / Problem Solving Challenges

### FizzBuzz with Parameters (Custom Multiples and Words)

**Description**:
Write a C# method that implements the FizzBuzz problem with customizable multiples and words.

**Requirements**:

- Accept 5 parameters:

  - `n`: range of numbers from 1 to `n`
  - `fizzMultiple`: number for "Fizz"
  - `buzzMultiple`: number for "Buzz"
  - `fizzWord`: custom word for multiples of `fizzMultiple`
  - `buzzWord`: custom word for multiples of `buzzMultiple`

- Output a list of strings where:

  - Numbers divisible by `fizzMultiple` show `fizzWord`
  - Numbers divisible by `buzzMultiple` show `buzzWord`
  - Numbers divisible by both show both words concatenated

- Example: For input `(15, 3, 5, "Foo", "Bar")`, output is:
  `["1", "2", "Foo", "4", "Bar", "Foo", "7", "8", "Foo", "Bar", "11", "Foo", "13", "14", "FooBar"]`

**Function Signature**:

```csharp
List<string> FizzBuzz(int n, int fizzMultiple, int buzzMultiple, string fizzWord, string buzzWord)
```

### Implement a Digital Clock Simulator

**Description**:
Simulate the behavior of a digital clock.

**Requirements**:

- Display time in the format `HH:MM:SS`, starting at `00:00:00`
- Update every second and loop back to `00:00:00` after `23:59:59`
- Continue running until manually stopped

**Function Signature**:

```csharp
void StartDigitalClock()
```

### Determine If a Number is Prime or Part of the Fibonacci Sequence

**Description**:
Check whether a number is prime, part of the Fibonacci sequence, or neither.

**Requirements**:

- Return:

  - `"Prime"` if number is prime
  - `"Fibonacci"` if number belongs to Fibonacci sequence
  - `"Neither"` otherwise

**Examples**:

- Input: `5` → Output: `"Prime"`
- Input: `8` → Output: `"Fibonacci"`

**Function Signature**:

```csharp
string CheckPrimeOrFibonacci(int num)
```

### Find the Longest Common Prefix of an Array of Strings

**Description**:
Find the longest common prefix among all strings in an array.

**Examples**:

- Input: `["flower", "flow", "flight"]` → Output: `"fl"`

**Function Signature**:

```csharp
string LongestCommonPrefix(string[] strs)
```

### Implement a Roman Numeral Converter

**Description**:
Convert an integer to its Roman numeral representation.

**Constraints**:

- Input range: 1 to 3999
- Use standard Roman numeral rules

**Examples**:

- Input: `3` → Output: `"III"`
- Input: `58` → Output: `"LVIII"`

**Function Signature**:

```csharp
string ToRoman(int num)
```

### Determine the Day of the Week for a Given Date (Without `DateTime.DayOfWeek`)

**Description**:
Calculate the day of the week using basic mathematical operations only.

**Example**:

- Input: `(2025, 5, 9)` → Output: `"Friday"`

**Constraints**:

- Do not use `DateTime.DayOfWeek` or any built-in date handling

**Function Signature**:

```csharp
string DayOfWeek(int year, int month, int day)
```

## 3. LINQ and Collections

### Group a List of Students by Grade and Sort by GPA

**Description**:
Group students by grade and sort each group by GPA (descending).

**Input Example**:

```json
[{ "Alice", "A", 3.8 }, { "Bob", "B", 3.5 }, { "Charlie", "A", 3.9 }]
```

**Output**:

```json
{
  "A": [{ "Charlie", 3.9 }, { "Alice", 3.8 }],
  "B": [{ "Bob", 3.5 }]
}
```

**Function Signature**:

```csharp
Dictionary<string, List<Student>> GroupByGradeAndSort(List<Student> students)
```

### Flatten a Nested List Using LINQ

**Description**:
Flatten a deeply nested list of integers.

**Example Input**:

```csharp
[[1, 2], [3, [4, 5], 6], 7]
```

**Output**:

```csharp
[1, 2, 3, 4, 5, 6, 7]
```

**Function Signature**:

```csharp
List<int> FlattenList(List<object> nestedList)
```

### Get the Top N Most Expensive Products from a List

**Description**:
Return the top N products by price.

**Example**:

- Input:

  ```json
  [{ "Product A", 30 }, { "Product B", 50 }, { "Product C", 20 }]
  ```

- N = 2
- Output:

  ```json
  [{ "Product B", 50 }, { "Product A", 30 }]
  ```

**Function Signature**:

```csharp
List<Product> GetTopNExpensiveProducts(List<Product> products, int N)
```

### Find Duplicate Names Across Multiple Collections

**Description**:
Return a list of names that appear in more than one string list.

**Example**:

- Input:

  ```csharp
  [["Alice", "Bob", "Charlie"], ["Bob", "David", "Eve"]]
  ```

- Output: `["Bob"]`

**Function Signature**:

```csharp
List<string> FindDuplicateNames(List<List<string>> collections)
```

### Join Two Lists (e.g., Customers and Orders)

**Description**:
Perform a join between customers and orders on CustomerId.

**Example**:

- Customers: `[{1, "Alice"}, {2, "Bob"}]`
- Orders: `[{1, 1, 100}, {2, 2, 200}]`

**Output**:

```json
[{ "Alice", 1, 100 }, { "Bob", 2, 200 }]
```

**Function Signature**:

```csharp
List<OrderDetails> JoinCustomersAndOrders(List<Customer> customers, List<Order> orders)
```

### Return Only Unique Values from a Collection of Complex Objects

**Description**:
Return unique elements from a list based on a specific property (e.g., `Name`).

**Example**:

- Input:

  ```json
  [{ "Alice", "A", 3.9 }, { "Bob", "B", 3.5 }, { "Alice", "C", 3.8 }]
  ```

- Output:

  ```json
  [{ "Alice", "A", 3.9 }, { "Bob", "B", 3.5 }]
  ```

**Function Signature**:

```csharp
List<Student> GetUniqueStudents(List<Student> students)
```

### Count How Many Times Each Digit Appears in a List of Numbers

**Description**:
Count occurrences of each digit (0-9) in a list of integers.

**Example**:

- Input: `[123, 456, 123]`
- Output: `{0: 0, 1: 2, 2: 2, 3: 2, 4: 1, 5: 1, 6: 1}`

**Function Signature**:

```csharp
Dictionary<int, int> CountDigitOccurrences(List<int> numbers)
```

### 4. Object-Oriented Programming

#### Design a vending machine class

**Description:**
Simulate a vending machine with a list of available products. Users can insert money, select products, and receive change.
**Requirements:**

- Add products with name and price
- Insert money
- Select product
- Return balance after purchase
- Handle insufficient funds and unavailable products
  **Function Signature:**

```csharp
class VendingMachine {
    void AddProduct(string name, double price);
    void InsertMoney(double amount);
    void SelectProduct(string product);
    double GetBalance();
}
```

#### Implement an elevator system

**Description:**
Simulate an elevator system for a building with multiple floors. Users can request the elevator, specify destination, and check current floor.
**Requirements:**

- Handle floor requests
- Move elevator between floors
- Reject invalid or redundant requests
  **Function Signature:**

```csharp
class Elevator {
    void RequestElevator(int floor);
    void MoveToFloor(int destination);
    int GetCurrentFloor();
}
```

#### Design a logger with different logging strategies

**Description:**
Create a logger with configurable logging methods: file, database, and console.
**Requirements:**

- Allow dynamic selection of logging strategy
- Output log to selected target
  **Function Signature:**

```csharp
class Logger {
    void LogToFile(string message);
    void LogToDatabase(string message);
    void LogToConsole(string message);
}
```

#### Create a Shape class hierarchy

**Description:**
Design a shape hierarchy using inheritance and polymorphism.
**Requirements:**

- Base abstract class with CalculateArea method
- Implement Circle, Rectangle, and Triangle
- Use polymorphism with an array of Shape
  **Function Signature:**

```csharp
abstract class Shape {
    abstract double CalculateArea();
}
```

#### Build a car rental system using OOP principles

**Description:**
Create a car rental system with support for dependency injection and object management.
**Requirements:**

- Classes: Car, Customer, Rental, CarRentalService
- Rent and return cars
- Calculate total rental cost
  **Function Signature:**

```csharp
class CarRentalService {
    void RentCar(Customer customer, Car car, int days);
    void ReturnCar(Customer customer, Car car);
}
```

### 5. Multithreading / Asynchronous Programming

#### Fetch data from multiple APIs concurrently using `Task.WhenAll()`

**Description:**
Fetch data from several URLs concurrently and return the results.
**Requirements:**

- Accept a list of URLs
- Handle exceptions and timeouts
  **Function Signature:**

```csharp
async Task<List<string>> FetchDataFromApisAsync(List<string> urls)
```

#### Write a thread-safe singleton class

**Description:**
Implement a singleton class that is safe across multiple threads.
**Requirements:**

- Use Lazy<T> or double-check locking
- Guarantee single instance
  **Function Signature:**

```csharp
class Singleton {
    public static Singleton Instance { get; }
}
```

#### Implement a simple background worker using `Task.Run()`

**Description:**
Run a long-running operation in the background without blocking the main thread.
**Requirements:**

- Accept long-running delegate
- Return result after execution
- Handle exceptions
  **Function Signature:**

```csharp
Task<string> RunBackgroundWorkerAsync(Func<Task> longRunningTask)
```

#### Use `SemaphoreSlim` to limit concurrent operations

**Description:**
Control how many concurrent tasks can run at the same time.
**Requirements:**

- Limit concurrency with SemaphoreSlim
- Handle task execution safely
  **Function Signature:**

```csharp
async Task ProcessWithLimitedConcurrency(List<Func<Task>> tasks, int maxConcurrentTasks)
```

#### Create a method to cancel a long-running operation with `CancellationToken`

**Description:**
Support canceling a long operation gracefully using a token.
**Requirements:**

- Monitor cancellation requests
- Stop and return early if cancelled
  **Function Signature:**

```csharp
async Task LongRunningOperationAsync(CancellationToken cancellationToken)
```

#### Use a `BlockingCollection` for a producer-consumer pattern

**Description:**
Use a thread-safe collection to synchronize producers and consumers.
**Requirements:**

- Producers add data
- Consumers process data
- Block when full/empty appropriately
  **Function Signature:**

```csharp
void RunProducerConsumer()
```

#### Write a timer using `System.Timers.Timer` that executes a task every 5 seconds

**Description:**
Create a recurring timer that executes a task at 5-second intervals.
**Requirements:**

- Run task periodically
- Stop after a trigger or set number of executions
  **Function Signature:**

```csharp
void StartTimer()
```

## 6. Testing / TDD

### 🧪 Write unit tests for a calculator class

**Description:**
Write unit tests to verify the correctness of arithmetic operations in a calculator class.

**Requirements:**

- Test addition, subtraction, multiplication, and division.
- Handle edge cases: division by zero, negative numbers.
- Use a testing framework like xUnit or NUnit.

**Function Signature:**

```csharp
class Calculator {
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);
}
```

### 🧵 Test edge cases (null input, empty list, large inputs)

**Description:**
Create unit tests for a method that processes a list of integers, focusing on edge scenarios.

**Requirements:**

- Handle `null` input.
- Handle empty lists.
- Test with very large lists (e.g., 100,000+ items).
- Validate output correctness and performance.

**Function Signature:**

```csharp
int ProcessList(List<int> numbers);
```

### 🔁 Use `[Theory]` and `[InlineData]` in xUnit for multiple test cases

**Description:**
Use parameterized testing with `[Theory]` and `[InlineData]` to test a method like `IsPrime`.

**Requirements:**

- Test with various numbers: primes, non-primes, edge cases.
- Clearly separate input and expected result for each test case.

**Function Signature:**

```csharp
bool IsPrime(int number);
```
