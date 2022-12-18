using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 1212", imei: "11111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Iphone 14 Plus", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();