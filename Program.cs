using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia Tijolão");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "12121212121212", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "78912", modelo: "modelo 5s", imei: "11222314231243", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatzap");