using dotnetcoreBlazor.Data;
using dotnetcoreBlazor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcoreBlazor.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        [Route("api/Contacts/Get")]
        public IEnumerable<Contact> Get()
        {
            return _contactRepository.GetRecords();
        }

        [HttpPost]
        [Route("api/Contacts/Create")]
        public void Create([FromBody]Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.AddRecord(contact);
            }
        }

        [HttpGet]
        [Route("api/Contacts/Details/{id}")]
        public Contact Details(int id)
        {
            return _contactRepository.GetSingleRecord(id);
        }

        [HttpPut]
        [Route("api/Contacts/Edit")]
        public void Edit([FromBody]Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.UpdateRecord(contact);
            }
        }

        [HttpDelete]
        [Route("api/Contacts/Delete/{id}")]
        public void DeleteConfirmed(int id)
        {
            _contactRepository.DeleteRecord(id);
        }
    }
}
