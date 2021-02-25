using System;

namespace App_do_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando o objeto Conta
            Conta obj = new Conta();
            //Chamando o objeto Conta

            //Chamando o método Criando conta
            obj.criandoaconta();
            //Chamando o método Criando conta

            //Atualizando as informações para o usuario
            Console.WriteLine("Status da conta:");
            Console.WriteLine($"Conta : {obj.Numdconta}, Nome: {obj.Nomedtitular} Saldo: {obj.Saldodconta}\n");
            //Atualizando as informações para o usuario

            //Chamando o método Deposito
            obj.deposito();
            //Chamando o método Deposito

            //Atualizando as informações para o usuario
            Console.WriteLine("Status da conta:");
            Console.WriteLine($"Conta : {obj.Numdconta}, Nome: {obj.Nomedtitular} Saldo: {obj.Saldodconta}\n");
            //Atualizando as informações para o usuario

            //Chamando o método Saque
            obj.saques();
            //Chamando o método Saque

            //Atualizando as informações para o usuario
            Console.WriteLine("Status da conta:");
            Console.WriteLine($"Conta : {obj.Numdconta}, Nome: {obj.Nomedtitular} Saldo: {obj.Saldodconta}\n");
            //Atualizando as informações para o usuario



        }
    }
}
