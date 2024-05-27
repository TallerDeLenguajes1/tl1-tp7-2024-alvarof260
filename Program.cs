// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

Calculadora calculadora = new Calculadora();

calculadora.sumar(5);
calculadora.multiplicar(5);
calculadora.dividir(2);
calculadora.restar(2);
double resultado = calculadora.resultado;
Console.WriteLine($"El resultado: {resultado}\n");
