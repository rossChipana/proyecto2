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
	/// Description of Camion.
	/// </summary>
	public class Camion : Vehiculo
	{
		
    protected double tamaño;
   	private Carga Ca = new Carga();

   	public Camion(Rueda r, Carga c):base(r)
    {
    	tamaño=25;//toneladas
    	Ca=c;
    	
    }

    public void Leer()
    {
        Console.WriteLine("-- Datos de Camion -- ");
        base.Leer();
        Console.WriteLine("Ingrese el tamaño del camión: ");
        tamaño = double.Parse(Console.ReadLine());
        Ca.Leer();
    }

    public void Mostrar()
    {
    	Console.WriteLine("-- Mostrando Datos de Camion -- ");
    	base.Mostrar();
        Console.WriteLine("\tTamaño del camión: " + tamaño);
        Ca.Mostrar();
        
    }
    public double Tamaño{
			get{return tamaño;}
		   set{ tamaño=value;}
			
		}
		//propiedades del atributo objeto
		public Carga CARGA{
				get{return Ca;}
		        set{ Ca=value;}
			
		}
		//a) Buscar al camion con placa x modificar su marca 
		public void BuscarCamion1(string x){
			if(placa.ToLower().Equals(x.ToLower())){
				Console.Write("nueva marca para camion:  ");
				marca=Console.ReadLine();
				Mostrar();
				
			}
		}
   
    
    }
  }



