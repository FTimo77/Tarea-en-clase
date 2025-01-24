using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio a Ejecutar: \n" +
                "1 - Adivina numero\n" +
                "2 - Validar edad\n" +
                "3 - Calcular calificación\n" +
                "4 - Es par o impar\n" +
                "5 - Es mayor o menor\n" +
                "6 - Calcular dia de la semana\n");
            int ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                    Adivina adivina = new Adivina();
                    adivina.adivina_numero();
                    break;
                case 2:
                    validar_edad edad = new validar_edad();
                    edad.validar();
                    break;
                case 3:
                    calificacion calificacion = new calificacion();
                    calificacion.calificar();
                    break;
                case 4:
                    par_impar par_impar = new par_impar();
                    par_impar.par_o_impar();
                    break;
                case 5:
                    es_mayor es_mayor = new es_mayor();
                    es_mayor.numero_mayor();
                    break;
                case 6:
                    dia_semana dia_semana = new dia_semana();
                    dia_semana.dia();
                    break;
                default:
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    break;
            }
        }
    }


    internal class Adivina
    {
        public void adivina_numero()
        {
            Random random = new Random();

            // Generar un número entero aleatorio entre un rango de 0 y 1000
            int numeroAleatorio = random.Next(0, 1001);
            int num_user = -1; // Inicializar con un valor que no sea el número aleatorio
            Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
            Console.WriteLine("He pensado un número entre 0 y 1000. ¿Puedes adivinar cuál es?");

            // Bucle para seguir pidiendo números hasta que el usuario adivine
            while (num_user != numeroAleatorio)
            {
                Console.Write("Ingresa un número: ");
                try
                {
                    num_user = int.Parse(Console.ReadLine());

                    if (num_user > numeroAleatorio)
                    {
                        Console.WriteLine("Es menor.");
                    }
                    else if (num_user < numeroAleatorio)
                    {
                        Console.WriteLine("Es mayor.");
                    }
                    else
                    {
                        Console.WriteLine("¡Felicidades! Has adivinado el número.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }
            }
        }
    }

    internal class validar_edad
    {
        public void validar()
        {
            try
            {
                Console.WriteLine("Por favor, ingresa tu edad: ");
                int edad = int.Parse(Console.ReadLine());
                if (edad >= 18)
                {
                    Console.WriteLine("Puedes votar, rres mayor de edad.");
                }
                else
                {
                    Console.WriteLine("No puedes votar, no eres menor de edad.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }

        }
    }

    internal class calificacion
    {
        public void calificar()
        {
            try
            {
                Console.WriteLine("Por favor, ingresa tu calificación: ");
                int calificacion = int.Parse(Console.ReadLine());
                if (calificacion > 90 & calificacion < 100)
                {
                    Console.WriteLine("A");
                }
                else if (calificacion > 80)
                {
                    Console.WriteLine("B");
                }
                else if (calificacion > 70)
                {
                    Console.WriteLine("C");
                }
                else if (calificacion > 60)
                {
                    Console.WriteLine("D");
                }
                else if (calificacion > 50)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingresa un número válido.");

            }
        }
    }

    internal class par_impar
    {
        public void par_o_impar()
        {
            try
            {
                Console.WriteLine("Por favor, ingresa un número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
    }

    internal class es_mayor
    {
        public void numero_mayor()
        {
            Console.WriteLine("Por favor, ingresa un número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa otro número: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("El número " + numero1 + " es mayor que " + numero2);
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine("El número " + numero2 + " es mayor que " + numero1);
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }

    }

    internal class dia_semana
    {
        public void dia()
        {
            Console.WriteLine("Por favor, ingresa un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    break;
            }
        }
    }
}