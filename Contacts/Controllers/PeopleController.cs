using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contacts.Models;
using Contacts.Models.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contacts.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleRepository repository;

        public PeopleController(PeopleRepository repository)
        {
            this.repository = repository;
        }
        

        // GET: /<controller>/
        [Route("")]
        public async Task<IActionResult> Index()
        {
            var model = await repository.GetAllPeopleAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            repository.AddPerson(contact);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(repository.GetContactById(id));
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            repository.UpdatePerson(contact);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repository.RemovePerson(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
