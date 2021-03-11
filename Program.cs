using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {

        static void Main(string[] args)
        {
            Personas persona = new Personas();
            int deposito = 0;
            int depositos = 0;
            int retiro = 0;
            int menu;
            int menu2;

            Console.WriteLine("Bienvenido, cual persona es usted?");

            do
            {
                Console.WriteLine("1. Juan Contreras Peralta");
                Console.WriteLine("2. Pedro Jimenez Concepcion");
                Console.WriteLine("3. Carla Magdalena Rosario Ortiz");
                Console.WriteLine("4. Salir");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        persona.mostrarpersona1();
                        Console.WriteLine("Digite el numero de la accion que quiere hacer.");
                        Console.WriteLine("1. Depositar");
                        Console.WriteLine("2. Retirar");
                        menu2 = int.Parse(Console.ReadLine());

                        switch (menu2)
                        {
                            case 1:
                                Console.WriteLine("Cuanto dinero quiere depositar?");
                                deposito = int.Parse(Console.ReadLine());
                                persona.per1_monto = persona.per1_monto + deposito;
                                Console.WriteLine(persona.per1_monto);
                                break;

                            case 2:
                                Console.WriteLine("Cuanto dinero quiere retirar?");
                                retiro = int.Parse(Console.ReadLine());
                                persona.per1_monto = persona.per1_monto - retiro;
                                Console.WriteLine(persona.per1_monto);
                                break;

                            default:
                                Console.WriteLine("La opcion no esta en el menu");
                                break;
                        }
                        break;

                    case 2:
                        persona.mostrarpersona2();
                        Console.WriteLine("Digite el numero de la accion que quiere hacer.");
                        Console.WriteLine("1. Depositar");
                        Console.WriteLine("2. Retirar");
                        menu2 = int.Parse(Console.ReadLine());

                        switch (menu2)
                        {
                            case 1:
                                Console.WriteLine("Cuanto dinero quiere depositar?");
                                deposito = int.Parse(Console.ReadLine());
                                persona.per2_monto = persona.per2_monto + deposito;
                                Console.WriteLine(persona.per2_monto);
                                break;

                            case 2:
                                Console.WriteLine("Cuanto dinero quiere retirar?");
                                retiro = int.Parse(Console.ReadLine());
                                persona.per2_monto = persona.per2_monto - retiro;
                                Console.WriteLine(persona.per2_monto);
                                break;

                            default:
                                Console.WriteLine("La opcion no esta en el menu");
                                break;
                        }
                        break;

                    case 3:
                        persona.mostrarpersona3();
                        Console.WriteLine("Digite el numero de la accion que quiere hacer.");
                        Console.WriteLine("1. Depositar");
                        Console.WriteLine("2. Retirar");
                        menu2 = int.Parse(Console.ReadLine());

                        switch (menu2)
                        {
                            case 1:
                                Console.WriteLine("Cuanto dinero quiere depositar?");
                                deposito = int.Parse(Console.ReadLine());
                                persona.per3_monto = persona.per3_monto + deposito;
                                Console.WriteLine(persona.per3_monto);
                                break;

                            case 2:
                                Console.WriteLine("Cuanto dinero quiere retirar?");
                                retiro = int.Parse(Console.ReadLine());
                                persona.per3_monto = persona.per3_monto - retiro;
                                Console.WriteLine(persona.per3_monto);
                                break;

                            default:
                                Console.WriteLine("La opcion no esta en el menu");
                                break;
                        };
                        break;

                    case 4:
                        depositos = persona.per1_monto + persona.per2_monto + persona.per3_monto;
                        Console.WriteLine("El total del dinero depositado es: " + depositos);
                        break;
                }
            } while (menu != 4);
        }
    }

    public class Personas
    {
        string per1_nombre = "Juan";
        string per1_apellido = "Contreras Peralta";
        string per1_cedula = "234-001234-2";
        string per1_tel = "829-552-3256";
        string per1_nacionalidad = "Dominicana";
        public int per1_monto, ret_per1, dep_per1;

        string per2_nombre = "Pedro";
        string per2_apellido = "Jimenes Concepcion";
        string per2_cedula = "105-001851-2";
        string per2_tel = "829-285-1756";
        string per2_nacionalidad = "Dominicana";
        public int per2_monto, ret_per2, dep_per2;

        string per3_nombre = "Carla Magdalena";
        string per3_apellido = "Rosario Ortiz";
        string per3_cedula = "201-002459-2";
        string per3_tel = "829-275-4593";
        string per3_nacionalidad = "Dominicana";
        public int per3_monto, ret_per3, dep_per3;

        public void mostrarpersona1()
        {
            Console.WriteLine("Nombre: " + per1_nombre);
            Console.WriteLine("Apellido: " + per1_apellido);
            Console.WriteLine("Cedula: " + per1_cedula);
            Console.WriteLine("Telefono: " + per1_tel);
            Console.WriteLine("Nacionalidad: " + per1_nacionalidad);
            Console.WriteLine("Deposito: " + per1_monto);
        }
        public void mostrarpersona2()
        {
            Console.WriteLine("Nombre: " + per2_nombre);
            Console.WriteLine("Apellido: " + per2_apellido);
            Console.WriteLine("Cedula: " + per2_cedula);
            Console.WriteLine("Telefono: " + per2_tel);
            Console.WriteLine("Nacionalidad: " + per2_nacionalidad);
            Console.WriteLine("Deposito: " + per2_monto);

        }
        public void mostrarpersona3()
        {
            Console.WriteLine("Nombre: " + per3_nombre);
            Console.WriteLine("Apellido: " + per3_apellido);
            Console.WriteLine("Cedula: " + per3_cedula);
            Console.WriteLine("Telefono: " + per3_tel);
            Console.WriteLine("Nacionalidad: " + per3_nacionalidad);
            Console.WriteLine("Deposito: " + per3_monto);

        }
    }
}
