using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia Celular1 = new Nokia(numero: "987213421", modelo: "Nokia 3310", imei: "490154203237518", memoria: 32 );
Nokia Celular2 = new Nokia("971212441", "Nokia XR20", "358240051111110", 64 );
Iphone Celular3 = new Iphone(numero: "985247345", modelo:"iPhone X",imei: "490154203237518", memoria: 128 );
Iphone Celular4 = new Iphone("962345271", "iPhone 15 Pro Max", "358240051111110", 256 );

// Celular.IMEI ou Celular.Modelo ou Celular.Memoria não podem ser acessados pois botamos as codições de privado
// A instância Smartphone C1  = new Smartphone("23","34","23",23); não é aceita pelo código, pois Smartphone é uma class abstract
//

Celular1.Ligar();
Celular1.ReceberLigacao();
Celular1.InstalarAplicativo("Instagram");


Celular2.Ligar();
Celular2.ReceberLigacao();
Celular2.InstalarAplicativo("Facebook");


Celular3.Ligar();
Celular3.ReceberLigacao();
Celular3.InstalarAplicativo("WhatsApp");


Celular4.Ligar();
Celular4.ReceberLigacao();
Celular4.InstalarAplicativo("DIO");