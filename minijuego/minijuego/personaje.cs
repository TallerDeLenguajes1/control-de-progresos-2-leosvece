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

        public void CrearPj(string nom, string apd)
        {
            Armadura = aleatorio.Next(1,10);
            Destreza = aleatorio.Next(1,5);
            Fuerza = aleatorio.Next(1,10);
            Velocidad = aleatorio.Next(1,10);
            Nivel = aleatorio.Next(1,10);

            Nombre = nom;

            Apodo = apd;

            Fecha = new DateTime(DateTime.Now.Year - aleatorio.Next(16,300), DateTime.Now.Month, DateTime.Now.Day);
            Edad = DateTime.Now.Year - Fecha.Year;


            Array values = Enum.GetValues(typeof(TipoPer));

            Tipo = (TipoPer)values.GetValue(aleatorio.Next(values.Length));
        }

        public string MostrarDatos()
        {
            string dato;

            dato = "Nombre: " + Nombre + "\n";
            dato += "Apodo: " + Apodo + "\n";
            dato += "tipo: " + Tipo + "\n";
            dato += "Edad: " + edad + "\n";
            dato += "Salud: " + Salud + "\n";

            return dato;
        }

        public string MostrarCaracteriscicas()
        {
            string caracteristicas;

            caracteristicas = "Nivel: " + Nivel + "\n";
            caracteristicas += "Armadura: " + armadura + "\n";
            caracteristicas += "Destresa: " + destreza + "\n";
            caracteristicas += "velocidad: " + velocidad + "\n";
            caracteristicas += "Fuerza: " + fuerza + "\n";

            return caracteristicas;
        }


    }


    
 }

