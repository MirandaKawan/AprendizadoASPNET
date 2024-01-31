using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNET.Models;
using TesteEmMvcUser;

namespace ASPNET.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        HomeUser usuario = new HomeUser();

        usuario.Usuario = "Kawan";
        usuario.Senha = "Careca";

        return View(usuario);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
