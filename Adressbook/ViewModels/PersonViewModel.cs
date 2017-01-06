using Adressbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adressbook.ViewModels
{
    public class PersonViewModel
    {
        public Person person { get; set; }
        public Adress adress { get; set; }

    }
}