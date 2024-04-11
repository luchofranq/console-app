using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            int pass, pass1, intentos;//defino variables

            string user, user1;

            intentos = 1;

            Random r = new Random(200000);//creo una variable tipo random paa asignar a el entero "saldo"

            int saldo = r.Next(50000, 200000);

            Console.WriteLine("Registro: \n");


            Console.WriteLine("Ingrese un usuario: ");
            user = Console.ReadLine();
            //un while que me obligue a escribir un tipo de usuario es especifico

            Console.WriteLine("Ingrese una contraseña: ");
            pass = int.Parse(Console.ReadLine());
            //un while que me obligue a escribir una contraseña de tipo numerica

            Console.WriteLine("El registro fue un exito");
            Console.WriteLine("Redirigiendo al inicio de sesion");
            Console.WriteLine("5");
            Thread.Sleep(1000);//espera 1 segundo
            Console.WriteLine("4");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Clear();//limpia la pantalla

            Console.WriteLine("Inicio de sesion: ");
            Console.WriteLine("\nIngrese su usuario: ");
            user1 = Console.ReadLine();

            if (user.Equals(user1) == false)
            { //si las 2 cadenas no son iguales entonces...
                do
                {
                    Console.Clear();


                    Console.WriteLine("El usuario no es correcto");
                    Console.WriteLine("\n");
                    Console.WriteLine("Ingrese su usuario: ");
                    user1 = Console.ReadLine();

                    intentos = intentos + 1;//contador de intentos

                    if (intentos > 3)
                    {
                        Console.WriteLine("No tiene mas intentos");
                        Thread.Sleep(3000);
                        Environment.Exit(1);//cierra el programa
                    }
                    Console.Clear();
                } while (String.Equals(user, user1) == false);
            }
            else
            {


                Console.WriteLine("Ingrese su Contraseña: ");
                pass1 = int.Parse(Console.ReadLine());

                if (pass.Equals(pass1) == false)//si los 2 enteros no son iguales entonces...
                {
                    Console.Clear();


                    Console.WriteLine("La contraseña no es correcta");
                    Console.WriteLine("\n");
                    Console.WriteLine("Ingrese su Contraseña: ");
                    pass1 = int.Parse(Console.ReadLine());

                    intentos = intentos + 1;

                    if (intentos > 3)
                    {
                        Console.WriteLine("No tiene mas intentos");
                        Thread.Sleep(3000);
                        Environment.Exit(1);
                    }
                    Console.Clear();
                } while (String.Equals(user, user1) == false) ;

            }
        loop://establece un ciclo 
            Console.Clear();

            int op, retiro, ing;

            Console.WriteLine("Cuenta: ");
            Console.WriteLine("\n");
            Console.WriteLine("1-Consultar saldo");
            Console.WriteLine("2-Extraer dinero");
            Console.WriteLine("3-Ingresar dinero");
            Console.WriteLine("4-Salir");
            Console.WriteLine("\nElija una opcion: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Saldo\n");
                    Console.WriteLine("El saldo en cuenta es: " + saldo + "\n");
                    Console.WriteLine("Regresará a la pantalla de cuenta en: ");
                    Console.WriteLine("5");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    goto loop;//vuelve al inicio del ciclo


                case 2:
                    Console.Clear();
                    Console.WriteLine("Extraccion de dinero\n");
                    Console.WriteLine("Elija una cantidad a retirar");
                    retiro = int.Parse(Console.ReadLine());
                    saldo = (saldo - retiro);
                    Console.WriteLine("El saldo restante es: " + saldo + "\n");
                    Console.WriteLine("Regresará a la pantalla de cuenta en: ");
                    Console.WriteLine("5");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    goto loop;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingreso de dinero\n");
                    Console.WriteLine("Elija una cantidad a ingresar");
                    ing = int.Parse(Console.ReadLine());
                    saldo = (saldo + ing);
                    Console.WriteLine("El saldo restante es: " + saldo + "\n");
                    Console.WriteLine("Regresará a la pantalla de cuenta en: ");
                    Console.WriteLine("5");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    goto loop;

                case 4:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("No es una opcion valida");
                    Console.WriteLine("Regresará a la pantalla de cuenta en: ");
                    Console.WriteLine("5");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    goto loop;

            }

            Console.ReadKey();
        }
    }
}

