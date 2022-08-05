using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void UsarStremDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];
                while(true)
                {
                    //Lê o que o usuário digitou
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    //Escreve na memória
                    fs.Write(buffer, 0, bytesLidos);
                    //Libera o buffer para gravar no HD
                    fs.Flush();
                    //Mostra quantos bytes foram escritos
                    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
                }
            }
        }
    }
}
