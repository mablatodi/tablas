using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicar_2_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int n2 = 0;
            int b = 0;
            int a = 0;
            int opcion = 0;

            do
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear();

                Console.WriteLine("\t\t________________________________________________________________________");
                Console.WriteLine("\t\t\t BIENVENIDOS AL PROGRAMA DE LAS TABLAS DE MULTIPLICAR");
                Console.WriteLine("\t\t________________________________________________________________________");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("POR FAVOR SELECCIONE UNA OPCION");
                Console.WriteLine("");

                Console.WriteLine("1. INICIAR PROGRAMA CON MULTIPLICACION DE UNA TABLA");
                Console.WriteLine("2. INICIAR PROGRAMA CON MULTIPLICACION DE VARIAS TABLAS");
                Console.WriteLine("3. SALIR DEL PROGRAMA");
                Console.WriteLine("");

                Console.WriteLine("INTRODUZCA SU OPCION AQUI ABAJO");
                opcion = Convert.ToInt32(Console.ReadLine());


                if (opcion == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE LA TABLA QUE DESEA HACER");
                    Console.ForegroundColor = ConsoleColor.Black;
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE DESDE DONDE DESEA LA TABLA");
                    Console.ForegroundColor = ConsoleColor.Black;
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE HASTA DONDE DESEA LA TABLA");
                    Console.ForegroundColor = ConsoleColor.Black;
                    b = Convert.ToInt32(Console.ReadLine());

                    if (b > a)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("LA TABLA DEL NUMERO " + n + " DESDE " + a + " HASTA " + b + " ES:");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("");
                        Console.WriteLine("______________________");
                        Console.WriteLine("");

                        for (int i = a; i <= b; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", n, i, i * n);
                        }
                        Console.WriteLine("______________________");

                       

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("");
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL INICIO");

                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    { if (b<a)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("LA TABLA DEL NUMERO " + n + " DESDE " + a + " HASTA " + b + " ES:");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("");
                            Console.WriteLine("______________________");
                            Console.WriteLine("");

                            for (int i = a; i >= b; i--)
                            {
                                Console.WriteLine("{0} x {1} = {2}", n, i, i * n);
                            }
                            Console.WriteLine("______________________");

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("");
                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL INICIO");

                            Console.ReadKey();
                            Console.Clear();
                        }
                        
                    }
                }
                if (opcion == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE LA TABLA QUE DESEA HACER -TABLA INICIAL");
                    Console.ForegroundColor = ConsoleColor.Black;
                    n = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE LA TABLA QUE DESEA HACER -TABLA FINAL");
                    Console.ForegroundColor = ConsoleColor.Black;
                    n2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE DESDE DONDE DESEA LA TABLA");
                    Console.ForegroundColor = ConsoleColor.Black;
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DIGITE HASTA DONDE DESEA LA TABLA");
                    Console.ForegroundColor = ConsoleColor.Black;
                    b = Convert.ToInt32(Console.ReadLine());

                    if (b > a)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("LA TABLA DEL NUMERO " + n + " HASTA " + n2 + " DESDE " + a + " HASTA " + b + " ES: ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("");
                        Console.WriteLine("______________________");
                        Console.WriteLine("");

                        for (int i = n; i <= n2; i++)
                        {
                            for (int j = a; j <= b; j++)
                                Console.WriteLine(i + " x " + j + " = " + j * i);
                            Console.WriteLine("");

                        }
                        Console.WriteLine("______________________");



                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("");
                        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL INICIO");

                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        if (n2 < n)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("LA TABLA DEL NUMERO " + n + " HASTA " + n2 + " DESDE " + a + " HASTA " + b + " ES: ");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("");
                            Console.WriteLine("______________________");
                            Console.WriteLine("");

                            for (int i = n; i >= n2; i--)
                            {
                                for (int j = a; j >= b; j--)
                                    Console.WriteLine(i + " x " + j + " = " + j * i);
                                Console.WriteLine("");

                            }
                            Console.WriteLine("______________________");



                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("");
                            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA VOLVER AL INICIO");

                            Console.ReadKey();
                            Console.Clear();
                        }

                    }
                }

                if (opcion == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("\t     ________________________________________________________");
                    Console.WriteLine("\t\t\t   GRACIAS POR USAR EL PROGRAMA");
                    Console.WriteLine("\t\t\t\t    HASTA LUEGO");
                    Console.WriteLine("\t     ________________________________________________________");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine("\t\t\t\t");
                    Console.WriteLine("\t\t\t\t░░░░░░░░░░░▄▄");
                    Console.WriteLine("\t\t\t\t░░░░░░░░░░█░░█");
                    Console.WriteLine("\t\t\t\t░░░░░░░░░░█░░█");
                    Console.WriteLine("\t\t\t\t░░░░░░░░░█░░░█");
                    Console.WriteLine("\t\t\t\t░░░░░░░░█░░░░█");
                    Console.WriteLine("\t\t\t\t██████▄▄█░░░░░██████▄");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█░░░░░░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█░░░░░░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█░░░░░░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█░░░░░░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█░░░░░░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t▓▓▓▓▓█████░░░░░░░░░█");
                    Console.WriteLine("\t\t\t\t█████▀░░░░▀▀██████▀");


                }

                if (opcion < 1 | opcion > 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("\t     ________________________________________________________");
                    Console.WriteLine("\t\t\tPOR FAVOR DIGITE BIEN, GRACIAS");
                    Console.WriteLine("\t\t\t     VUELVA A INTENTARLO");
                    Console.WriteLine("\t     ________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("\t\t\t   ＼＼＼／／／＼＼＼／／／");
                    Console.WriteLine("\t\t\t   ░░░░░░░░░░░░░░░░░░░");
                    Console.WriteLine("\t\t\t   ░░▐▀▀██▀▌░▐▀██▀▀▌░░");
                    Console.WriteLine("\t\t\t   ░░▐▄▄▄▄▄▌░▐▄▄▄▄▄▌░░");
                    Console.WriteLine("\t\t\t   ░░░░░░░░░░░░░░░░░░░");
                    Console.WriteLine("\t\t\t   ░░░█▀█▀█▀█▀█▀█▀█░░░");
                    Console.WriteLine("\t\t\t   ░░░█▄█▄█▄█▄█▄█▄█░░░");
                    Console.WriteLine("\t\t\t   ░░░░░░░░░░░░░░░░░░░");
                    Console.WriteLine("");


                    Console.ReadKey();
                    Console.Clear();

                }

            } while (opcion != 3);

            Console.ReadKey();
        
        }
    }
}
