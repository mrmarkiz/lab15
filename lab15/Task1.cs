using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    internal class Task1
    {
        public static void Run()
        {
            string path = "text.txt";
            int choice;
            do
            {
                Console.Write("Enter what to do(1 - show file contents, 2 - write 3 string in file): ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        try
                        {
                            using (var fs = new FileStream(path, FileMode.Open))
                            {
                                using (var sr = new StreamReader(fs))
                                {
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error collapsed: {ex.Message}");
                        }
                        break;
                    case 2:
                        using (var fs = new FileStream(path, FileMode.Append))
                        {
                            using (var sw = new StreamWriter(fs))
                            {
                                Console.WriteLine("Enter 3 string:");
                                StringBuilder input;
                                for (int i = 0; i < 3; i++)
                                {
                                    input = new StringBuilder(Console.ReadLine());
                                    sw.WriteLine(input);
                                }
                            }
                        }
                        break;

                }
            } while (choice != 0);
        }
        
    }
}
