using System;
using System.Collections.Generic;


namespace minijuego
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int[] VA = new int[2];
            int[] PDEF = new int[2];
            int[] dProvocado = new int[2];
            int[] salud = new int[2];
            int win = 0;
            //int VA1 = 0, VA2 = 0, PDEF1 = 0, PDEF2 = 0;
            int b = 0;
            Per loser = null;


            List<Per> personaje = new List<Per>();
            string car, dat;

            Console.WriteLine("ingrese los datos se su personaje");


            string[] nombre = { "paola", "pedro", "aleandro" };

            string[] apodo = { "pao", "ped", "ale" };



            for (int j = 0; j < 2; j++)
            {
                Per pj = new Per();
                pj.CrearPj(nombre[new Random().Next(3)], apodo[new Random().Next(3)]);
                personaje.Add(pj);

            }

            foreach (Per payer in personaje)
            {

                car = payer.MostrarCaracteriscicas();
                Console.WriteLine(car);
                dat = payer.MostrarDatos();
                Console.WriteLine(dat);
                /*if (b == 0)
                {
                    VA1 = ataque(payer);
                    PDEF1 = defensa(payer);
                }
                else
                {
                    VA2 = ataque(payer);
                    PDEF2 = defensa(payer);
                }*/
                VA[b] = ataque(payer);
                PDEF[b] = defensa(payer);
                b++;

            }

            do
            {
                Console.WriteLine("¿esta listo para una pelea? (s/n)");
                a = Console.ReadLine();
            }
            while (a != "s");
            Console.Clear();



            for (int i = 1; i < 4; i++)
            {
                dProvocado[0] = turno(VA[0], PDEF[1]);
                dProvocado[1] = turno(VA[1], PDEF[0]);
                Console.WriteLine("\nTurno numero " + i);
                b = 0;
                int d = 1;
                Console.WriteLine("Los jugadores atacaron atacado");
                foreach (Per payer in personaje)
                {                    
                    Console.WriteLine("daño probocado por el enemigo es: " + dProvocado[d]);
                    payer.Salud = payer.Salud - dProvocado[d];
                    salud[b] = payer.Salud;
                    Console.WriteLine("salud actual de " + payer.Nombre + " es: " + payer.Salud);
                    b++;
                    d--;
                }

                Console.WriteLine("\n");
            }

            win = ganador(salud[0], salud[1]);
            
            if( win == 0)
            {
                Console.WriteLine("jugadores empataron");
            }
            else
            {
                foreach (Per payer in personaje)
                {
                    if(payer.Salud == win)
                    {
                        Console.WriteLine("ganador es el payer: " + payer.Nombre);
                        payer.Salud += 10;
                    }
                    else
                    {
                        loser = payer;
                    }
                }
            }

            personaje.Remove(loser);



    }

        public static int turno(int VA, int PDEF)
        {
            int dañoProb;
            dañoProb = (VA - PDEF);

            if(dañoProb < 0)
            {
                dañoProb = 0;
            }
            else
            {
                dañoProb = (VA - PDEF) / 500;
            }

            return dañoProb;
        }

        public static int defensa(Per pj)
        {
            int PDEF = pj.Armadura * pj.Velocidad;

            return PDEF;
        }

        public static int ataque(Per pj)
        {
            
            Random efectividad = new Random();

            int PD = pj.Fuerza * pj.Destreza * pj.Nivel;
            int ED = efectividad.Next(1, 100);
            int VA = PD * ED;

            return VA;
        }




        public static int ganador(int salud1, int salud2)
        {
            if(salud1 > salud2)
            {
                return salud1;
            }
            else if (salud1 == salud2)
            {
                return 0;
            }
            else
            {
                return salud2;
            }

        }


        
    }
}

