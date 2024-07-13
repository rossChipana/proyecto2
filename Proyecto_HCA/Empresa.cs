/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace Proyecto_HCA
{
	/// <summary>
	/// Description of Empresa.
	/// </summary>
	public class Empresa
	{
		private string nombre;
		private string direccion;
		private long nit;
		private int cant_admi;
		private int cant_op;
		private int cant_cli;
		private List<Administrativo >Ad;
		private List<Operario>Op;
		private List<Cliente>Cli;
		private Garaje G;
		public Empresa(Administrativo a , Operario o , Cliente c)
		{
			nombre = "ABC";
			direccion ="Avenida prado";
			nit = 34543;
			cant_admi = 2;
			Ad = new List<Administrativo >Ad;
			for(int i=0 ;i<cant_admi;i++){
					
					Ad=Add(o);
				}
			cant_op=3;
			Op = new List<Operario>Op;
			for(int j=0 ;j<cant_op;j++){
					Op=Add(o)
				}
			cant_cli=5;
			Cli = new List<Cliente>Cli;
			for(int k=0 ;k<cant_cli;k++){
				Cli=(c);
				}
			Rueda ru = new Rueda ();
			Carga car = new Carga();
			Camion ca = new Camion(ru,car);
			Vagoneta va = new Vagoneta (ru);
			G= new Garaje (ca,va);
		}
		public void Leer(){
			Console.WriteLine("\n>>>>>>>>>>>>>>Datos de Empresa >>>>>>>>>>>");
			Console.WriteLine("\t Ingrese nombre: ");
			nombre= Console.ReadLine();
			Console.WriteLine("\nIngrese direccion: ");
			direccion= Console.ReadLine();
			Console.WriteLine("\nIngrese Nit: ");
			nit= short.Parse(Console.ReadLine());
			Console.WriteLine("\nIngrese cantidad de administrador : ");
			cant_admi= int.Parse(Console.ReadLine());
			for(int i=0 ;i<cant_admi;i++){
				aa.Leer();
				Ad.Add(aa);
			}
			Console.WriteLine("\nIngrese cantidad de Operarios : ");
			cant_op= int.Parse(Console.ReadLine());
			for(int j=0 ;j<cant_op;j++){
				aa.Leer();
				Op.Add(aa);
				
		}
			Console.WriteLine("\nIngrese cantidad de clientes : ");
			cant_cli= int.Parse(Console.ReadLine());
			for(int k=0 ;k<cant_cli;k++){
				aa.Leer();
				Cli.Add(aa);
		}
		
	}
		public void Mostrar(){
		Console.WriteLine("\n/////// Mostrando datos de Empresa //////");
			Console.WriteLine("\tNombre =  " +nombre);
			Console.WriteLine("\tDireccion =  " +direccion);
			Console.WriteLine("\tNIT =  " +nit);
			Console.WriteLine("\tCantidad de administrativos =  " +cant_admi);
			foreach(Administrativo a in Ad )
				a.Mostrar();
			
			Console.WriteLine("\tCantidad de Operarios =  " +cant_op);
			foreach(Operario o in Op)
				o.Mostrar();
			Console.WriteLine("\tCantidad de Clientes =  " +cant_cli);
			foreach(Cliente c in Cli)
				
				c.Mostrar();
			
		}		
		
	   //a) Buscar al camion con placa x modificar su marca 
			//1ra forma(propiedades)
			public void BuscarCamion(){
				//primero buscar la palca del camion
				Console.Write("\nIngrese placa del camion a buscar");
				string x =Console.ReadLine().ToLower();
				for(int i=0;i<G.CANT_camiones;i++)
					if (G.CAMION[i].Placa.ToLower().Equals(x)){
					Console.WriteLine("\nIngrese nueva marca del camion ");
					G.CAMION[i].Marca=Console.ReadLine();
					G.CAMION[i].Mostrar();
				}
			}
		//a) Buscar al camion con placa x modificar su marca 
		//2da forma
		public void BuscarCamion3(){
			G.BuscarCamion2();
			
		}
			//b)entre los empleado  buscar quieenes tengan mas de "x" años de antiguedad ,modificar su sueldo masa un 8%. mostrar datos actualizados
			//1ra forma
			public void ModificarSueldo(){
				Console.Write("\nIngrese a partir de años de antiguedad:");
				short x=short.Parse(Console.ReadLine());
				for(int i=0;i<cant_admi;i++){
					//luego verificamos
					if(Ad[i].Años_ANTIGUEDAD>x){
						Ad[i].Sueldo=Ad[i].Sueldo+Ad[i].Sueldo*0.08;
						Ad[i].Mostrar();
					}
				}
				for(int i=0;i<cant_op;i++){
					//luego verificamos
					if(Op[i].Años_ANTIGUEDAD>x){
						Op[i].Sueldo=Op[i].Sueldo+Op[i].Sueldo*0.08;
						Op[i].Mostrar();
			}
	      }
        }
			//c)Buscar la marca de la rueda "x" de las vagonetas, mostrar modelo de su rueda
			//1ra forma (propiedades)
			public void BuscarRueda(){
					Console.Write("\nIngrese marca  de la rueda a buscar:");
					string x= Console.ReadLine().ToUpper();
						for(int i=0;i<G.CANT_vagonetas;i++){
						for(int j=0;j<G.VAGONETA[j].CANT_ruedas;j++){
							if (G.VAGONETA[i].RUEDAS[j].MArca.ToUpper().Equals(x)){
								Console.WriteLine("\nModelo de larueda es : "+G.VAGONETA[i].RUEDAS[j].MOdelo);
					G.CAMION[i].Marca=Console.ReadLine();
					G.CAMION[i].Mostrar();
				
			}
	}
}
}
			//d)entre los camiones buscar la marca "x", modificar tipo de carga y potencia del motor.mostrar datos actuales
			//1ra forma 
			public void ModificarMC(){
				Console.Write("\nIngrese marca  dEL Camion  a buscar:");
					string x= Console.ReadLine().ToUpper();
				for(int i=0;i<G.CANT_camiones;i++){
						if (G.CAMION[i].Marca.ToUpper().Equals(x)){
						Console.Write("\nIngrese nuevo tipo de carga: ");
						G.CAMION[i].CARGA.Tipo=Console.ReadLine();
						Console.Write("\nIngrese nuevo tipo de carga: ");
						G.CAMION[i].MOTOR.Potencia=double.Parse(Console.ReadLine());
						G.CAMION[i].Mostrar();
			}
           }   
	    }
	}
}