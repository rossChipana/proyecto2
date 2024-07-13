/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Gareje.
	/// </summary>
	public class Garaje
	{
		private int capacidad;
		private string horario;
		private int cant_camiones;
		private int cant_vagonetas;
		private List<Camion >C;
		private List<Vagoneta >V;
			public Garaje(Camion c, Vagoneta v)
		{
				capacidad =10;
				horario ="";
				cant_camiones=2;
				C= new List<Camion >C;
				for(int i=0 ;i<C.Length;i++){
					C[i]=c;
				}
				cant_vagonetas=5;
				V = new List<Vagoneta >V;
				for(int j=0 ;j<V.Length;j++){
					V[j]=v;
				}
			
		}
			public void Leer(){
				Console.Write("\t--Datos de Garaje -- ");
				Console.Write("\nIngrese la capacidad : ");
				capacidad = int.Parse(Console.ReadLine());
				Console.Write("\nIngrese la horario : ");
				horario = Console.ReadLine();
				Console.Write("\nIngrese numero de camiones : ");
				cant_camiones = int.Parse(Console.ReadLine());
				for(int i=0 ;i<cant_camiones;i++){
					Camion C=new Camion(new Rueda(),new Carga());
					C=Leer();
					C=Add(C);
				}
				Console.Write("\nIngrese numero de vagonetas : ");
				cant_vagonetas = int.Parse(Console.ReadLine());
				for(int j=0 ;j<cant_vagonetas;j++){
					V.Leer();
					V.Add(v);
				}
				
				
			}
			public void Mostrar(){
				Console.Write("\t--Mostrando Datos de Garaje -- ");
				Console.WriteLine("\tCapacidad = " +capacidad);
				Console.WriteLine("\tHorario = " +horario);
				Console.WriteLine("\tCantidad camiones  = " +C.count);
				//for(int i=0 ;i<C.Length;i++){
					//C[i].Mostrar();
				//}
				foreach(Camion a in C)
					C.Mostrar();
				Console.WriteLine("\tCantidad vagonetas  = " +cant_vagonetas);
				foreach(Vagoneta b in V)
					b.Mostrar();
			}
		public int Capacidad{
			get{return capacidad;}
		   set{ capacidad=value;}
			
		}
		public string HOrario{
			get{return horario;}
		   set{ horario=value;}
			
		}
		public int CANT_camiones{
			get{return cant_camiones;}
		   set{ cant_camiones=value;}
			
		}
			public int CANT_vagonetas{
			get{return cant_vagonetas;}
		   set{ cant_vagonetas=value;}
			
		}
		//propiedades del atributo objeto
		public List<Camion>	LISTCAMION{
				get{return  C;}
		        set{ C=value;}
		        		
	}
			public List<Vagoneta> VAGONETA{
				get{return  V;}
		        set{ V=value;}
		        		
	}
		//a) Buscar al camion con placa x modificar su marca 
		public void BuscarCamion2(){
			Console.Write("\nPlaca del camion a buscar");
			string x=Console.ReadLine();
			for(int i=0 ;i<cant_camiones;i++){
				C[i].BuscarCamion1(x);
			
		}
}
}
}