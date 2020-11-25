using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MySite.Data;
using MySite.Models;

namespace MySite.Models
{
    public class IndexModel : PageModel
    {
        private readonly MySite.Data.MySiteContext _context;

        public IndexModel(MySite.Data.MySiteContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Companys { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CompanyGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Company
                                            orderby m.Tags
                                            select m.Tags;

            var company = from m in _context.Company
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                company = company.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CompanyGenre))
            {
                company = company.Where(x => x.Tags == CompanyGenre);
            }
            Companys = new SelectList(await genreQuery.Distinct().ToListAsync());
            Company = await company.ToListAsync();
        }
    }
}
