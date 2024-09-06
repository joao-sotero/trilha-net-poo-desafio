using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("81999712874", "Lumia 1020", "782347rghidfhdf787878784hhd", 4);
nokia.Ligar();
Iphone iphone = new Iphone("81999712834", "Iphone 11 pro", "782347rghidfhdf78dc7878784hhd", 16);
iphone.Ligar();

nokia.InstalarAplicativo("whatsapp");
iphone.InstalarAplicativo("whatsapp");

nokia.ReceberLigacao();
iphone.ReceberLigacao();