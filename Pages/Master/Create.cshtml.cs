using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD.Models;
using TaskManager;

namespace CRUD.Pages.Master
{
    public class CreateModel : PageModel
    {
        private readonly TaskManager.TaskManagerContext _context;

        public CreateModel(TaskManager.TaskManagerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TaskItem TaskItem { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tasks.Add(TaskItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
