namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } // Adicionada a propriedade Modelo
        public string IMEI { get; set; }   // Adicionada a propriedade IMEI
        public int Memoria { get; set; }   // Adicionada a propriedade Memoria

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;  // Passando o parâmetro para a propriedade Modelo
            IMEI = imei;      // Passando o parâmetro para a propriedade IMEI
            Memoria = memoria; // Passando o parâmetro para a propriedade Memoria
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
