﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MySite.Data;
using RazorPagesMovie.Models;

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

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
