//using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Testecsharp.Models;

namespace Testecsharp.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    { 

       
        public Nokia(int numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        } 
        public override void InstalarAplicativo(string nomeApp) { 
            Console.WriteLine($"o aplicativo {nomeApp} foi instalado");
        }
    }
}