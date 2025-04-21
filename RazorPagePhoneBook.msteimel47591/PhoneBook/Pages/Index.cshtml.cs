using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PhoneBookContext _context;

        public IndexModel(PhoneBookContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get; set; } = new List<Contact>();

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}

