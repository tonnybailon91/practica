using System;

class ElCuadrado : LasFiguras
{
    public int LosLados{ get;set;}

    public ElCuadrado (string Nombre, string Color, int LosLados)
    : base( Nombre, Color)
    {
        this.LosLados = LosLados;
    }
    internal override void calculoA()
    {
        int cuadradoArea;
        cuadradoArea= LosLados*LosLados;
        Console.WriteLine("area del cuadrado");
        Console.WriteLine(cuadradoArea);
    }


}