using System;

namespace App_do_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando o objeto Conta
            Conta obj = new Conta();
            //_______________________

            decimal valorinicial;
            
            //Cadastra o numero da conta
            Console.Write("Numero da conta: ");
            obj.Numdconta = Convert.ToInt32(Console.ReadLine());
            //_______________________

            //Cadastra o nome da conta
            Console.Write("Nome da conta: ");
            obj.Nomedtitular = Console.ReadLine();
            //_______________________

            //Escolha de fazer o saldo inicial ou não
            string escolha;
            Console.Write("Deseja colocar um saldo inicial na conta? (Y/N)? ");
            escolha = Console.ReadLine();
            //_______________________

            //Escolha 1 fazer depósito inicial
            if(escolha == "y")
            {
                Console.Write("Depósito inicial: ");
                valorinicial = Convert.ToDecimal(Console.ReadLine());
                obj.atualização(valorinicial);
            }
            //Escolha 1 fazer depósito inicial
            
            //Escolha 2 não fazer depósito inicial
            if(escolha == "n")
            {
                valorinicial = 0.00M;
                obj.atualização(valorinicial);
            }
            //Escolha 2 não fazer depósito inicial

            //Chamando o método Deposito
            obj.deposito();
            //Chamando o método Deposito

  
            //Chamando o método Saque
            obj.saques();
            //Chamando o método Saque




        }
    }
}
