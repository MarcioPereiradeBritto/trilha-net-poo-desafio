namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria) :base(numero, imei, modelo, memoria)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public override void InstalarAplicativo(string nomeApp, int dimensao)
        {
            if (dimensao <= Memoria)
            {
                Console.WriteLine($"Instalando {nomeApp} em Smartphone {this.Modelo}\nDisk Music instalado com sucesso!");
            }
            else 
            {
                Console.WriteLine($"Falha ao Instalar o {nomeApp} em {this.Modelo} (Arquivo não suportado!)");
            }
        }
    }
}