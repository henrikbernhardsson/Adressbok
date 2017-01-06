using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adressbook.Models
{
    public class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Adress adress { get; set; }
    }
}