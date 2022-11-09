using System;

abstract class LasFiguras
{
    public string Nombre{ get; set;}
    public string Color{ get; set;}

    public LasFiguras( string Nombre, string Color)
    {
        this.Nombre = Nombre;
        this.Color = Color;
    }

    public void ImprimirLasFigura()
    {
        Console.WriteLine("Nombre de la figura: " + Nombre 
        + "\n su Color es: " + Color);
    }

    internal void calculoCirculo()
    {
        throw new NotImplementedException();
    }

    internal abstract void calculoA();
}