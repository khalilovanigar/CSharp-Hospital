using System;
using System.Collections.Generic;

namespace ShowMenuNamespace
{
    class Program
    {
        static void Main()
        {
            var departments = new List<string> { "Pediatriya", "Travmatologiya", "Stomatologiya" };
            int depIndex = ShowMenu(departments, "Choose Department:");

            var doctors = new List<string> { "Sevda Ehmedova", "Selim Eliyev", "Leyla Memmedli" };
            int docIndex = ShowMenu(doctors, "Choose Doctor:");

            var hours = new List<string> { "09:00-11:00", "12:00-14:00", "15:00-17:00" };
            int hourIndex = ShowMenu(hours, "Choose an hour:");
            System.Console.WriteLine();

            System.Console.WriteLine($"You choose:");
            System.Console.WriteLine($"Department: {departments[depIndex]}");
            System.Console.WriteLine($"Doctor: {doctors[docIndex]}");
            System.Console.WriteLine($"Hour: {hours[hourIndex]}");
        }

        static int ShowMenu(List<string> options, string title)
        {
            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                System.Console.WriteLine(title);
                System.Console.WriteLine(new string('-', title.Length));

                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine($"> {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        System.Console.WriteLine($"  {options[i]}");
                    }
                }

                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.UpArrow)
                    selectedIndex = (selectedIndex == 0) ? options.Count - 1 : selectedIndex - 1;
                else if (key == ConsoleKey.DownArrow)
                    selectedIndex = (selectedIndex + 1) % options.Count;

            } while (key != ConsoleKey.Enter);

            return selectedIndex;
        }
    }
}
