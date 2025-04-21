using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;

namespace PhoneBook.Models;

public static class SeedDatabase
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PhoneBookContext(
            serviceProvider.GetRequiredService<DbContextOptions<PhoneBookContext>>()))
        {

            if (context.Contact.Any())
            {
                return;
            }

            context.Contact.AddRange(
                new Contact
                {
                    Name = "John Doe",
                    PhoneNumber = "(123)-456-7890",
                    Email = "johndoe@example.com"
                },
                new Contact
                {
                    Name = "Jane Smith",
                    PhoneNumber = "(987)-654-3210",
                    Email = "janesmith@example.com"
                },
                new Contact
                {
                    Name = "Alice Johnson",
                    PhoneNumber = "(555)-123-4567",
                    Email = "alice.johnson@example.com"
                },
                new Contact
                {
                    Name = "Bob Brown",
                    PhoneNumber = "(555)-987-6543",
                    Email = "bob.brown@example.com"
                },
                new Contact
                {
                    Name = "Charlie Davis",
                    PhoneNumber = "(444)-555-6666",
                    Email = "charlie.davis@example.com"
                },
                new Contact
                {
                    Name = "Diana Evans",
                    PhoneNumber = "(333)-444-5555",
                    Email = "diana.evans@example.com"
                },
                new Contact
                {
                    Name = "Ethan Harris",
                    PhoneNumber = "(222)-333-4444",
                    Email = "ethan.harris@example.com"
                },
                new Contact
                {
                    Name = "Fiona Green",
                    PhoneNumber = "(111)-222-3333",
                    Email = "fiona.green@example.com"
                }
            );

            context.SaveChanges();
        }
    }
}
