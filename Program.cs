using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("99998888", "Tojolão", "123456", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Gmail");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("11112222", "Esquenta muito", "654321", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Apple Music");