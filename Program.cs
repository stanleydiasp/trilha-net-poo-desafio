using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Iphone");   
Smartphone iphone = new Iphone("1234567", "Modelo 1", "1111111111", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Zap zap");

Console.WriteLine("\n");

Console.WriteLine("Celular Nokia");   
Smartphone nokia = new Nokia("9876543", "Modelo 2", "222222222", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

