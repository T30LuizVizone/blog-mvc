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
        
        Categoria Tecnologia = new Categoria();
       Tecnologia.Id = 1;
       Tecnologia.Nome = "Tecnologia";

        Categoria categoria2 = new () 
        {
            Id = 2,
            Nome = "IA"
        };

        Categoria motos = new(3,"moto");
        
        List<Postagem> postagens = [
            new (){
                Id = 1,
                Nome = " Motos ",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "A nova" Africa Twin",
                Texto = " A grande novidade da Africa Twin 2025 é a adoção de uma roda dianteira de 19 polegadas na versão Adventure Sports. Essa mudança visa otimizar o comportamento da moto em estradas asfaltadas, sem comprometer suas capacidades off-road. ",
                Thumbnail = "BLOG-MVC/wwwroot/img/Africa Twin 2025.png",
                Foto = "BLOG-MVC/wwwroot/img/Africa Twin 2025.png",
            },

             new (){
                Id = 1,
                Nome = " Motos ",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Nova CG-160",
                Texto = "Outra grande novidade da família CG 2025 é que todas as versões possuem rodas de liga leve, assim como os freios na dianteira são a disco. Na versão topo de linha, CG 160 Titan, estreia o sistema antitravamento ABS (Anti-lock Brake System) na dianteira e o freio a disco na traseira.",
                Thumbnail = "BLOG-MVC/wwwroot/img/CG-160.jpg",
                Foto = "BLOG-MVC/wwwroot/img/CG-160.jpg",
            },
        ];
        return View(postagens);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}



