using System.Reflection;
using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) 
            : base (numero, modelo, imei, memoria) {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
            // Lógica específica de instalação para o Nokia
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
