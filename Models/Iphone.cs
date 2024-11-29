namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor que recebe o número e passa para a classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }
    }
}
