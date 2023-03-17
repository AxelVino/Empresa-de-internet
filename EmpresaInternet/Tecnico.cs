using System;

namespace Empresa
{
	
	public class Tecnico: Persona
	{
		private int nroTec;
		private static int contador;
		
		public Tecnico(string nomTec,string apTec,int dni,string area):base(nomTec,apTec,dni,area)
		{
			nroTec = contador+2000;
			contador++;
		}
		

		
		
		//propiedades
		
		public int NroTec
		{
			get{return nroTec;}
		}
		
		public string datosTecnico()
		{
			//Console.WriteLine("N° {0} \nApellido: {1} \nNombre: {2} \nDni: {3}",NroTec,Apellido,Nombre,Dni);
			return "N°"+NroTec+"\nApellido: "+Apellido+"\nNombre: "+Nombre+"\nDni: "+Dni;
		}
	}
}
