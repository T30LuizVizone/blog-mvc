using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BLOG_MVC.Models;

namespace BLOG_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Mensagem"] = "Oi mundo";
        Categoria categoria = new ();
        categoria.id = 1;
        categoria.Nome = "Tecnologia";
        Categoria categoria2 = new () 
        {
            id = 2,
            Nome = "IA"
        };
        
        List<Postagem> postagens = [
            new (){
                Id = 1,
                Nome = "Saiu o ChatGPT 5",
                CategoriaId = 2,
                categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "bvasbvçobnbvaklabnçkvbkçxbvçkbn",
                Texto = "vaskbvabs vboj "
            }
        ];
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
