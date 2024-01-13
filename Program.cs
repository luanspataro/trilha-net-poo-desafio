using System.Diagnostics.Contracts;
using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console.WriteLine("Testando Iphone");
Iphone iphone = new Iphone(numero: "997401872", modelo: "Iphone x", imei: "1923749210", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("Testando Nokia");
Nokia nokia = new Nokia(numero: "997401872", modelo: "Nokia 5310", imei: "1029410274", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");