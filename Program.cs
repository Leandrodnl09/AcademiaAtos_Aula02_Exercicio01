namespace Aula02Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            int numero1 = 35;
            int numero2 = 40;

            double media = ((double)numero1 + (double)numero2) / 2;

            Console.WriteLine("A média aritmética é: " + media);
        }
    }
}