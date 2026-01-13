# Csharp-advance-programming-dsa
This repository contains C# programs focused on Data Structures and Algorithms (DSA), organized branch-wise for systematic learning.
The goal of this project is to strengthen problem-solving skills, algorithmic thinking, and efficient data handling in C# through hands-on practice.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio
- **Version Control:** Git & GitHub

---

## ✨ Features
- Structured **branch-wise learning approach**
- Separate branches for different **dsa concepts**
- Beginner-friendly **C# practice problems**
- Focus on **logic building and fundamentals**

---

## 📂 Branch Structure

### 🔹 `sorting` branch
This branch focuses on Sorting Algorithms in C#, covering both basic and advanced sorting techniques.
The problems are designed using real-world scenarios (students, employees, products, salaries) to help understand algorithm logic, time complexity, and data organization in a practical way.
All sorting programs are implemented from scratch to strengthen DSA fundamentals.

---

### 📝 Practice Problems

- **Bubble Sort – Sort Student Marks**  
  Implement Bubble Sort to arrange student marks in ascending order by repeatedly comparing and swapping adjacent elements.

- **Insertion Sort – Sort Employee IDs**  
  Use Insertion Sort to sort employee IDs by inserting elements into their correct position in a growing sorted portion of the array.

- **Merge Sort – Sort Book Prices**  
  Apply Merge Sort to sort book prices by dividing the array recursively and merging sorted subarrays.

- **Quick Sort – Sort Product Prices**  
  Implement Quick Sort using a pivot-based partitioning approach to efficiently sort product prices.

- **Selection Sort – Sort Exam Scores**  
  Use Selection Sort to repeatedly select the minimum element and place it in its correct position.

- **Heap Sort – Sort Job Applicants by Salary**  
  Build a Max Heap and repeatedly extract the maximum element to sort salary demands in ascending order.

- **Counting Sort – Sort Student Ages**  
  Implement Counting Sort to sort student ages efficiently when the input range is small and known.

---

### 🎯 Learning Outcomes

- Understanding **comparison-based and non-comparison-based sorting algorithms**
- Strengthening **DSA fundamentals**
- Learning when to use **which sorting algorithm**
- Improving **logical and performance-oriented thinking**

---

### 🔹 `searching` branch
This branch focuses on **searching algorithms, efficient string manipulation, and file handling concepts** in C#.  
It is designed to strengthen **DSA fundamentals**, **performance-aware coding**, and **real-world I/O handling** using built-in .NET utilities.

### 📝 Practice Problems

- **Reverse a String Using StringBuilder**  
  Reverse a given string using `StringBuilder` instead of built-in reverse methods.

- **Remove Duplicates from a String Using StringBuilder**  
  Remove duplicate characters while maintaining the original order.

- **Concatenate Strings Efficiently Using StringBuilder**  
  Concatenate an array of strings using `StringBuilder` for better performance.

- **Compare StringBuilder Performance**  
  Compare the performance of `StringBuilder` with normal string concatenation for repeated operations.

- **Read a File Line by Line Using StreamReader**  
  Read and display each line from a text file.

- **Count the Occurrence of a Word in a File**  
  Read a file and count how many times a specific word appears.

- **Convert Byte Stream to Character Stream**  
  Read binary data from a file and display it as characters.

- **Read User Input and Write to File**  
  Take input from the console and store it in a file using stream operations.

- **Search for the First Negative Number**  
  Find the first negative number in an integer array using Linear Search.

- **Search for a Specific Word in Sentences**  
  Find the first sentence containing a given word using Linear Search.

- **Find the Rotation Point in a Rotated Sorted Array**  
  Identify the index of the smallest element using Binary Search.

- **Find the Peak Element in an Array**  
  Find an element greater than its neighbors using Binary Search.

- **Search for a Target Value in a 2D Sorted Matrix**  
  Perform Binary Search on a row-wise sorted 2D matrix.

- **Find First and Last Occurrence of an Element**  
  Locate the first and last index of a target element in a sorted array.

