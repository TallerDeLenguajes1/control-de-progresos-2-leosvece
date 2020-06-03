using System;
using System.Collections.Generic;
using System.Text;

namespace minijuego
{
    public enum TipoPer
    {
        arquero,
        espadachin,
        mago,
        escudero,

    }

    public class Per
    {

        private TipoPer tipo;
        private string nombre;
        private string apodo;
        private DateTime fecha;
        private int edad;
        private int salud = 100;
        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;
        

        Random aleatorio = new Random();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public TipoPer Tipo { get => tipo; set => tipo = value; }

        public Per CrearPj()
        {
            Per pj = new Per();
            pj.Armadura = aleatorio.Next(10);
            pj.Destreza = aleatorio.Next(5);
            pj.Fuerza = aleatorio.Next(10);
            pj.Velocidad = aleatorio.Next(10);
            pj.Nivel = aleatorio.Next(10);

            Console.WriteLine("nombre");
            pj.Nombre = Console.ReadLine();
            Console.WriteLine("apodo");
            pj.Apodo = Console.ReadLine();

            pj.Fecha = new DateTime(DateTime.Now.Year - aleatorio.Next(300), DateTime.Now.Month, DateTime.Now.Day);
            pj.Edad = DateTime.Now.Year - pj.Fecha.Year;


            Array values = Enum.GetValues(typeof(TipoPer));

            pj.Tipo = (TipoPer)values.GetValue(aleatorio.Next(values.Length));

            return pj;
        }

        public void Mostrar()
        {
            Console.WriteLine(Nivel);
            Console.WriteLine(armadura);
            Console.WriteLine(destreza);
            Console.WriteLine(velocidad);
            Console.WriteLine(fuerza);

            Console.WriteLine(Nombre);
            Console.WriteLine(Apodo);
            Console.WriteLine(edad);
            Console.WriteLine(Salud);
        }


    }

    
 }

