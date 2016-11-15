using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    /// <summary>
    /// An interface to define the contract methods
    /// </summary>
    public interface ICsvReader
    {
        /// <summary>
        /// Function to check the reapting names
        /// </summary>
        void SortReapingNames(List<Person> People);
        /// <summary>
        /// function to sort firstname by asceding
        /// </summary>
        void FirstLastName(List<Person> People);
        /// <summary>
        /// function to sort the address
        /// </summary>
        void Address(List<Person> People);

    }
}