---

#### 🚀 Challenge Problem (Linear + Binary Search)

- **First Missing Positive & Target Search**
  - Use **Linear Search** to find the first missing positive integer.
  - Sort the array and apply **Binary Search** to find the index of a target element.
  - Return `-1` if the target is not found.

---

### 🎯 Learning Outcomes

- Mastering **Linear and Binary Search algorithms**
- Understanding **time complexity trade-offs**
- Writing **performance-optimized string operations**
- Handling **file I/O operations** in real-world scenarios
- Strengthening **problem-solving and algorithmic thinking**

---

### 🔹 `runtime-analysis` branch
This branch focuses on **runtime complexity analysis and performance comparison** of different algorithms and programming approaches in C#.  
The goal is to build a **deep understanding of time complexity (Big-O notation)** by comparing **naive vs optimized solutions** using real-world datasets and scenarios.

All programs in this branch are designed to **measure execution time, scalability, and efficiency**.

---

### 📝 Performance Analysis Problems

---

### 🔹 1. Search a Target in a Large Dataset
**Objective:**  
Compare the performance of:
- **Linear Search** – `O(N)`
- **Binary Search** – `O(log N)`

**Description:**  
Search for a target element in datasets of varying sizes and analyze how performance changes as data grows.

---

### 🔹 2. Sorting Large Data Efficiently
**Objective:**  
Compare sorting algorithms:
- **Bubble Sort** – `O(N²)`
- **Merge Sort** – `O(N log N)`
- **Quick Sort** – `O(N log N)`

**Description:**  
Sort large datasets and analyze execution time to understand why advanced sorting algorithms outperform basic ones for large inputs.

---

### 🔹 3. String Concatenation Performance
**Objective:**  
Compare string concatenation approaches:
- **String** – `O(N²)`
- **StringBuilder** – `O(N)`
- **StringBuffer** – `O(N)`

**Description:**  
Concatenate a large number of strings (e.g., one million) and measure performance differences to highlight efficient memory usage.

---

### 🔹 4. Large File Reading Efficiency
**Objective:**  
Compare file reading techniques:
- **StreamReader**
- **FileStream**

**Description:**  
Read a large file (≈500MB) and analyze which approach is more efficient in terms of speed and resource usage.

---

### 🔹 5. Recursive vs Iterative Fibonacci Computation
**Objective:**  
Compare Fibonacci implementations:
- **Recursive Approach** – `O(2^N)`
- **Iterative Approach** – `O(N)`

**Description:**  
Compute Fibonacci numbers using both methods and observe how recursion leads to exponential time complexity compared to iteration.

---

### 🎯 Learning Outcomes

- Understand **Big-O notation through practical examples**
- Analyze **performance trade-offs** between algorithms
- Learn how **data size impacts execution time**
- Write **efficient, scalable C# code**
- Develop strong **algorithm optimization skills**

---

### 🔹 `hashMap` branch
This branch focuses on **non-linear data structures**, primarily **HashMap (Dictionary)**, used to model real-world problems involving **key–value relationships**.
The implementations emphasize **abstraction, encapsulation, and polymorphism**.

---

### 📝 Practice Problems

---

- **Inventory Management System**
  - Maps product IDs to product details.
  - *OOP:* Encapsulated inventory manager, polymorphic products.

- **Role-Based Access Control (RBAC)**
  - Maps users to roles and permissions.
  - *OOP:* Abstraction via roles, polymorphic role behavior.

- **Student Grade Book**
  - Maps student roll numbers to grade reports.
  - *OOP:* Strategy-based grading systems.

- **URL Shortener Service**
  - Maps short URLs to original long URLs.
  - *OOP:* Interface-based storage, pluggable implementations.

---

### 🎯 Learning Outcomes

- Understand **non-linear data structure behavior**
- Implement **Dictionary / HashMap** efficiently
- Model **real-world relationships using key–value pairs**
- Apply **encapsulation and abstraction**
- Strengthen **data-driven system design**

---

