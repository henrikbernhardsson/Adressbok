using Adressbook.Models;
using Adressbook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adressbook.Controllers
{
    public class PersonController : Controller
    {
        public static List<Person> people = new List<Person>();
        // GET: Person
        public ActionResult Index()
        {
            return View(people);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person Person, Adress adress)
        {
            var _person = new Person()
            {
                ID = Guid.NewGuid(),
                Name = Person.Name,
                PhoneNumber = Person.PhoneNumber,
                adress = adress,

            };
            _person.adress.Updated = DateTime.Now;
            people.Add(_person);
            return View();
        }
        public ActionResult List()
        {
            return View(people);
        }
        
        public ActionResult Delete(Guid id)
        {
            var person = people.Where(p => p.ID == id).FirstOrDefault();
            people.Remove(person);
            return PartialView("List", people);
        }
        public ActionResult Edit(Guid id)
        {
            var person = people.Where(p => p.ID == id).FirstOrDefault();
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            people.FirstOrDefault(p => p.ID == person.ID).adress.City = person.adress.City;
            people.FirstOrDefault(p => p.ID == person.ID).adress.Street = person.adress.Street;
            people.FirstOrDefault(p => p.ID == person.ID).Name = person.Name;
            people.FirstOrDefault(p => p.ID == person.ID).PhoneNumber = person.PhoneNumber;
            people.FirstOrDefault(p => p.ID == person.ID).adress.Updated = DateTime.Now;
            return View();
        }
    }
}