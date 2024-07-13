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
	/// Description of Empleado.
	/// </summary>
	public class Empleado:Persona
	{
		protected double sueldo;
		protected short años_antiguedad;
		public Empleado():base()
		{
			sueldo=2100;
			años_antiguedad=30;
		}
		public void Leer(){
			
			base.Leer();
			Console.WriteLine("\t Ingrese sueldo");
			sueldo = double.Parse(Console.ReadLine());
			Console.WriteLine("\ningrese Años de antiguedad");
			años_antiguedad = short.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			
			base.Mostrar();
			Console.WriteLine("\tTurno = " +sueldo);
			Console.WriteLine("\tAños de antiguedad = " +años_antiguedad);
		}
		 public double Sueldo{
			get{return sueldo;}
		   set{ sueldo=value;}
			
		}
		//propiedades del atributo objeto
		public short Años_ANTIGUEDAD{
				get{return años_antiguedad;}
		        set{ años_antiguedad=value;}
	}
}
}
