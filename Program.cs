using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO.Models
{
    class Program
    {
        static void Main()
        {
            // Criar uma instância da classe Iphone
            Iphone meuIphone = new Iphone("123456789", "iPhone X", "ABC123", 128);

            // Chamar métodos da classe base
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();

            // Chamar método da classe derivada
            meuIphone.InstalarAplicativo("WhatsApp");

            meuIphone.Ligar();
            
        }
    }
}
