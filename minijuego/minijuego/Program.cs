using System;


namespace minijuego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los datos se su personaje");

            Per personaje1 = new Per();
            personaje1 = personaje1.CrearPj();
            personaje1.Mostrar();

            Per personaje2 = new Per();
            personaje2 = personaje2.CrearPj();
            personaje2.Mostrar();


        }

        
    }
}
