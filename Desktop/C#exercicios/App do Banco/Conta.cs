using System;

class Conta
{
//Atributos________________________
    private int numdconta; //Numero da conta
    private string nomedtitular; //Nome da conta
    private decimal saldodconta; // Saldo da conta
//Atributos________________________



//Get e Set_________inicio_______________
    public int Numdconta
    {
        set{numdconta = value;}
    }

    public string Nomedtitular
    {
        set{nomedtitular = value;}
    }

//Get e Set___________Fim________________



//Métodos construtores________________________________________

    public Conta(decimal saldodconta, int numdconta, string nomedtitular)
    {
    //Atribui os valores para os atributos e notifica os dados da conta
        
        //Atribuir os valores
        this.saldodconta = saldodconta;
        this.numdconta = numdconta;
        this.nomedtitular = nomedtitular;

        
        //Notifica o os dados da conta
        Console.WriteLine($"\n Numero da conta: {numdconta} Nome: {nomedtitular} Saldo: {saldodconta} \n");

    }

//Métodos construtores________________________________________

    
//________Métodos________________Inicio_______________________________
//Depósito_________________________
    public void deposito()
    {
        decimal depvalor;
        Console.Write("Qual o valor para depósito: ");
        depvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta += depvalor;

        Console.WriteLine("Conta dados:");
        Console.WriteLine($"\n Numero da conta: {numdconta} Nome: {nomedtitular} Saldo: {saldodconta} \n");


    }
    //Depósito_________________________

//Saques___________________________
    public void saques()
    {
        decimal saqvalor;
        Console.Write("Valor para saque: ");
        saqvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta -= saqvalor + 5.00M;

        Console.WriteLine("Conta dados:");
        Console.WriteLine($"Numero da conta: {numdconta} Nome: {nomedtitular} Saldo: {saldodconta} \n");


    }
    //Saques___________________________




//________Métodos_________________Fim_________________________________






}