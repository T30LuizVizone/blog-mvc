using System.ComponentModel.DataAnnotations;

namespace BLOG_MVC.Models;

public class Postagem
{
public int id { get; set; }

[Required]
[StringLength(100)]

public string Nome { get; set; }

public int CategoriaId { get; set; }

public Categoria Categoria { get; set; }

[DataType(DataType.Date)]
public DateTime DataPostagem { get; set; }

public string Descrição { get; set; }

public string Texto { get; set; }

public string Thumbnail { get; set; }

public string Foto { get; set; }




}

