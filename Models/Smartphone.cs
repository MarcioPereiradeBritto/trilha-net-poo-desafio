using System.Runtime;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        private string IMEI { get; set; }

        private string Modelo { get; set; }

        private int Memoria { get; set; }



        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            IMEI = imei;
            Modelo = modelo;
            Memoria = memoria;
            
        }

        protected Smartphone (string numero)
        {
            Numero = numero;
        }
        
       
        public void Ligar()
        {
            Console.WriteLine("Ligando para João...");
        }

        public void EmChamada()
        {
            Console.WriteLine("Em chamada com João");
        }

        public void ChamadaEncerrada()
        {
            Console.WriteLine("Chamada com João encerrada");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de Lucas...");
        }

        public void LigacaoPerdida()
        {
            Console.WriteLine("Ligação perdida de Lucas");
        }

        public abstract void InstalarAplicativo(string nomeApp, int dimensao);

         
    }
}