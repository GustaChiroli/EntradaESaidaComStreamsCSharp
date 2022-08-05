using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output
using System.Globalization;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            File.WriteAllText("escrevendoComAClaseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClaseFile.txt criado");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

            Console.ReadLine();


            //só usar quando souber que não é um arquivo grande
            //guardando todo o arquivo na variavel linhas
            var linhas = File.ReadAllLines("contas.txt");
            //laço para escrever linha por linha
            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);



            UsarStremDeEntrada();


            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();
        }
    }
} 
 