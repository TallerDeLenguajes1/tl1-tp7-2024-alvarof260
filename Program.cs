// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;
using EspacioCargos;
using EspacioEmpleado;

Calculadora calculadora = new Calculadora();

calculadora.sumar(5);
calculadora.multiplicar(5);
calculadora.dividir(2);
calculadora.restar(2);
double resultado = calculadora.resultado;
Console.WriteLine($"El resultado: {resultado}\n");

Empleado empleado1 = new Empleado();

empleado1.nombre = "Alvaro";
empleado1.apellido = "Figueroa";
empleado1.nacimiento = new DateTime(2004, 1, 20);
empleado1.civil = 'S';
empleado1.ingreso = new DateTime(2023, 2, 20);
empleado1.sueldo = 250000.00;
empleado1.cargo = Cargos.Ingeniero;

