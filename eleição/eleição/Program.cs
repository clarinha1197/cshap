using System;

namespace eleição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            int qtdcand26 = 0;
            int qtdcand44 = 0;
            int qtdcand56 = 0;
            int qtdnulo = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Digite seu nome :");
                string nome = Console.ReadLine();
                Console.WriteLine("Vote em algum dos candidatos a seguir :");
                Console.WriteLine("26 - João");
                Console.WriteLine("44 - Marta");
                Console.WriteLine("56 - Tebel");
                Console.WriteLine("0 - Nulo");
                Console.WriteLine("Digite apenas o número :");
                int meuvoto = Convert.ToInt32(Console.ReadLine());

                if (meuvoto == 26) { qtdcand26 = qtdcand26 + 1; }
                else if (meuvoto == 44) { qtdcand44 = qtdcand44 + 1; }
                else if (meuvoto == 56) { qtdcand56 = qtdcand56 + 1; }
                else qtdnulo = qtdnulo + 1;

                Console.WriteLine("Deseja continuar ?");
                Console.WriteLine("Sim | Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim") { continuar = true; } else { continuar = false; }

            }
        }
    }
}
