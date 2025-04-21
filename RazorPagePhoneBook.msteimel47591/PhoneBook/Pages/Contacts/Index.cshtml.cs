using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly PhoneBook.Data.PhoneBookContext _context;

        public IndexModel(PhoneBook.Data.PhoneBookContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; } = string.Empty;

        public SelectList? Names { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var contactsQuery = _context.Contact.AsQueryable();

            if(!string.IsNullOrEmpty(SearchString))
            {
                contactsQuery = contactsQuery.Where(c => c.Name.ToLower().Contains(SearchString.ToLower()));
            }

            Contact = await contactsQuery.ToListAsync();
        }
    }
}
