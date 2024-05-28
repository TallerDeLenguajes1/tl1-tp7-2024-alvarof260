using EspacioCargos;

namespace EspacioEmpleado
{
    public class Empleado
    {
        private string _nombre;

        public string nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        private string _apellido;

        public string apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        private DateTime _nacimiento;

        public DateTime nacimiento
        {
            get => _nacimiento;
            set => _nacimiento = value;
        }

        private char _civil;

        public char civil
        {
            get => _civil;
            set => _civil = value;
        }

        private DateTime _ingreso;

        public DateTime ingreso
        {
            get => _ingreso;
            set => _ingreso = value;
        }

        private double _sueldo;

        public double sueldo
        {
            get => _sueldo;
            set => _sueldo = value;
        }

        private Cargos _cargo;

        public Cargos cargo
        {
            get => _cargo;
            set => _cargo = value;
        }

        public int calcularAntiguedad()
        {
            DateTime actual = DateTime.Now;
            int antiguedad = actual.Year - _ingreso.Year;
            if (actual < _ingreso.AddYears(antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public int calcularEdad()
        {
            DateTime actual = DateTime.Now;
            int edad = actual.Year - _nacimiento.Year;
            if (actual < _nacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public int jubilarse()
        {
            const int jubilarse = 65;
            int edad = calcularEdad();
            int aniosJubilarse = jubilarse - edad;
            return 0 > aniosJubilarse ? 0 : aniosJubilarse;
        }

        public double calcularSalario()
        {
            int antiguedad = calcularAntiguedad();
            double adicional = 0;

            if (antiguedad <= 20)
            {
                adicional = _sueldo * (antiguedad * 0.01);
            }
            else
            {
                adicional = _sueldo * 0.25;
            }

            if (_cargo == Cargos.Ingeniero || _cargo == Cargos.Investigador)
            {
                adicional *= 1.5;
            }

            if (_civil == 'C')
            {
                adicional += 150000;
            }

            return _sueldo + adicional;
        }
    }
}
