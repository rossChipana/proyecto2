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
	/// Description of Operario.
	/// </summary>
	public class Operario : Empleado
	{
		private string turno;
		public Operario():base()
		{
			turno="mañana";
			
		}
		public void Leer(){
			Console.WriteLine("\n<<<<<<<<<<<<<<< Datos de Operario >>>>>>>>>>>>>>>>>");
			base.Leer();
			Console.WriteLine("\n Ingrese turno");
			turno =Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n=======Mostrando datos de Operario ====");
			base.Mostrar();
			Console.WriteLine("\tTurno = " +turno);
		}
		
		public string  Turno{
				get{return turno;}
		        set{ turno=value;}
		        		
	}
		
		        		
	}
	}

