using System;

class VerificaTriangulo
{
    static void Main()
    {
        // Leitura dos valores X, Y, Z
        Console.WriteLine("Digite o valor de X:");
        double X = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de Y:");
        double Y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor de Z:");
        double Z = Convert.ToDouble(Console.ReadLine());

        // Verificação se os valores podem formar um triângulo
        if (EhTriangulo(X, Y, Z))
        {
            Console.WriteLine("Os valores formam um triângulo.");

            // Determinação do tipo de triângulo
            if (X == Y && Y == Z)
            {
                Console.WriteLine("O triângulo é eqüilátero.");
            }
            else if (X == Y || Y == Z || X == Z)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo.");
        }
    }

    // Método para verificar se os valores formam um triângulo
    static bool EhTriangulo(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
