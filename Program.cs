using System;

namespace EjercicioIF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empezando ejercicios con condicional IF");
            /*Console.WriteLine("El resultado del método Boleano1 es ");
            Boleano1();*/
            //Condicionalif();
            //Boleano2();
            //Boleano3();
            //Boleano4();
            //Boleano4B();
            //Boleano5();
            //Uniony();
            BoleanoElseIF();
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
            Console.WriteLine("¿Tienes carnet?");
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
        static void Boleano4() //Esta fue la alternativa que propuse.
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet?");
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
        static void Boleano4B() 
        {//Declarando al inicio la variable "carnet" para que posteriormente tome un valor
            string carnet = "no";
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("¿Tienes carnet?");
                carnet = Console.ReadLine();
            }
            if (edad >= 18 && carnet == "si")
            {
                Console.WriteLine("Puedes conducir vehiculos");
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
                Console.WriteLine("¿Tienes carnet?");
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
        static void Uniony()
        {//Ejemplo de como usar un ó (Union) ||
         //Función o método para obtener el promedio, siempre y cuando apruebes los tres parciales
            Console.WriteLine("Introduce la calificación del primer parcial");
            double parcial1 = Int32.Parse(Console.ReadLine());  
            Console.WriteLine("Introduce la calificación del segundo parcial");
            double parcial2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la calificación del tercer parcial");
            double parcial3 = Int32.Parse(Console.ReadLine());
            if (parcial1>=6 && parcial2>=6 && parcial3>=6)
            {
                Console.WriteLine("Tu promedio es de " + ((parcial1+parcial2+parcial3)/3));
            }
            else
            {
                Console.WriteLine("Tienes que realizar examen(es) de reposición");
            }
        }
        static void BoleanoElseIF()
        {
            Console.WriteLine("Introduce tu edad,por favor");
            int edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Eres un niño");
            }
            else if( edad < 30)
            {
                Console.WriteLine("Eres joven");
            }
            else if (edad < 60)
            {
                Console.WriteLine("Eres un adulto");
            }
            else
            {
                Console.WriteLine("Eres un adulto mayor");
            }
        }
    }
}
