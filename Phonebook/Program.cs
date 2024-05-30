using Phonebook.Data;
using Phonebook.Models;

var context = new PhonebookContext();

var contactDetail = new ContactDetails
{
    Name = "asd",
    Email = "aiauaua",
    Phone = "hauhau"
};

context.Add(contactDetail);

context.SaveChanges();