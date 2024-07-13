/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Motor.
	/// </summary>
	public class Motor
	{
		private string modelo;
		private double peso;
		private double potencia;
		public Motor()
		{
			modelo = "TOSHIBA";
			peso = 50;//kg
			potencia = 200;//hp
		}
		public void Leer(){
			Console.WriteLine("\n ====== Datos de Motor =====");
			Console.Write("\tIngrese modelo : ");
			modelo = Console.ReadLine();
			Console.Write("\tIngrese el peso : ");
			peso = double.Parse(Console.ReadLine());
			Console.Write("\tIngrese el potencia : ");
			potencia = double.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("\n ===== Mostrando Datos del Motor =====");
			Console.WriteLine("\tModelo : "+modelo);
			Console.WriteLine("\tPeso : "+peso);
			Console.WriteLine("\tPotencia : "+potencia);
			                
		}
		public string Modelo{
				get{return modelo;}
		        set{ modelo=value;}
		        		
	}
		public double Peso{
				get{return peso;}
		        set{ peso=value;}
		        		
	}
		public double Potencia{
				get{return potencia;}
		        set{ potencia=value;}
		        		
	}
	}
}
