namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" DIO !!!!!!

    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            
        }
        // Sobrescrever o método abstrato da classe base

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
            // Lógica específica de instalação para o iPhone
        }


        // TODO: Sobrescrever o método "InstalarAplicativo" DIO!!!!!!
    }
}
