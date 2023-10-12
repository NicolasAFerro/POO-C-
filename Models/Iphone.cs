using Testecsharp.Models;

namespace Testecsharp.Models
{

    public class Iphone : Smartphone
    {
        
        
        public Iphone(int numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }   
        public override void InstalarAplicativo(string nomeApp){ 
            Console.WriteLine($"o aplicativo {nomeApp} foi instalado");

        }
            
    }
}