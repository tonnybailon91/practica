using System;

class ElRectangulo : LasFiguras
{
    public double Base{get; set;}
    public double Altura{get; set;}


    public ElRectangulo(string Nombre, string Color, double Base, double Altura)
    :base(Nombre, Color)
    {
        this.Base = Base; 
        this.Altura = Altura;
    }

    internal override void calculoA()
    {
        double rectanguloArea;
        rectanguloArea= Base*Altura;
        Console.WriteLine("area del rectangulo");
        Console.WriteLine(rectanguloArea);
    }
}