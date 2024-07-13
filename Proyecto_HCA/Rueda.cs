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
	/// Description of Rueda.
	/// </summary>
	public class Rueda
	{
		private string marca;
		private string modelo;
		public Rueda()
		{
			marca = "brid";
			modelo = "72J";
		}
		public void Leer(){
			Console.WriteLine("\n ===== Datos de la Rueda ===== ");
			Console.Write("\tIngrese la marca : ");
			marca = Console.ReadLine();
			Console.Write("\tIngrese la modelo : ");
			modelo = Console.ReadLine();
			              
		}
		public void Mostrar(){
			Console.WriteLine("\n ===== Mostrando Datos de la Rueda =====");
			Console.WriteLine("\tMarca : "+marca);
			Console.WriteLine("\tModelo : "+modelo);
		}
	public string MArca{
				get{return marca;}
		        set{ marca=value;}
		        		
	}
		public string MOdelo{
				get{return modelo;}
		        set{ modelo=value;}
		        		
	}
	}
}
