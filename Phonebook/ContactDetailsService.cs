using Phonebook.Data;
using Phonebook.Models;

namespace Phonebook
{
    public class ContactDetailsService
    {
        private readonly PhonebookContext context = new PhonebookContext();

        public void AddContact(string name, string email, string phone)
        {
            var contactDetails = new ContactDetails()
            {
                Name = name,
                Email = email,
                Phone = phone
            };

            context.Add(contactDetails);
            context.SaveChanges();
        }

        public List<ContactDetails> GetContacts()
        {
            var contacts = context.ContactDetail.OrderBy(x => x.Id).ToList();
            return contacts;
        }

        public void EditContacts(string name, string email, string phoneNum)
        {
            var updatedContacts = new ContactDetails()
            {
                Name = name,
                Email = email,
                Phone = phoneNum
            };

            context.Update(updatedContacts);
            context.SaveChanges();
        }

        public void DeleteContacts(ContactDetails contactDetails)
        {
            context.Remove(contactDetails);
            context.SaveChanges();
        }
    }
}