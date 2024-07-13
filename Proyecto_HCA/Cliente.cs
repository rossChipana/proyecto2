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
	/// Description of Cliente.
	/// </summary>
	public class Cliente : Persona
	{
		private int nro_cliente;
		public Cliente():base()
		{
			nro_cliente =2;
		}
		public void Leer(){
			Console.WriteLine("-- Datos de Cliente --");
			base.Leer();
			Console.Write("ingrese turno");
			nro_cliente =int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("<<<<<<<<<<Mostrando datos de Cliente >>>>>>>>>>>");
			base.Mostrar();
			Console.WriteLine("\tNumero de clientes = " +nro_cliente);
		}
		 public int NRO_Cliente{
			get{return nro_cliente;}
		   set{ nro_cliente=value;}
			
		}
		
	}
}