### 🔹 `stack` branch
This branch focuses on **linear data structures** where elements are arranged sequentially. It demonstrates practical implementations of **Stack** using **real-world use cases** while applying **Object-Oriented Programming (OOP) principles** such as abstraction, encapsulation, interfaces, and polymorphism.

---

### 📝 Practice Problems

---

- **Expression Evaluation Engine**
  - Converts infix expressions to postfix and evaluates them.
  - Uses stack internally for parsing and computation.
  - *OOP:* Interface-based evaluators, encapsulated stack operations.

- **Web Browser Navigation (Back / Forward)**
  - Simulates browser tab navigation using two stacks.
  - *OOP:* Encapsulation of navigation logic, extensible design.

- **Syntax Checker for Code Editors**
  - Validates balanced parentheses, brackets, and braces.
  - *OOP:* Stack logic hidden inside syntax checker implementation.

- **Undo Functionality in Drawing Application**
  - Stores drawing actions and supports undo operation.
  - *OOP:* Polymorphic drawing actions, encapsulated undo stack.

---

### 🎯 Learning Outcomes

- Understand **Stack** operations deeply
- Apply **linear data structures** to real-world problems
- Design systems using **interfaces and encapsulation**
- Implement **polymorphism in data structure-based systems**
- Strengthen **DSA + OOP integration**

### 🔹 `queues` branch
This branch focuses on **linear data structures** where elements are arranged sequentially. It demonstrates practical implementations of **Stack** using **real-world use cases** while applying **Object-Oriented Programming (OOP) principles** such as abstraction, encapsulation, interfaces, and polymorphism.

---

### 📝 Practice Problems

---

- **Print Job Manager**
  - Handles print requests in arrival order.
  - *OOP:* Encapsulated print queue, polymorphic document types.

- **Ticket Booking System**
  - Processes booking requests sequentially.
  - *OOP:* Interface-based request handling for different transports.

- **Task Dispatcher for Background Workers**
  - Queues background tasks like uploads, analytics, and logs.
  - *OOP:* Encapsulation of task queue, polymorphic tasks.

- **Call Center Management System**
  - Manages incoming calls and assigns them to agents.
  - *OOP:* Interface-driven call types, hidden queue management.

---

### 🎯 Learning Outcomes

- Understand **Queue** operations deeply
- Apply **linear data structures** to real-world problems
- Design systems using **interfaces and encapsulation**
- Implement **polymorphism in data structure-based systems**
- Strengthen **DSA + OOP integration**

---

### 🔹 linkedList
This folder focuses on implementing **Linked List data structures** through **real-world use cases**, while applying **Object-Oriented Programming (OOP)** concepts such as abstraction, encapsulation, inheritance, and polymorphism.

### 📝 Implemented Scenarios

- **Browser History Navigation**  
  Implements backward and forward navigation using a doubly linked list.

- **Music Playlist Management**  
  Manages a dynamic playlist where songs can be added, removed, and played sequentially.

- **Customer Service Call Center Queue**  
  Handles support tickets in FIFO order with different ticket types like chat, call, and email.

- **Customer Support Chat Queue System**  
  Maintains a queue of user requests using interfaces and polymorphism.

- **Social Media Notification Feed**  
  Stores and displays notifications in reverse chronological order.

- **Custom Notification Delivery System**  
  Delivers Email, SMS, and Push notifications using an interface-based queue.

- **Train Route Management System**  
  Manages railway stations as linked stops with dynamic insertion, removal, and traversal.

- **Undo / Redo Manager (Command Pattern)**  
  Implements undo and redo operations using a linked list and command interface.

---

### 🎯 Learning Outcomes

- Understand **Stack, Queue and LinkedList** operations deeply
- Apply **linear data structures** to real-world problems
- Design systems using **interfaces and encapsulation**
- Implement **polymorphism in data structure-based systems**
- Strengthen **DSA + OOP integration**

---

## 👤 Author
**Lucky Goyal**  
B.Tech CSE (Artificial Intelligence and Machine Learning) 
