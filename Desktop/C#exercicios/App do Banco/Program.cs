using System;

namespace App_do_Banco
{
    class Program
    {
        static void Main(string[] args)
        {   
        //Variaveis locais
            decimal valorinicial = 00.00M;
            int numero = 0 ;
            string nome;   
            //___________________________

        //Cadastra o numero da conta
            Console.Write("Numero da conta: ");
            numero = Convert.ToInt32(Console.ReadLine());
            //_______________________

        //Cadastra o nome da conta
            Console.Write("Nome da conta: ");
            nome = Console.ReadLine();
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
            }
            //____________________________
            
        //Escolha 2 não fazer depósito inicial
            if(escolha == "n")
            {
                valorinicial = 0.00M;
            }
            //_____________________________

        //Chamando o objeto Conta
            Conta obj = new Conta(valorinicial, numero, nome);
            //_______________________


        //Chamando o método Deposito
            obj.deposito();
            //_________________________
  
        //Chamando o método Saque
            obj.saques();
            //________________________




        }
    }
}
