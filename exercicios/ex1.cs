using System;

class Ex1{

    static void Main(){
        string nome, cidade;
        int telefone,rm;

        Console.Write("Digite seu nome: ");
        nome=Console.ReadLine();
        Console.Write("Digite seu telefone: ");
        telefone=Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite sua cidade: ");
        cidade=Console.ReadLine();
        Console.Write("Digite seu RM: ");
        rm=int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nCADASTRO Vinícius\nApelido: {0}\nTelefone: {1}\nCidade: {2}\nRegistro de Matrícula: {3}",nome,telefone,cidade,rm);

    }
}