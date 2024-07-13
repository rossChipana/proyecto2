/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona 
	{
		protected string nombre;
		protected string apellido;
		protected int ci;
		protected short edad;
		protected char genero;
		protected string nacionalidad;
		protected int telefono;
		public Persona():base()
		{
			nombre="juan";
			apellido = "Mamani";
			ci= 12345678;
			edad =25;
			genero='f';
			nacionalidad="Bolivia";
			telefono=7899933;
		}
		protected void Leer(){
			Console.Write("\ningrese Nombre ");
			nombre=Console.ReadLine();
			Console.Write("\ningrese Apellido ");
			apellido=Console.ReadLine();
			Console.Write("\ningrese Ci ");
			ci = int.Parse(Console.ReadLine());
			Console.Write("\ningrese Edad ");
			edad = short.Parse(Console.ReadLine());
			Console.Write("\ningrese Genero ");
			genero = char.Parse(Console.ReadLine());
			Console.Write("\ningrese Nacionalidad ");
			nacionalidad=Console.ReadLine();
			Console.Write("\ningrese Telefono ");
			telefono = int.Parse(Console.ReadLine());
			
			
		}
		public void Mostrar(){
			Console.WriteLine("\tNombre =  " + nombre);
			Console.WriteLine("\tApellido =  " + apellido);
			Console.WriteLine("\tCi =  " + ci);
			Console.WriteLine("\tEdad =  " + edad);
			Console.WriteLine("\tGenero =  " + genero);
			Console.WriteLine("\tNacionalidad =  " + nacionalidad);
			Console.WriteLine("\tTelefono =  " + telefono);
		}
		
		public string NOmbre{
				get{return nombre;}
		        set{ nombre=value;}
		        		
	}
		public string APellido{
				get{return apellido;}
		        set{ apellido=value;}
		        		
	}
		
		public int CI{
				get{return ci;}
		        set{ ci=value;}
		        		
	}
		public short  Edad{
				get{return edad;}
		        set{ edad=value;}
		        		
	}
		
		public char GEnero{
				get{return genero;}
		        set{ genero=value;}
		        		
	}
		public string NAcionalidad{
			get{return nacionalidad;}
		        set{ nacionalidad=value;}
		        		
	}
		public int TElefono{
				get{return telefono;}
		        set{ telefono=value;}
		        		
	}
	}
}
