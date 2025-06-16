using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(); // abre a página
    }

    [HttpPost]
    public IActionResult Index(Pessoa pessoa)
    {
        return View(pessoa); // recebe dados do form e envia pra view
    }
}