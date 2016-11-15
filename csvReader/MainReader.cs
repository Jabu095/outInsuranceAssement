using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    /// <summary>
    /// The class implemeting the ICsv interface
    /// </summary>
    public class MainReader : ICsvReader
    {
        #region "Address function"
        public void Address(List<Person> People)
        {
            var sorted = People.OrderBy(x => x.FirstName).ThenBy(x => x.FirstName).ToList();

            //sorting the address by street name acseding
            var asending = sorted.OrderBy(x => x.Address.StringAddress()).ToList();
            //writing the results onto the text file 
            using (StreamWriter sw = new StreamWriter("Address.txt"))
            {
                foreach (var item in asending)
                {
                    sw.WriteLine(string.Format("{0}", item.Address));
                }
            }
        }
        #endregion

        #region "Sorting Names"
        public void FirstLastName(List<Person> People)
        {
            var sorted = People.OrderBy(x => x.FirstName).ThenBy(x => x.FirstName).ToList();
            using (StreamWriter sw = new StreamWriter("acedingNames.txt"))
            {
                foreach (var item in sorted)
                {
                    sw.WriteLine(string.Format("{0}, {1}", item.FirstName, item.LastName));
                }
            }
        }
        #endregion

        #region "Counting Firstnames"
        public void SortReapingNames(List<Person> People)
        {
            var sorted = People.OrderBy(x => x.FirstName).ThenBy(x => x.FirstName).ToList();

            //LINQ statement to check the dublicates and make a count of the object also removing the dublicate records
            var xSorted = from obj in sorted group obj by obj.FirstName into g select new { Name = g.Key, Duplicatecount = g.Count() };

            var asending = xSorted.OrderBy(x => x.Duplicatecount).ToList();

            //Sorting the objects in descending order of the duplicate counts
            asending.Reverse();
            using (StreamWriter sw = new StreamWriter("Dublicates.txt"))
            {
                foreach (var item in asending)
                {
                    sw.WriteLine(string.Format("{0}, {1}", item.Name, item.Duplicatecount));
                }
            }
        }
        #endregion
    }
}
