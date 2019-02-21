using DateTimePicker;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        [DataType(DataType.Date)]
        [ModelBinder(typeof(DateTimeModelBinder))]
        public DateTime? DateOfBirth { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        [ModelBinder(typeof(DateTimeModelBinder))]
        public DateTime Created { get; set; } = DateTime.UtcNow.Date;

        public string CurrentUiCulture { get; set; } = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;

        public void OnGet([ModelBinder(typeof(DateTimeModelBinder))] DateTime? dateofBirth)
        {
            DateOfBirth = dateofBirth;
        }

        public void OnPost()
        {
            Debugger.Break();
        }
    }
}
