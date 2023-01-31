using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu(){
            Console.Clear();
            System.Console.WriteLine("Digite o opção desejada de contagem. \r\n 1 = segundos \r\n 2 = minutos \r\n 3 = horas \r\n 4 = Sair");
            int cont = int.Parse(Console.ReadLine());

            switch(cont){
                case 1: Start(1000, ".0seconds");break;
                case 2: Start(60000, ".0minutes");break;
                case 3: Start(360000, ".0hours");break;
                case 4: Console.WriteLine("Encerrando o contador, até a proxima.");break;
            }
        }

        static void Start(int time, string decimais){
        
        Console.WriteLine("Digite o tempo desejado em segundos.");
        int contador = int.Parse(Console.ReadLine());

        for(int c = 0; c<= contador; c++){
            Console.Clear();
            System.Console.WriteLine(c + decimais);
            Thread.Sleep(time);
        }
        Console.WriteLine("Contagem finalizada");
        Thread.Sleep(2000);
        Menu();
        }
    }
}