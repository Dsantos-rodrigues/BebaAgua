using System;

class MainClass {
  public static void Main (string[] args) {
    string nome,peso;
    int peso_usuario, quantidade_agua_consumir;
    //Transformar esta variável em constante
    const int qtdml = 35;
    
    //Entrada de dados
    Console.WriteLine ("Informe seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("Informe seu peso (kg):");
    peso = Console.ReadLine();
    //Processamento
    //Conversão
    peso_usuario = Int32.Parse(peso);
    //Cálculo
    quantidade_agua_consumir = peso_usuario * qtdml;  
    //Saída
    //Acrescentar na saída o nome do usuário
    //Bônus: Apresentar a quantidade em litros/ml

    Console.WriteLine(nome + ", a quantidade de água que você deve consumir no dia é:" + quantidade_agua_consumir/1000 + "," + quantidade_agua_consumir%1000 + " l" );
  }
}