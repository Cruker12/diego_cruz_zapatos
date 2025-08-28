// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Zapatos
{
    public int Id;
    public string? Nombre;
    public string? Color_Zapato;
    public decimal Medida_Pie;
    public Ventas? Ventas;
    public List<Cordones>? Cordones;
    public List<Tipos>? Tipos;
    public int erro2;
}

public class Cordones
{
    public int Id;
    public string? Color_Cordon;
    public decimal Cant_Metros;
}

public class Tipos
{
    public int Id;
    public string? Nombre_Tipo;
}

public class Ventas
{
    public int Id;
    public string? Tipo_Venta;

}

