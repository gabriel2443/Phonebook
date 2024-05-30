using Microsoft.EntityFrameworkCore;
using Phonebook.Models;

namespace Phonebook.Data;

public class PhonebookContext : DbContext
{
    public DbSet<ContactDetails> ContactDetail { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\PhonebookDb;Integrated Security=true");
    }
}