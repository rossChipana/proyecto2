/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
		protected string marca;
		protected string placa;
		protected short modelo;
		protected Motor Mo = new Motor();
		protected  int cant_Ruedas;
		protected List<Rueda>Ru;
		public Vehiculo(Rueda r)
		{
			marca = "toyota";
			placa = "1234ABC";
			modelo = 2024;
			int cant_Ruedas = 4 ;//ya no es una variable local sino solo global
			Ru =  new;List<Rueda>();
			for (int i=0;i<Ru.Length;i++)
				Ru.Add(r);
		}
		public Vehiculo(string marcas, string placas, short modelos)
        {
            marcas = marca;
            placas = placa;
            modelos = modelo;
        }
		public void Leer(){
			Console.Write("\tIngrese la marca : ");
			marca =  Console.ReadLine();
			Console.Write("\tIngrese la placa : ");
			placa = Console.ReadLine();
			Console.Write("\t Ingrese el modelo " );
			modelo = short.Parse(Console.ReadLine());
			Mo.Leer();
		    Console.Write("\tIngrese numero de Ruedas : ");
		   int  cant_Ruedas =  int.Parse(Console.ReadLine());
		   for (int i=0;i<Ru.Length;i++){
		   	Rueda rr= new Rueda();
		   	rr.Leer();
		   	Ru.Add(rr);
		}
		}
		public void Mostrar(){
			Console.WriteLine("\tMarca : "+marca);
			Console.WriteLine("\tPlaca : "+placa);
			Console.WriteLine("\tModelo : "+modelo);
			Mo.Mostrar();
			Console.WriteLine("\tCantidad de ruedas : "+Rueda.cou);
		/*
		 foreach(tipo variable in coleccion)
		 * tipo: el Tipo de dato de los elementos que se encuentran en la cleccion o array
		 * varibale: es temporal que almacena el valor del elemento actual en la interacion
		 * coleccion: es la coleccion o array que desea correr o ejecutar.
		 */
		foreach(Rueda Rueda in Ru){
			Rueda.Mostrar();
		}
			
		}
		
		
		//propiedades del atributo
		public string Marca{
			get{return marca;}
		   set{ marca=value;}
			
		}
		public string Placa{
			get{return placa;}
		   set{ placa=value;}
			
		}
		
		public short Modelo{
			get{return modelo;}
		   set{ modelo=value;}
			
		}
		//propiedades del atributo objeto
		public List<Rueda> LISTRUEDAS{
				get{return Ru;}
		        set{ Ru=value;}
		        		
		}
		public Motor  MOTOR{
				get{return Mo;}
		        set{ Mo=value;}
			
	}
}
}