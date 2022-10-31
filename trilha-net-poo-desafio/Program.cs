using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("98765-4321", "C20", "123456-78-901234-5", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Iphone iphone = new Iphone("91235-5678", "iPhone 14 Pro Max", "098765-43-21098765-4", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");