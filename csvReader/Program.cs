using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    public class Program
    {
        /// <summary>
        /// setting property to store list of people object
        /// </summary>
        private static List<Person> People;
       
        static void Main(string[] args)
        {
            try
            {
                int count = 0;
                using (StreamReader sr = new StreamReader("data.csv"))
                {
                    string line = "";
                    People = new List<Person>();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (count > 0)
                        {
                            var words = line.Split(',');
                            People.Add(new Person() { FirstName = words[0], LastName = words[1], Address = words[2], PhoneNumber = long.Parse(words[3]) });
                        }
                        count++;
                    }
                }
                var Main = new MainReader();
                Main.FirstLastName(People);
                Main.SortReapingNames(People);
                Main.Address(People);
                Console.WriteLine("Please find the generated text Files in the bin folder of the project");
                var read = Console.ReadLine();
               

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
       
    }
    }

