using System.Collections.Generic;
using System.Linq;
using dotnetcorehack.Models;

namespace dotnetcorehack.Repositories {

    public class ContactRepository : IContactRepository {
        private DataContext _dataContact;
        public ContactRepository(DataContext dataContext) {
            _dataContact = dataContext;
        }
        public Contact GetContactById(int id) {
            return _dataContact.Contacts.FirstOrDefault(t => t.id == id);
        }

        public List<Contact> GetContacts() {
            return _dataContact.Contacts.ToList();
        }

        public void updateContact(Contact contact) {
            _dataContact.Contacts.Update(contact);
            _dataContact.SaveChanges();
        }

        public void createContact(Contact contact) {
            _dataContact.Contacts.Add(contact);
            _dataContact.SaveChanges();
        }

        public void deleteContact(int id) {
            _dataContact.Contacts.Remove(_dataContact.Contacts.FirstOrDefault(n => n.id == id));
            _dataContact.SaveChanges();
        }
    }

    public interface IContactRepository {
        Contact GetContactById(int id);
        List<Contact> GetContacts();
        void updateContact(Contact contact);
        void createContact(Contact contact);
        void deleteContact(int id);
    }
    
}
