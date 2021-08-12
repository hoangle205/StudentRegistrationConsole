using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class MenuStudent
    {
        public static void Menu2()
        {
            Console.WriteLine("Additional option here!");

            while (true)
            {
                Console.WriteLine("\n\n\nEnter an option: \n" +
                                    "1. Add a new course \n" +
                                    "2. Display available course \n" );

                var x = Console.ReadLine();
                int y;

                if (!Int32.TryParse(x, out y) || y < 1 || y > 2 )
                {
                    return;
                }

                switch (y)
                {
                    case 1:
                        string n; string d;
                        Console.WriteLine("\n\n\nEnter course name: ");
                        n = Console.ReadLine();
                        Console.WriteLine("Course description: ");
                        d = Console.ReadLine();

                        Menu.cDict.Add(++Menu.courseCount, new Course(n, d));
                        break;


                    case 2:

                        Console.Clear();
                        foreach (var i in Menu.cDict)
                        {
                            i.Value.Display();
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine("\n\n End of inner while loop \n\n");
            }

        }
    }
}
