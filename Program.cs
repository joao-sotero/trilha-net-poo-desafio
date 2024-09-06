using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("telefone nokia");
Iphone iphone = new Iphone("81999712834", "Iphone 11 pro", "782347rghidfhdf78dc7878784hhd", 16);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");
iphone.ReceberLigacao();
Console.WriteLine(iphone.ToString());

Console.WriteLine("\n");

Console.WriteLine("telefone Apple");
Nokia nokia = new Nokia("81999712874", "Lumia 1020", "782347rghidfhdf787878784hhd", 4);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Message");
Console.WriteLine(nokia.ToString());