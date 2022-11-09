internal class Program
{
    private static void Main(string[] args)
    {
        List<LasFiguras> listFiguras = new List<LasFiguras>();

        ElCuadrado cuadro = new ElCuadrado
        (
            "cuadrado", "Blu", 13
        );
        cuadro.ImprimirLasFigura();
        listFiguras.Add
        (
            cuadro
        );

        ElRectangulo rectangul = new ElRectangulo
        (
            "rectangulo", "Rosado", 9, 15
        );
        rectangul.ImprimirLasFigura();
        listFiguras.Add
        (
            rectangul
        );
        ElCirculo cirlulo1 = new ElCirculo
        (
            "circulo", "trasparente", 5, 3.14
        );
        cirlulo1.ImprimirLasFigura();
        listFiguras.Add(cirlulo1);
            
        foreach(LasFiguras item in listFiguras)
        {
            item.calculoA();
        }
    }
    
}