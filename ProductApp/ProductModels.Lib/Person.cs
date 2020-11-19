using System;
using System.Collections.Generic;
using System.Text;

namespace ProductModels.Lib
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CPR { get; set; }
        public Address Address { get; set; }
    }
}
