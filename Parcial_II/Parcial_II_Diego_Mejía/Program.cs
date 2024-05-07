
namespace DiegoMejia_parcial_I
{
    class program 
    {
        static void Main()
        {
            Console.WriteLine("Ingrese las 10 notas");
            int[] n = new int[10]; 
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese valor para la nota {i+1}: ");
                String notas = Console.ReadLine();
                n[i] = Convert.ToInt32(notas);

                sum = sum + n[i];
            }
            string[] nombres = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();
             }

            Menu();
        }
        static void Menu()
        {
            while(true)
            {
            Console.WriteLine("Menu");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" );
            Console.WriteLine("1. Mostrar nombre y nota de alumnos que aprobaron el curso");
            Console.WriteLine("2. Mostrar nombre y nota de alumnos que No aprobaron el curso.");
            Console.WriteLine("3. Mostrar el promedio de notas del grupo.");
            Console.WriteLine("4. Salir del programa");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\" );
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
                 switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre y alumnos que aprovaron");
                         aprobados(nombres , notas);
                        break;
                    case 2:
                        Console.WriteLine("Nombre y alumnos que no aprovaron");
                        desaprobados();
                        break;
                    case 3: 
                        Console.WriteLine("promedio de notas en el grupo");
                        break;
                    case 4: 
                       Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("La opción seleccionada no es válida.");
                        break;
                }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }
            }
 
        }
         public static void aprobados(string[] nombres, int[] notas)
        {
            Console.WriteLine("Alumnos aprobados:");
            for (int i = 0; i < 10; i++)
            {
                if (notas[i] >= 60)
                {
                    Console.WriteLine($"{nombres[i]} su nota es de: {notas[i]}");
                }
            }
        }

        static void desaprobados(string[] nombres, double[] notas)
        {
            Console.WriteLine("\nAlumnos no aprobados:");
            for (int i = 0; i < 10; i++)
            {
                if (notas[i] < 60)
                {
                    Console.WriteLine($"{nombres[i]} - Nota: {notas[i]}");
                }
            }
        }
    }
 }

