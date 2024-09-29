﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");
            
            Console.WriteLine($"4+2={aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4-2={aritmetica.Subtrair(4, 2)}");

            double t1 = conversoes.ConverterTemperatura(conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = conversoes.ConverterTemperatura(conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"36º Fahrenheit = {t1}º Celsius");

            Console.ReadKey();
        }
    }
}
