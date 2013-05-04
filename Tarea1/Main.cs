using System;
	
class Persona{
	public string nombre;
	public string telefono;
	public string email;
	public string domicilio;
}

class MainClass {public static void Main(string []args){
	Persona persona = new Persona();
	
	Console.WriteLine("¿Cual es tu nombre?");
	persona.nombre = Console.ReadLine();
	
	Console.WriteLine("¿Cual es tu telefono?");
	persona.telefono = Console.ReadLine();
	
	Console.WriteLine("¿Cual es tu email?");
	persona.email = Console.ReadLine();
	
	Console.WriteLine("¿Cual es tu domicilio?");
	persona.domicilio = Console.ReadLine();
	
	Console.WriteLine ("Datos de la persona");
	Console.WriteLine ("Nombre: " + persona.nombre);
	Console.WriteLine ("Telefono: " + persona.telefono);
	Console.WriteLine ("Email: " + persona.email);
	Console.WriteLine ("Domicilio: " + persona.domicilio);
}
}