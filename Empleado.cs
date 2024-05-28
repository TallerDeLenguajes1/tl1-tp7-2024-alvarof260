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
    }
}
