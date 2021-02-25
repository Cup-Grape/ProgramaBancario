using System;

class Conta
{
    //Atributos________________________
    private int numdconta;
    private string nomedtitular;
    private decimal valordincial;
    private decimal saldodconta;
    //Atributos________________________


    //Get e Set_________inicio_______________
    public int Numdconta
    {
        get{return numdconta;}
        set{numdconta = value;}
    }

    public string Nomedtitular
    {
        get{return nomedtitular;}
        set{nomedtitular = value;}
    }

    public decimal Saldodconta
    {
        get{return saldodconta;}
        set{saldodconta = value;}
    }
    //Get e Set___________Fim________________

    
    //Métodos________________Inicio_______________________________

    //Ciando a conta do cliente________
    public void criandoaconta()
    {
            string escolha;

            Console.Write("Numero da conta: ");
            numdconta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome da conta: ");
            nomedtitular = Console.ReadLine();

            Console.Write("Deseja colocar um saldo inicial na conta? (Y/N)? ");
            escolha = Console.ReadLine();
            
            //Escolha 1 fazer depósito inicial
            if(escolha == "y")
            {
                Console.Write("Depósito inicial: ");
                valordincial = Convert.ToDecimal(Console.ReadLine());
            }
            //Escolha 1 fazer depósito inicial
            
            //Escolha 2 não fazer depósito inicial
            if(escolha == "n")
            {
                valordincial = 0.00M;
            }
            //Escolha 2 não fazer depósito inicial

            //Define o valor inicial com o saldo da conta
            saldodconta = valordincial;
            //Define o valor inicial com o saldo da conta

    }
    //Ciando a conta do cliente________

    //Depósito_________________________
    public void deposito()
    {
        decimal depvalor;
        Console.Write("Qual o valor para depósito: ");
        depvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta += depvalor;
    }
    //Depósito_________________________

    //Saques___________________________
    public void saques()
    {
        decimal saqvalor;
        Console.Write("Valor para saque: ");
        saqvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta -= saqvalor + 5.00M;

    }
    //Saques___________________________


    //Métodos_________________Fim_______________________________






}