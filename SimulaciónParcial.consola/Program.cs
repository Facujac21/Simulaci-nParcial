using System;

class Program
{
    static void Main(string[] args)
    {

      
        Console.WriteLine("Ingrese el radio de giro del cono:");
        double radio = Convert.ToDouble(Console.ReadLine());

        if (radio > 0)
        {
           

            Console.WriteLine("Ingrese la altura del cono:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double generatriz = CalcularGeneratriz(radio, altura);

            if (altura > 0)
            {
                double area = CalcularAreaCono(radio, generatriz);
                double volumen = CalcularVolumenCono(radio, altura);

                Console.WriteLine("El área del cono es: " + area);
                Console.WriteLine("El volumen del cono es: " + volumen);

            }
            else
            {
                Console.WriteLine("Los valores ingresados no son válidos");
            }
            
        }
        else
        {
            Console.WriteLine("Los valores ingresados no son válidos.");
        }

        Console.ReadLine();
    }

    static double CalcularGeneratriz(double radio, double altura)
    {
        double generatriz = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(radio, 2));
        return generatriz;
    }

    static double CalcularAreaCono(double radio, double generatriz)
    {
        double area = Math.PI * radio * (radio + generatriz);
        return area;
    }

    static double CalcularVolumenCono(double radio, double altura)
    {
        double volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        return volumen;
    }
}