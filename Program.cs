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

        
            using(FileStream fs = new FileStream("respostas.csv",FileMode.Truncate))
            {
                fs.Flush();
            }
    
            StreamWriter resp = new StreamWriter("respostas.csv",true);
            string [] perguntas = File.ReadAllLines("perguntas.txt");
            string [] respostas = new string[perguntas.Length]; //cria um array com o número de perguntas do arquivo

            FazerPerguntas(perguntas, respostas, resp);
            int a=1;
            while(a!=0)
            {
                Console.Write("\nVocê deseja cadastrar mais alguém? S/N: ");
                char cond = char.Parse(Console.ReadLine());
                switch(cond)
                {
                    case 'S': case 's':
                    FazerPerguntas(perguntas, respostas, resp);
                    resp.Close();
                    break;
                    case 'N': case 'n':
                    a = 0;
                    break;
                }
            }
        }

        static void FazerPerguntas(string[] perguntas, string[] respostas,StreamWriter resp)
        {

        for(int i=0;i<perguntas.Length;i++)
            {
            Console.Write(perguntas[i]+":");
            respostas[i] = Console.ReadLine();
            resp.Write(respostas[i]+"; ");
            }
            resp.WriteLine();
        }
        
    }
}
