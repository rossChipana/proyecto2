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
	/// Description of Administrativo.
	/// </summary>
	public class Administrativo:Empleado
	{
		private string tipo_admi;
		public Administrativo():base()
		{
			tipo_admi="Gerente General";
		}
		public void Leer(){
			Console.WriteLine("-- Datos de Administrativo --");
			base.Leer();
			Console.Write("ingrese turno");
			tipo_admi =Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n<<<<<<<<<<< Mostrando datos de Administrativo >>>>>>>");
			base.Mostrar();
			Console.WriteLine("\tAdministrativo  = " +tipo_admi);
		}
			
		//propiedades del atributo
		public string Tipo_ADMI{
			get{return tipo_admi;}
		   set{ tipo_admi=value;}
			
		}
		
	}
}
