using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Menu
    {

        // INIT COURSE
        public static Dictionary<int, Course> cDict = new Dictionary<int, Course>();
        public static int courseCount = 0;





        public static Dictionary<int, Student> sDict = new Dictionary<int, Student>();
        public static int counter = 0;
        public static void MainMenu()
        {
            
            while (true)
            {
                Console.WriteLine(  "\n\n\nEnter an option: \n" +
                                    "1. Add a new student \n" +
                                    "2. Display all students"); 
                
                var x = Console.ReadLine();
                int y;

                if ( !Int32.TryParse(x, out y) || y < 1 || y > 2 )
                {
                    return;
                }

                switch (y)
                {
                    case 1: // ADD
                        
                        Console.Clear();
                        Console.WriteLine("Add student: ");
                        sDict.Add(++counter, new Student(counter, Console.ReadLine()));
                        break;
                    case 2: // SHOW
                        
                        Console.Clear();
                        foreach (var i in sDict)
                        {
                            i.Value.Display();
                        }

                        MenuStudent.Menu2();

                        break;
                }

                Console.Clear();
                Console.WriteLine("\n\n End of outer while loop \n\n");
            }


            
            

        }
    }
}
