using System;


namespace minijuego
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.WriteLine("ingrese los datos se su personaje");

            Per personaje1 = new Per();
            personaje1 = personaje1.CrearPj(personaje1);
            personaje1.Mostrar();

            Per personaje2 = new Per();
            personaje2 = personaje2.CrearPj(personaje2);
            personaje2.Mostrar();

            do
            {
                Console.WriteLine("¿esta listo para una pelea? (s/n)");
                a = Console.ReadLine();
            }
            while (a != "s");
            Console.Clear();

            for (int i=1; i<4;i++)
            {
                Console.WriteLine("\nTurno numero " + i);
                personaje1 = turno(personaje2, personaje1);
                personaje2 = turno(personaje1, personaje2);
                Console.WriteLine("\n");
            }

            ganador(personaje2, personaje1);            

        }

        public static Per turno(Per pjAtac, Per pjDef)
        {
           
            Random efectividad = new Random();

            int PD = pjAtac.Fuerza * pjAtac.Destreza * pjAtac.Nivel;
            int ED = efectividad.Next(1,100);
            int VA = PD * ED;
            int PDEF = pjAtac.Armadura * pjAtac.Velocidad;
            int dañoProb = (VA - PDEF) / 500;

            Console.WriteLine("el jugador " + pjAtac.Nombre + "ha atacado");
            Console.WriteLine("daño probocado= " + dañoProb);

            pjDef.Salud = pjDef.Salud - dañoProb;
            Console.WriteLine("salud actual de " + pjDef.Nombre + " es: " + pjDef.Salud);

            return pjDef;
        }

        public static void ganador(Per pj1, Per pj2)
        {
            if(pj1.Salud > pj2.Salud)
            {
                Console.WriteLine("El ganador es: " + pj1.Nombre);
            }
            else if (pj1.Salud == pj2.Salud)
            {
                Console.WriteLine("Ambos jugadores empataron");
            }
            else
            {
                Console.WriteLine("El ganador es: " + pj2.Nombre);
            }
        }


        
    }
}
