namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato = 0;

        public void sumar(double num)
        {
            dato += num;
        }

        public void restar(double num)
        {
            dato -= num;
        }

        public void multiplicar(double num)
        {
            dato *= num;
        }

        public void dividir(double num)
        {
            if (num != 0)
            {
                dato /= num;
            }
            else
            {
                Console.WriteLine("No se puede dividir en 0\n");
            }
        }

        public void limpiar()
        {
            dato = 0;
        }

        public double resultado
        {
            get { return dato; }
        }
    }
}
