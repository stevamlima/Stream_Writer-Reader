using System;
using System.IO;

namespace project_11_10_17
{
    class Program
    {
        static void Main(string[] args)
    
        {
            Console.WriteLine("\nQuestionário|");
            Console.WriteLine("============");
            StreamWriter resp = new StreamWriter("respostas.csv",true);
            string [] perguntas = File.ReadAllLines("perguntas.txt");
            string [] respostas = new string[perguntas.Length];

            for(int i=0;i<perguntas.Length;i++)
            {
                Console.Write(perguntas[i]+":");
                respostas[i] = Console.ReadLine();
                resp.Write(respostas[i]+"; ");
            }
            resp.WriteLine();
            resp.Close();

        }
    }
}
