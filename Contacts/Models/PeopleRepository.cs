using Contacts.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{
    public class PeopleRepository
    {
        //static int personId = people.Count;
        private readonly ContactContext context;

        public PeopleRepository(ContactContext context)
        {
            this.context = context;
        }


        //List<Person> people = new List<Person>
        //{
        //    new Person{Id = 1, Name = "Simon", Email = "simon@mail.com"},
        //    new Person{Id = 2, Name = "Elin", Email = "elin@mail.com"},
        //    new Person{Id = 3, Name = "Fredrik", Email = "fredrik@mail.com"}
        //};
        

        public void AddPerson(Contact contact)
        {
            //person.Id = ++personId;
            //people.Add(person);
            context.Add(contact);
            context.SaveChanges();
        }

        public async Task<Contact[]> GetAllPeopleAsync()
        {
            //return people.ToArray() ; 
            return await context.Contact
                .OrderBy(o => o.Name)
                .ToArrayAsync();
        }

        public void RemovePerson(int id)
        {
            context.Contact.Remove(GetContactById(id));
            context.SaveChanges();
        }

        public Contact GetContactById(int id)
        {
            return context.Contact.Find(id);
        }

        public void UpdatePerson(Contact contact)
        {
            context.Contact.Update(contact);
            context.SaveChanges();
        }
     }      
}
