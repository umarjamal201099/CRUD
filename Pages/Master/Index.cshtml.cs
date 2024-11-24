using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using TaskManager;

namespace CRUD.Pages.Master
{
    public class IndexModel : PageModel
    {
        private readonly TaskManager.TaskManagerContext _context;

        public IndexModel(TaskManager.TaskManagerContext context)
        {
            _context = context;
        }

        public IList<TaskItem> TaskItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TaskItem = await _context.Tasks.ToListAsync();
        }
    }
}
