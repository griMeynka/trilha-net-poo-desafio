namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // Passando os parâmetros para o construtor da classe base (Smartphone)
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Nokia...");
        }
    }
}

