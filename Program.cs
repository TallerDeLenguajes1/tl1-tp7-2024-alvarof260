// See https://aka.ms/new-console-template for more information

/*using EspacioCalculadora;*/

using EspacioCargos;
using EspacioEmpleado;

/*
Calculadora calculadora = new Calculadora();

calculadora.sumar(5);
calculadora.multiplicar(5);
calculadora.dividir(2);
calculadora.restar(2);
double resultado = calculadora.resultado;
Console.WriteLine($"El resultado: {resultado}\n");

*/
Empleado[] empleados = new Empleado[]
{
    new Empleado
    {
        nombre = "Juan",
        apellido = "Perez",
        nacimiento = new DateTime(1985, 5, 23),
        civil = 'S',
        ingreso = new DateTime(2010, 6, 1),
        sueldo = 650000,
        cargo = Cargos.Ingeniero
    },
    new Empleado
    {
        nombre = "María",
        apellido = "González",
        nacimiento = new DateTime(1978, 8, 15),
        civil = 'C',
        ingreso = new DateTime(2005, 3, 10),
        sueldo = 700000,
        cargo = Cargos.Administrativo
    },
    new Empleado
    {
        nombre = "Carlos",
        apellido = "López",
        nacimiento = new DateTime(1990, 10, 7),
        civil = 'S',
        ingreso = new DateTime(2015, 9, 20),
        sueldo = 600000,
        cargo = Cargos.Especialista
    }
};

