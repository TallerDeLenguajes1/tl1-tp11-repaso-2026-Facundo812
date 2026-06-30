using System;
using System.IO;
using System.Text.Json;
using EspacioClase;

string path = Directory.GetCurrentDirectory()+@"\productos1.json";
string json = File.ReadAllText(path);

List<Producto>? listaProductos = JsonSerializer.Deserialize<List<Producto>>(json);
List<ProductoAlt> listaNueva = new List<ProductoAlt>();
int i = 0;

foreach(Producto p in listaProductos)
{
    float ValorTotalStock = p.Precio * p.Stock;

    bool NecesitaRepo;
    if(p.Stock < 3)
    {
        NecesitaRepo = true;
    }
    else
    {
        NecesitaRepo = false;
    }

    ProductoAlt f = new ProductoAlt();
    f.Nombre = p.Nombre;
    f.ValorTotalStock = ValorTotalStock;
    f.NecesitaRepo = NecesitaRepo;

    listaNueva.Add(f);
    i++;
}

string nuevoJson = JsonSerializer.Serialize(listaNueva);
string ruta = Directory.GetCurrentDirectory()+@"\Reporte.json";
File.WriteAllText(ruta,nuevoJson);
