using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "014789", modelo: "Modelo 1", imei: "222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "789456", modelo: "Modelo 2", imei: "6555555", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");