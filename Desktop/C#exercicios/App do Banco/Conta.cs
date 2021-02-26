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
        set{numdconta = value;}
    }

    public string Nomedtitular
    {
        set{nomedtitular = value;}
    }

    //Get e Set___________Fim________________

    
    //Métodos________________Inicio_______________________________

    //Atualiza o usuario quando é feito um depósito inicial
    public void atualização(decimal valorind)
    {
        saldodconta = valorind;

        Console.WriteLine("Status da conta:");
        Console.WriteLine($"Conta : {numdconta}, Nome: {nomedtitular} Saldo: {saldodconta}\n");


    }
    //Atualiza o usuario quando é feito um depósito inicial

    //Atualiza para o usuario as informações e atualizações feitas
    private void atualização()
    {
        Console.WriteLine("Status da conta:");
        Console.WriteLine($"Conta : {numdconta}, Nome: {nomedtitular} Saldo: {saldodconta}\n");
    }
    //Atualiza para o usuario as informações e atualizações feitas

    //Depósito_________________________
    public void deposito()
    {
        decimal depvalor;
        Console.Write("Qual o valor para depósito: ");
        depvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta += depvalor;

        atualização();
    }
    //Depósito_________________________

    //Saques___________________________
    public void saques()
    {
        decimal saqvalor;
        Console.Write("Valor para saque: ");
        saqvalor = Convert.ToDecimal(Console.ReadLine());
        saldodconta -= saqvalor + 5.00M;

        atualização();
    }
    //Saques___________________________


    //Métodos_________________Fim_______________________________






}