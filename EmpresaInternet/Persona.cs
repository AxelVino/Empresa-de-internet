using System;

namespace Empresa
{

	public class Persona
	{
		private string nombre;
		private string apellido;
		private int dni;
		private string area;
		
		public Persona(string nombre,string apellido,int dni,string area)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.area = area;
		}
		
		
		//propiedades
		
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		
		public string Apellido
		{
			set{apellido = value;}
			get{return apellido;}
		}
		
		public int Dni
		{
			set{dni = value;}
			get{return dni;}
		}
		
		public string Area
		{
			set{area = value;}
			get{return area;}
		}
	}
}
