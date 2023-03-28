using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorRouteDataApp.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Category { set; get; }

        [BindProperty(SupportsGet = true)]
        public int? Id { set; get; }
        public PrivacyModel()
        {
            
        }
        public void OnGet()//string category, int id)
        {
            //Category = category; //(string)RouteData.Values["category"];
            //Id = id; //(int)RouteData.Values["id"];
        }
    }
}