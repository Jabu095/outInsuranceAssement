﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    /// <summary>
    /// Class object for the data read from the csv
    /// </summary>
    public class Person
    {
        #region "Properties"
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        #endregion

    }
}
