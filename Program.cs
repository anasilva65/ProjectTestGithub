using System;

namespace aula1
{
    class aula1
    {
        static void Main(string[] args)
        {
            //variaveis
       string[] Telefones = new string[3] { "(11)992424940" , "(11)976991294" , "" };

        // cadastro na lista
        for(int indice = 0; indice <= 2; indice ++)
        {
         
        Console.WriteLine(indice);
        Console.WriteLine("Cadastre um telefone valido");
        Telefones[indice] = Console.ReadLine();
        }
        foreach (string telefone in Telefones)


        {
            if(telefone.StartsWith("11"))  
            Console.WriteLine(telefone + "e valido");
        }

        Console.ReadKey();
        {
            
        }
    }
    
}

}

