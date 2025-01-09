using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "970707070", modelo: "Modelo 1", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Genshin Impact");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "960706070", modelo: "Modelo 2", imei: "222222222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Ragnarok Origin");