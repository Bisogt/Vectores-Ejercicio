using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Matriz
{
    class Program
    {
        static void Main(string[] args)


        {

            {


                Console.WriteLine("Ingresar contacto ");
                string contacto = Console.ReadLine();

                for (int f = 0; f < 15; f++)
                {

                    string[,] mat = new string[5, 15];
                    Console.WriteLine("Nombre ");
                    for (int f = 0; f < 15; f++)
                        if (contacto != "no")




                        {
                            mat[1, 1] = string.Copy(Console.ReadLine());

                        }

                    Console.WriteLine("Apellido ");
                    for (int f = 0; f < 15; f++)
                    {
                        mat[1, 2] = string.Copy(Console.ReadLine());

                    }
                    Console.WriteLine("Teléfono ");
                    for (int f = 0; f < 15; f++)

                    {
                        mat[1, 3] = string.Copy(Console.ReadLine());

                    }
                    Console.WriteLine("Correo ");
                    for (int f = 0; f < 15; f++)
                    {
                        mat[1, 4] = string.Copy(Console.ReadLine());

                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Mostrar COntacto");
                    for(int x=0; x<15; x++)
                    {
                        Console.WriteLine(mat[1, 2]);
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Buscar Contacto");
                buscar = Console.ReadLine();
                }





                    Console.ReadKey();
                }
            }
        }
    }
    

