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
	/// Description of Carga.
	/// </summary>
	public class Carga
	{
		protected string tipo;
    protected string ambiente;

    public Carga()
    {
    	tipo = "Minerales";
    	ambiente="calido";
    }

    public void Leer()
    {
        Console.WriteLine("Ingrese el tipo de carga: ");
        tipo = Console.ReadLine();

        Console.WriteLine("Ingrese el ambiente de la carga: ");
        ambiente = Console.ReadLine();
    }

    public void Mostrar()
    {
        Console.WriteLine("\tTipo de carga: " + tipo);
        Console.WriteLine("\tAmbiente de la carga: " + ambiente);
    }
     
    public string Tipo{
			get{return tipo;}
		   set{ tipo=value;}
			
		}
		//propiedades del atributo objeto
		public string Ambiente{
				get{return ambiente;}
		        set{ ambiente=value;}
			
    }
    
}


}
