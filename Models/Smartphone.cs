namespace Testecsharp.Models
{
    public abstract class Smartphone
    {
        public int Numero ;
        private string _Modelo;
        private string _IMEI ;
        private int _Memoria;
        public Smartphone(int numero,string modelo, string imei, int memoria)
        {// estava dando errado pois tinha feito esse constrututor para tudo; 
        // mas nas classes filhas estava passando um de cada vez
            Numero = numero;
            _Modelo=modelo; 
            _IMEI=imei; 
            _Memoria=memoria;
        }
        public void Apresentar(){ 
            Console.WriteLine($"numero:{Numero}, modelo: {_Modelo}"); 
            Console.WriteLine($"imei:{_IMEI}, memoria: {_Memoria}");
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