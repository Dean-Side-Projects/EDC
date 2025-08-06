using System;
using System.Collections.Generic;

namespace EDCGadgetManager
{
    class Program
    {
        static void Main()
        {
            GadgetLinkedList gadgets = new GadgetLinkedList();
            while (true)
            {
                Console.WriteLine("\nEDC Gadget Manager");
                Console.WriteLine("1. Add Gadget");
                Console.WriteLine("2. Remove Gadget");
                Console.WriteLine("3. Find Gadget");
                Console.WriteLine("4. Count Gadgets");
                Console.WriteLine("5. Insert Gadget at Position");
                Console.WriteLine("6. Reverse List");
                Console.WriteLine("7. Clear All Gadgets");
                Console.WriteLine("8. Display All Gadgets");
                Console.WriteLine("9. Display Gadgets by Day");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddGadget(gadgets);
                        break;
                    case "2":
                        RemoveGadget(gadgets);
                        break;
                    case "3":
                        FindGadget(gadgets);
                        break;
                    case "4":
                        Console.WriteLine($"Total gadgets: {gadgets.Count()}");
                        break;
                    case "5":
                        InsertGadgetAt(gadgets);
                        break;
                    case "6":
                        gadgets.Reverse();
                        Console.WriteLine("List reversed.");
                        break;
                    case "7":
                        gadgets.Clear();
                        Console.WriteLine("All gadgets cleared.");
                        break;
                    case "8":
                        gadgets.Display();
                        break;
                    case "9":
                        DisplayByDay(gadgets);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddGadget(GadgetLinkedList gadgets)
        {
            Console.Write("Enter gadget name: ");
            string name = Console.ReadLine();
            var days = InputDays();
            gadgets.Add(new Gadget(name, days));
            Console.WriteLine("Gadget added.");
        }

        static void RemoveGadget(GadgetLinkedList gadgets)
        {
            Console.Write("Enter gadget name to remove: ");
            string name = Console.ReadLine();
            if (gadgets.Remove(name))
                Console.WriteLine("Gadget removed.");
            else
                Console.WriteLine("Gadget not found.");
        }

        static void FindGadget(GadgetLinkedList gadgets)
        {
            Console.Write("Enter gadget name to find: ");
            string name = Console.ReadLine();
            var gadget = gadgets.Find(name);
            if (gadget != null)
                Console.WriteLine(gadget);
            else
                Console.WriteLine("Gadget not found.");
        }

        static void InsertGadgetAt(GadgetLinkedList gadgets)
        {
            Console.Write("Enter gadget name: ");
            string name = Console.ReadLine();
            var days = InputDays();
            Console.Write("Enter position (0-based): ");
            int pos = int.TryParse(Console.ReadLine(), out int val) ? val : 0;
            gadgets.InsertAt(new Gadget(name, days), pos);
            Console.WriteLine("Gadget inserted.");
        }

        static void DisplayByDay(GadgetLinkedList gadgets)
        {
            Console.WriteLine("Enter day of week (e.g., Monday): ");
            if (Enum.TryParse(Console.ReadLine(), true, out DayOfWeek day))
                gadgets.DisplayByDay(day);
            else
                Console.WriteLine("Invalid day.");
        }

        static List<DayOfWeek> InputDays()
        {
            Console.WriteLine("Enter days gadget is carried (comma-separated, e.g., Monday,Tuesday) or 'Everyday': ");
            string input = Console.ReadLine();
            var days = new List<DayOfWeek>();
            if (input.Equals("Everyday", StringComparison.OrdinalIgnoreCase))
            {
                days.AddRange((DayOfWeek[])Enum.GetValues(typeof(DayOfWeek)));
            }
            else
            {
                foreach (var part in input.Split(','))
                {
                    if (Enum.TryParse(part.Trim(), true, out DayOfWeek day))
                        days.Add(day);
                }
            }
            return days;
        }
    }
}
