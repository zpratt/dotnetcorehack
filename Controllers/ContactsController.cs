using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcorehack.Repositories;
using dotnetcorehack.Models;
using Newtonsoft.Json;

namespace dotnetcorehack.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private IContactRepository _contactRepository;
        public ContactsController(IContactRepository contactRepository) {
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(_contactRepository.GetContacts());
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return Json(_contactRepository.GetContactById(id));
        }

        [HttpPost]
        public void Post([FromBody]Contact contact)
        {
            _contactRepository.createContact(contact);
        }

        [HttpPut]
        public void Put([FromBody]Contact contact)
        {
            _contactRepository.updateContact(contact);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contactRepository.deleteContact(id);
        }
    }
}
