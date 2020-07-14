using System;

namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            System.Console.WriteLine("Quanto acrescentar no limite?");
            float acres = float.Parse(Console.ReadLine());

            visa.AumentarLimite(acres);
            System.Console.WriteLine("Novo limite: R$"+visa.limite);
            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Data:" + visa.data);
        }
    }
}
