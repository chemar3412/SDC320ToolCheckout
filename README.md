# SDC320ToolCheckout
Tool Checkout Application

3.8 Tool Checkout Project — README & Project Summary

 
 Project Summary
The 3.8 Tool Checkout System is a C# console application designed to simulate a real‑world workflow for managing tools, users, and checkout records. The system demonstrates core object‑oriented programming concepts including inheritance, encapsulation, composition, and state management.

The application allows users to check out tools, return them, and view a complete history of tool usage. Each checkout action generates a detailed record linking the tool, the user, and timestamps for both checkout and return. This mirrors real environments such as workshops, equipment rooms, and tool rental facilities.


 
 README.md
 Overview
The Tool Checkout System is a multi‑class C# application that manages an inventory of tools and tracks which users have checked them out. It ensures tools cannot be checked out twice at the same time and maintains a full history of all transactions.

This project fulfills the requirements of the 3.8 Tool Checkout Project assignment.


Features
Tool Management
Add tools with a name, category, and unique ID

Track availability (checked out vs. available)

Tools inherit from a shared base class

User Management
Add users with unique IDs and full names

Users can check out and return tools

Checkout Records
Each checkout generates a record containing:

Tool information

User information

Checkout timestamp

Return timestamp (when applicable)

Check‑Out / Check‑In Workflow
Prevents double‑checkout

Updates tool status on return

Maintains a readable history of all transactions



Object‑Oriented Concepts Demonstrated
Concept	Implementation
Inheritance	Shared ID logic through a base class
Encapsulation	Classes manage their own data and behaviors
Composition	Checkout records link tools and users
Polymorphism	Shared methods like GetInfo() across classes
State Management	Tools track availability



Project Structure
Code
/ToolCheckoutProject
│
├── Program.cs
├── InventoryManager.cs
├── Tool.cs
├── User.cs
├── CheckoutRecord.cs
└── (Additional classes if included)

 
 Program Flow
Initialize the InventoryManager

Add tools to the system

Add users to the system

A user checks out a tool

A checkout record is created

The tool is returned

Records are displayed showing full history

 
 Example Output
Code
Tool 'Hammer' checked out by John Smith at 3/10/2026 2:15 PM
Tool 'Hammer' returned at 3/10/2026 4:02 PM

Checkout Record:
Record ID: 1
Tool: Hammer
User: John Smith
Checked Out: 3/10/2026 2:15 PM
Returned: 3/10/2026 4:02 PM

Learning Objectives
This project demonstrates your ability to:

Build multi‑class C# applications

Apply OOP principles in a practical scenario

Manage object relationships and state

Produce clean, maintainable, readable code

 
 License
This project is for educational use as part of the 3.8 assignment requirements.
