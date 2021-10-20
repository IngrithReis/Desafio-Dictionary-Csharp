using System;
using System.Collections.Generic;
using System.IO;

namespace Aula_213
{
    class Program
    {

        static void Main(string[] args)
        {
            
           
            var texto = @"C:\Users\...\contagemVotos.txt";

            Console.WriteLine("Contador de votos! ");
            Console.WriteLine("OBS: Texto deve estar em formato .csv com candidato, votos em cada linha ");
            Console.WriteLine("Digite o caminho do arquivo de texto conforme exemplo: ");
            Console.WriteLine(texto );

            string sourcepath = Console.ReadLine();

            FileInfo file = new FileInfo(sourcepath);
            string[] linhas = File.ReadAllLines(sourcepath);

            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(",");

                {
                    string nome = dados[0];
                    int votos = int.Parse(dados[1]);
                   
                   

                    if (candidatos.ContainsKey(nome))
                    {

                        candidatos[nome] += int.Parse(dados[1]);

                    }
                    else 
                    {
                        candidatos[nome] = int.Parse(dados[1]);
                    }
                   
                }

            }

            foreach (KeyValuePair<string, int> candidato in candidatos)
            {
                Console.WriteLine(candidato.Key + ":" + candidato.Value);
            }
        }
    }
}
