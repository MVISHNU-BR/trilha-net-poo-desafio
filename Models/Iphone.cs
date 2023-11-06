namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        

        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o  {nomeApp} num Iphone");
            Console.WriteLine("Tomara que a bateria aguente até o fim da instalação.");
            
        }
    }
        
}