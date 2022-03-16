using System;

namespace Notas_de_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables de Entrada

            int Cedula;
            string Nombre;
            string Apellido;
            double N1, N2, N3, N4, N5, N6;
            double Cort1, Cort2, Cort3;
            double NotFinal;





            // Pedir datos

            Console.WriteLine("Por favor, ingrese su numero de documento:");
            Cedula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su primera nota si es decimal separada con ','");
            N1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segunda nota si es decimal separada con ','");
            N2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tercera nota si es decimal separada con ','");
            N3 = Double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese su cuarta nota si es decimal separada con ','");
            N4 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su quinta nota si es decimal separada con ','");
            N5 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su sexta nota si es decimal separada con ','");
            N6 = Double.Parse(Console.ReadLine());

            // Procedimiento

            Cort1 = N1 * (0.2) + N2 * (0.1);
            Cort2 = N3 * (0.1) + N4 * (0.2);
            Cort3 = N5 * (0.2) + N6 * (0.2);

            NotFinal = Cort1 + Cort2 + Cort3;
            //Mostrar mensajes


            Console.WriteLine("Primer corte: " + Cort1);
            Console.WriteLine("Segundo corte: " + Cort2);
            Console.WriteLine("Tercer corte: " + Cort3);
            Console.WriteLine("Nota final: " + NotFinal);


            if ((NotFinal < 5 && NotFinal >= 4.6) == true)
            {
                Console.WriteLine("Estudiante con beca");
            }
            else if ((NotFinal <= 4.59 && NotFinal >= 4.1) == true)
            {
                Console.WriteLine("Estudiante Meritorio");
            }
            else if ((NotFinal <= 4 && NotFinal >= 3.8) == true)
            {
                Console.WriteLine("Estudiante sobresaliente ");
            }
            else if ((NotFinal <= 3.79 && NotFinal >= 3) == true)
            {
                Console.WriteLine("Estudiante aprobo");
            }
            else if ((NotFinal <= 2.99 && NotFinal >= 0) == true)
            {
                Console.WriteLine("Estudiante repite ");
            }
            else
            {
                Console.WriteLine("Nota fuera del rango ");
            }

        }
    }
}
