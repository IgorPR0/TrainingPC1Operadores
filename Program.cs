    using System;

namespace TrainingPC1OperadoresData
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor , Divisao , Soma;

            DateTime Data = DateTime.Now;
            DateTime Hora;

            Console.Write("Digite o valor a ser pago :");
            Valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o numero de Parcela :");
            Divisao = Convert.ToDouble(Console.ReadLine());

            Soma = Valor / Divisao;

            Hora = Data.AddMonths(5);
            Console.WriteLine($"A Data de parcela é : {Hora}, No valor total de R${Soma}");
        
        }
    }
}