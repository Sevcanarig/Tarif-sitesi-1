using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TarifApp.Models;

namespace TarifApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View(Repository.Tarifler);
    }
    
    public IActionResult MySlider()
    {
        List<string> imageUrls = new List<string>
        {
            "5.jpg",
            "6.jpg",
            "7.jpg"
            // Diğer resim URL'leri...
        };

        return View(imageUrls);
    }
}

