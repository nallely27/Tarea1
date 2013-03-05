using System;

namespace Tarea1
{
	class Persona
	{
		String nombre;
		string domicilio;
		string face;
		string telefono;

		public static void Main (string[] args)
		{
			Persona persona = new Persona ();
			Console.WriteLine("Dame tu nombre");
			persona.nombre = Console.ReadLine ();
			Console.WriteLine("Dame tu domicilio");
			persona.domicilio = Console.ReadLine ();
			Console.WriteLine("Dame tu facebook");
			persona.face = Console.ReadLine ();
			Console.WriteLine("Dame tu telefono");
			persona.telefono = Console.ReadLine ();


			Console.WriteLine (persona.nombre);	
			Console.WriteLine (persona.domicilio);	
			Console.WriteLine (persona.face);
			Console.WriteLine (persona.telefono);

			Console.ReadLine ();
		}
	}
}
