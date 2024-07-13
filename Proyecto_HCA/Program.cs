/*
 * Creado por SharpDevelop.
 * Usuario: LAB_3-PC
 * Fecha: 16/05/2024
 * Hora: 11:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_HCA
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Administrativo A = new Administrativo();
			Operario O = new Operario();
			Cliente C = new Cliente();
			
			Empresa HCA = new Empresa(A,O,C);
			HCA.Mostrar();
//			HCA.Leer();
//			HCA.Mostrar();
			//a) Buscar al camion con placa x modificar su marca 
			//1ra forma(propiedades)
			
			//HCA.BuscarCamion();
			//2da forma   primero se va  camion 2do garage ultimo empresa
		    // HCA.BuscarCamion3();
		    
			//b)entre los empleado  buscar quieenes tengan mas de "x" años de antiguedad ,modificar su sueldo masa un 8%. mostrar datos actualizados
			//1ra forma
			//HCA.ModificarSueldo();
			//2da forma
			
			//c)Buscar la marca de la rueda "x" de las vagonetas, mostrar modelo de su rueda
			//1ra forma
			//HCA.BuscarRueda();
			//d)entre los camiones buscar la marca "x", modificar tipo de carga y potencia del motor.mostrar datos actuales
			//1ra forma 
			HCA.ModificarMC();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}