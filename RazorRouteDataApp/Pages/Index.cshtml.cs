using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorRouteDataApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? Id { set; get; }

        public IndexModel()
        {
            
        }

        public void OnGet()
        {
            //Id = RouteData.Values["id"];
        }
    }
}