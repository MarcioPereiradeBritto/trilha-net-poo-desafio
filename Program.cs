using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone (numero: "1264184641", imei: "as5d1541", modelo: "Iphone 4", memoria: 64);
iphone.InstalarAplicativo ("Disk Music", 70);
iphone.ReceberLigacao();
iphone.LigacaoPerdida();
Console.WriteLine("\n");
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia (numero: "1291285632", imei: "wp8r7682", modelo: "Nokia A5", memoria: 32);
nokia.InstalarAplicativo ("Disk Games", 20);
nokia.Ligar();
nokia.EmChamada();
nokia.ChamadaEncerrada();


