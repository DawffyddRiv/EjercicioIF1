using System;

namespace EjercicioIF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empezando ejercicio condicional IF");
            /*Console.WriteLine("El resultado del método Boleano1 es ");
            Boleano1();*/
            //Condicionalif();
            //Boleano2();
            //Boleano3();
            //Boleano4();
            Boleano5();
        }
        static void Condicionalif() 
        {
            //Empezando if
            int edad = 15;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            if (edad >= 18)
            {
                Console.WriteLine("Adelante puedes pasar porque eres mayor de edad");
            }
        }
        static void Boleano1() 
        {
            bool haceFrio;
            haceFrio = true;
            Console.WriteLine(haceFrio);
            Console.WriteLine(!haceFrio);//Negando con signo de exclamación
        }
        static void Boleano2() 
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            bool carnet = false;
            if (carnet == true) 
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else 
            {
                Console.WriteLine("Lo siento, pero no puedes conducir vehiculos");
            }

            //Console.WriteLine("Aqui termina el programa");

        }
        static void Boleano3()
        {//Que sea mayor de 18 y tenga carnet para poder conducir. Si falla en alguno, no puede conducir
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tienes carnet");
            string carnet = Console.ReadLine();
            if (edad >= 18 && carnet == "si")
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
            
        }
        static void Boleano4() 
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Tienes carnet");
                string carnet = Console.ReadLine();
                if (carnet == "si")
                {
                    Console.WriteLine("Puedes conducir vehiculos");
                }
                else
                {
                    Console.WriteLine("No puedes conducir vehiculos");
                }
            }
            else 
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
        }
        static void Boleano5()
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("No puedes conducir vehiculos");

            }
            else
            {
                Console.WriteLine("Tienes carnet");
                string carnet = Console.ReadLine();
                int compara = string.Compare(carnet,"si",true);
                if (compara == 0)
                {
                    Console.WriteLine("Puedes conducir vehiculos");
                }
                else
                {
                    Console.WriteLine("No puedes conducir vehiculos");
                }
            }
        }
    }
}
