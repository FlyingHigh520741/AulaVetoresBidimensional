namespace VetoresBidimensionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] agenda;
            int i;

            agenda = new string[3, 3];

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"Faça o {i + 1}º cadastro: \n\n");
                Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
                agenda[i, 0] = Console.ReadLine();
                Console.Write($"Digite o cpf da {i + 1}ª pessoa: ");
                agenda[i, 1] = Console.ReadLine();
                Console.Write($"Digite o bairro da {i + 1}ª pessoa: ");
                agenda[i, 2] = Console.ReadLine();
                Console.WriteLine("\n\n");

            }

            for (i = 0; i < 3; i++)
            {
                
                Console.WriteLine($"-----Cadastro {i}-----");
                Console.WriteLine(agenda[i, 0]);
                Console.WriteLine(agenda[i, 1]);
                Console.WriteLine(agenda[i, 2]);
                Console.WriteLine("\n\n");
            }
        }

        }
}
