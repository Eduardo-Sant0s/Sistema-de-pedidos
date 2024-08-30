﻿double totalPedido = 0;

bool pedidoAberto = true;

while(pedidoAberto)
{
    Console.WriteLine("Bem vindo ao melhor sistema de gerenciamentos de pedidos");
    Console.WriteLine("1 - Adcionar item ao pedido:");
    Console.WriteLine("2 - Exibir total do pedido");
    Console.WriteLine("3 - Finalizar o pedido e sair");
    string opcao = Console.ReadLine();


    switch(opcao)
    {
        case "1":
        Console.WriteLine("Escolha um item do cardápio:");
        Console.WriteLine("1 - Pizza (R$30.00)");
        Console.WriteLine("2 - Hamburguer (R$15.00)");
        Console.WriteLine("3 - Refrigerante (R$5.00)");
        string escolha = Console.ReadLine();

        if(escolha == "1")
        {   
            Console.WriteLine("você adicionou uma pizza");
             totalPedido = totalPedido+30;
        }

        else if(escolha == "2")
        {
            Console.WriteLine("Você adicionou um hamburguer!");
            totalPedido += 15;
        }

        else if(escolha == "3")
        {
            Console.WriteLine("Você adicionou um refrigerante!");
            totalPedido += 5;
        }

        else
        {
            Console.WriteLine("Opção inváçida!");
        }
        break;

    

        case "2":
        Console.WriteLine($"total pedido: {totalPedido}");
        break;

        case "3":
        Console.WriteLine("Obrigado pela prefência, volte sempre!");
        pedidoAberto = false;
        break; 
        default:
        Console.WriteLine("Digite uma opção válida!");
        break; 
    }  
}         


