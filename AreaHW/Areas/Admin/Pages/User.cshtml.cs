using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AreasHW.Areas.Admin.Pages
{
    public class UserModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public void OnGet()
        {
        }
        //https://localhost:5110/admin/user/3/dan
    }
}
