# EDC Gadget Manager

A simple C# console application demonstrating a **custom linked list** for managing Everyday Carry (EDC) gadgets, built for a PROG7312/INSY3D data structures assignment.

## Features

- **Add a gadget** with custom days it is carried (e.g., "Everyday", "Monday, Wednesday, Friday")
- **Remove gadgets** by name
- **Find gadgets** by name
- **Count** total gadgets
- **Insert** a gadget at any position in the list
- **Reverse** the order of gadgets
- **Clear** all gadgets from the list
- **Display** all gadgets
- **Display gadgets by day of the week**

## How It Works

This project uses a custom singly linked list (not C#'s built-in collections). Each node stores a `Gadget` object and a pointer to the next node. The application provides a simple interactive console menu to perform all operations.

## Getting Started

### Requirements

- [.NET 6+ SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code **or** Visual Studio

### Setup

1. **Clone the repo** (or copy the files to your local machine).
2. Install dependencies (only the .NET SDK is required).
3. Open the project folder in VS Code.
4. Build and run:

   ```sh
   dotnet build
   dotnet run

Usage
Follow the console menu.

Enter gadget names and carried days as prompted.

To specify days, use a comma-separated list (e.g. Monday, Tuesday, Friday)

Type Everyday to mark a gadget as carried every day.

Example
EDC Gadget Manager
1. Add Gadget
2. Remove Gadget
3. Find Gadget
4. Count Gadgets
5. Insert Gadget at Position
6. Reverse List
7. Clear All Gadgets
8. Display All Gadgets
9. Display Gadgets by Day
0. Exit
Select an option: 1

Enter gadget name: Laptop
Enter days gadget is carried (comma-separated, e.g., Monday,Tuesday) or 'Everyday': Monday,Tuesday,Wednesday,Thursday,Friday
Gadget added.

File Structure
Gadget.cs — Model for each gadget, including days carried

Node.cs — Linked list node structure

GadgetLinkedList.cs — Custom singly linked list with all operations

Program.cs — Main menu, input/output, and app logic

Educational Purpose
This project is designed to demonstrate:

Manual implementation of linked lists

Class design, generics, and C# best practices

Applying data structures to a practical use case

License
This project is for educational purposes and is not licensed for commercial use.