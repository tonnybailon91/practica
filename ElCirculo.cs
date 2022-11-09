using System;

    class ElCirculo : LasFiguras
{
    public double NPI{get; set;}
    public double Radio_circulo{ get;set;}

    public ElCirculo(string Nombre, string Color, double NPI, double Radio_circulo)
    :base(Nombre, Color)
    {
        this.NPI = NPI;
        this.Radio_circulo = Radio_circulo;
    }
    internal override void calculoA()
    {
        double circuloArea;
        Radio_circulo= Math.Pow(Radio_circulo, 2);
        circuloArea= Radio_circulo*NPI;
        Console.WriteLine("el area del circulo es :");
        Console.WriteLine(circuloArea);
    }

    
    
}