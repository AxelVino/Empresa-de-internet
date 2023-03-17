using System;

namespace Empresa
{
	
	public class Cliente : Persona
	{
		private int nroCli;
		private bool beneficio;
		private static int contador;
		private string plan;
		private int precio;
		private string tecnicoAsignado;
		private DateTime fechaAl;
		
		public Cliente(string nomCli,string apCli,int dni,string area,DateTime fechaAl,int precio,string plan, string tecnicoAsignado ):base(nomCli,apCli,dni,area)
		{
			this.fechaAl = fechaAl;
			//this.tec = tec;
			this.plan = plan;
			beneficio = false;
			nroCli = contador+1000;
			contador++;
			this.precio = precio;
			this.tecnicoAsignado = tecnicoAsignado;
		}
		
		
		//propiedades
		
		public int NroCli
		{
			get{return nroCli;}
		}
		
		public string Plan
		{
			set{plan = value; }
			get{return plan;}
		}
		
		public int Precio
		{
			set{precio = value; }
			get{return precio;}
		}

		public DateTime Fechal
		{
			get{return fechaAl;}
		}
		
		public bool Beneficio
		{
			set{beneficio = value;}
			get{return beneficio;}
		}
		
		
		public int Contador
		{
			get{return contador;}
		}
		
		public string TecAsignado
		{
			set{tecnicoAsignado = value;}
			get{return tecnicoAsignado;}
		}
		
		//metodos
		
		public void mostrarme()
		{
			Console.WriteLine("");
			Console.WriteLine("....DATOS DEL CLIENTE...");
			Console.WriteLine("--Nro de Cliente:"+nroCli);
			Console.WriteLine("--Nombre: "+Nombre);
			Console.WriteLine("--Apellido: "+Apellido);
			Console.WriteLine("--DNI: "+Dni);
			Console.WriteLine("--Area: "+Area);
			Console.WriteLine("--promo: "+beneficio);
			Console.WriteLine("--Plan: "+plan);
			Console.WriteLine("--Precio: $"+Precio);
			Console.WriteLine("--fecha de inscripcion:"+fechaAl.Day+"/"+fechaAl.Month+"/"+fechaAl.Year);
			//Console.WriteLine("--tecnico asignado: "+"NRO: "+tec.NroTec+" Nombre: "+tec.Nombre+" ZONA: "+tec.Area);
			Console.WriteLine("");
		}
		
		public override string ToString()
		{
			return "Cliente n°"+NroCli+" \nApellido: "+Apellido+"\nNombre: "+Nombre+" \nDni: "+Dni+" \nLocalidad: "+Area+
				" \nFecha alta: "+fechaAl.Day+"/"+fechaAl.Month+"/"+fechaAl.Year+" \nPlan: "+Plan+" $"+Precio+
				" \nBeneficio activo: "+Beneficio+
				" \nTecnico asignado: "+tecnicoAsignado+"\n";
		}
		
		
	}
}
