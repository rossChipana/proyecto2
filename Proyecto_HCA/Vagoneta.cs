/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Bagoneta.
	/// </summary>
	public class Vagoneta : Vehiculo
	{
		public string tipo;
		public Vagoneta(Rueda r):base(r)
		{
			tipo ="Carreteras- asfalto";
		}
		public void Leer(){
			Console.WriteLine("\t-- Datos de Vagoneta--  ");
			base.Leer();
			Console.WriteLine("\tIngrese la marca : ");
			tipo =  Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n-- Mostrando Datos de Vagoneta--  ");
			base.Mostrar();
			Console.WriteLine("\tMarca : "+tipo);
			
		}
		public string TIpo{
				get{return tipo;}
		        set{ tipo=value;}
		        		
	}
	}
}
