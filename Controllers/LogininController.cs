using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNET.Models;
using TesteEmMvcUser;

namespace ASPNET.Controllers;

public class LogininController : Controller
{

    public IActionResult Loginin()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult DeleteWarning()
    {
        return View();
    }

}