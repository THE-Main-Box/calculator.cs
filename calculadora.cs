using System;

class Calculator
{
    static void Main()
    {
        double v1,v2,res;
        
        Console.Write("qual a operação a ser realizada:[soma][subtração][multiplicação][divisão]");
        string operation=Console.ReadLine();

        Console.WriteLine("qual o primeiro valor");
        v1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("qual o segundo valor");
        v2= Convert.ToDouble(Console.ReadLine());

        if(operation == "soma")
        {
            res=v1 + v2;
        }
        else if(operation == "subtração")
        {
            res=v1 - v2;
        }
        else if(operation == "multiplicação")
        {
            res=v1 * v2;
        }
        else if(operation == "divisão")
        {
           if(v2 != 0)
           {
            res=v1 / v2;
           }
           else{
            Console.Write("erro");
            return;
           }
        }else{
            return;
        }
        
        Console.Write("resultado "+ res);
       
    }
}