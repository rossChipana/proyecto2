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
	/// Description of Gareje.
	/// </summary>
	public class Gareje
	{
		private int capacidad;
		private string horario;
		private int cant_Camiones;
		private Camion [] C;
		private int cant_Vagonetas;
		private Vagoneta [] V;
		public Gareje(Camion c, Vagoneta v)
		{
			capacidad = 5;
			horario = "noche";
			cant_Camiones = 10;
			C =  new Camion[cant_Camiones];
			for (int i=0;i<C.Length;i++)
				C[i]=c;
			cant_Vagonetas = 20;
			V = new Vagoneta[cant_Vagonetas];
			for (int j=0;j<V.Length;j++)
				V[j]=v;
		}
		public void Leer(){
			Console.WriteLine("\n ===== Datos de Gareje ===== ");
			Console.Write("\tIngrese la Capacidad : ");
			capacidad = int.Parse(Console.ReadLine());
			Console.Write("\tIngrese el Horario : ");
			horario =  Console.ReadLine();
			Console.Write("\tIngrese numero de Camiones : ");
		    cant_Camiones =  int.Parse(Console.ReadLine());
		    for (int i=0;i<C.Length;i++)
		    	C[i].Leer();
		    Console.Write("\tIngrese numero de Vagonetas : ");
		    cant_Vagonetas =  int.Parse(Console.ReadLine());
		    for (int i=0;i<V.Length;i++)
		    	V[i].Leer();
		}
		public void Mostrar(){
			Console.WriteLine("\n ===== Mostrando Datos de Garaje =====");
			Console.WriteLine("Capacidad : "+capacidad);
			Console.WriteLine("Horarios : "+horario);
			Console.WriteLine("Cantidad de Camiones : "+cant_Camiones);
			for (int i=0;i<C.Length;i++)
		    	C[i].Mostrar();
			Console.WriteLine("Cantidad de Vagonetas : "+cant_Vagonetas);
			for (int j=0;j<V.Length;j++)
				V[j].Mostrar();
		}
		public int getCapacidad(){
			return capacidad;
		}
		public void setCapacidad(int capacidad){
			this.capacidad=capacidad;
		}
		public string getHorario(){
			return horario;
		}
		public void setHorario(string horario){
			this.horario=horario;
		}
		public Camion[] getCAMION(){
			return C;
		}
		public void setCamion(Camion[] C){
			this.C=C;
		}
		public Vagoneta[] getVAGONETA(){
			return V;
		}
		public void setVAGONATA(Vagoneta [] V){
			this.V=V;
		}
	}
}
