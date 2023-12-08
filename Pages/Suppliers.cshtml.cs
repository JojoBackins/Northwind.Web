using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
    public IEnumerable<string>? Suppliers { get; set; }
    
    public void OnGet()
    {
        ViewData["Title"] = "Northwind B2B - Suppliers";

        Suppliers = new[]
        {
            "sam co"
        };

        //Suppliers = db.Suppliers 
        //    .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }
}
