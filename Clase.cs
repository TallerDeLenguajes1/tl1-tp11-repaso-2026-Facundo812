using System.Text.Json.Serialization;

namespace EspacioClase;

public class Producto
{
    //[JsonPropertyName("")]
    public int Id{get; set;}
    public string? Nombre{get; set;}
    public float Precio{get; set;}
    public int Stock{get; set;}
    public string? Categoria{get; set;}
}

public class ProductoAlt
{
    public string? Nombre{get; set;}
    public float ValorTotalStock{get; set;}
    public bool NecesitaRepo{get; set;}
}