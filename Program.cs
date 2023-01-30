using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "123456", modelo: "Tijolão", imei: "111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "223456", modelo: "Iphone X", imei: "111211111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");