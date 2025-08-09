using System.ComponentModel.DataAnnotations;

namespace BLOG_MVC.Models;

public class Categoria
{
 public int id { get; set; }

[Required]
[StringLength(30)]
 public string Nome { get; set; }
}
