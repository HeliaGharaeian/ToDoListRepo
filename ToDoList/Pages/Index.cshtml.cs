using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;

namespace ToDoList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        DataBaseContext _dataBaseContext;

        [BindProperty]
        public ToDoListContext ToDoListContext { get; set; }

        public List<ToDoListContext> ToDoListContexts { get; set; }
        public IndexModel(ILogger<IndexModel> logger, DataBaseContext dataBaseContext)
        {
            _logger = logger;
            _dataBaseContext= dataBaseContext;

        }

        public void OnGet()
        {
                var data = (from todo in _dataBaseContext.toDoListContexts
                            select todo).ToList();
            ToDoListContexts = data;    
        }
        public ActionResult OnPost()
        {
            var toDoList = ToDoListContext;
            if(!ModelState.IsValid)
            {
                return Page();
            }
            toDoList.Id= 0;
            var result = _dataBaseContext.Add(toDoList);
            _dataBaseContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}