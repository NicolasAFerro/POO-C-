using Testecsharp.Models; 
using System.Reflection;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.Clear();
Nokia pedra = new Nokia(123,"azul", "não sei", 3);
pedra.InstalarAplicativo("youtube"); 

Console.WriteLine("propriedade iphone");
Iphone rico = new Iphone(345, "amarelo", "SEI", 4);
rico.InstalarAplicativo("facetime");
rico.ReceberLigacao(); 
rico.Ligar();
rico.Apresentar();



/* Type tipoNokia = pedra.GetType();

Aqui, estamos usando o método GetType() em um objeto chamado pedra, que é uma instância da classe Nokia. O método GetType() é fornecido pelo tipo System.Object, do qual todas as classes em C# derivam. Esse método retorna um objeto da classe Type que representa o tipo (classe) da instância pedra. Em outras palavras, ele obtém informações sobre a classe a partir da instância.

PropertyInfo[] propriedades = tipoNokia.GetProperties();
O método GetProperties() é usado no objeto tipoNokia, que é uma instância da classe Type. 
Ele retorna um array de objetos PropertyInfo,
 onde cada objeto PropertyInfo contém informações sobre uma propriedade da classe
  representada por tipoNokia.

Portanto, propriedades será um array que contém informações sobre todas as propriedades da classe Nokia. Você pode usar esse array para iterar sobre as propriedades e obter informações específicas sobre cada uma, como seus nomes e valores, como é feito no loop foreach no código seguinte. Isso permite inspecionar os atributos da instância da classe dinamicamente. */