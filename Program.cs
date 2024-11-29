using DesafioPOO.Models;

class Program
{
    public static void Main(string[] args)
    {
        // Criando um objeto da classe Nokia, agora com todos os parâmetros
        Nokia nokia = new Nokia("123456789", "Nokia 1100", "123456789012345", 32); // Passando todos os parâmetros para o construtor
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        // Criando um objeto da classe Iphone, com os parâmetros corretos
        Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128); // Passando todos os parâmetros
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}

