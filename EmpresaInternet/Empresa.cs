using System;
using System.Collections;

namespace Empresa
{
	
	public class Empresa
	{
		private string nombre;
		private int cupo;
		private int mesInicio;
		private int mesFin;
		private ArrayList Clientes;
		private ArrayList Tecnicos;
		
		public Empresa(string nombre,int mesInicio,int mesFin)
		{
			this.nombre = nombre;
			this.mesInicio = mesInicio;
			this.mesFin = mesFin;
			Clientes = new ArrayList();
			Tecnicos = new ArrayList();
			cupo = 3;
		}
		
		//propiedades
		
		public string Nombre
		{
			get{return nombre;}
		}
		
		public ArrayList LisCli
		{
			get{return Clientes;}
		}
		
		public ArrayList LisTec
		{
			get{return Tecnicos;}
		}
		
		
		
		// => Metodos Cliente/es.
		
		public void altaCliente(Cliente unCli)  //**********************************************************************************
		{
			Clientes.Add(unCli);
			
			if (unCli.Fechal.Month >= mesInicio && unCli.Fechal.Month <= mesFin) {
				
				
				
				try{
					if (cupo>0){
						
						Console.WriteLine("El cliente accedio a una promocion");
						unCli.Beneficio = true;
						cupo -= 1;
						unCli.Precio = unCli.Precio-(unCli.Precio/2);
						//Console.WriteLine("..................................");
					}
					else{
						throw new CupoInsuficienteException();
						
						
						
					}
				}catch(CupoInsuficienteException e){
					Console.WriteLine(e.Message);
				}
			}
			else{
				Console.WriteLine("el cliente se agrego fuera del plazo de promocion.. \n");
			}
			
			
		}  //***********************************************************************************************************************
		
		public void bajaCliente(int nroCliBuscar)  //*******************************************************************************
		{
			//Para dar de baja un cliente necesito:buscar el Cliente por su nroCliente
			//	con .IndexOf(objeto) conocer el indice de la pocision donde se encuentra almacenado
			// 	con .RemoveAt(indice) eliminar xCliente
			
			if (EsCliente(nroCliBuscar)) {

				
				foreach (Cliente x in Clientes)
				{
					if (x.NroCli == nroCliBuscar)
					{
						Clientes.RemoveAt(Clientes.IndexOf(x));
						Console.WriteLine("\nEl cliente fue eliminado con exito..");
						break;
					}
				}

			}
			else{
				Console.WriteLine("\nUps! ese cliente no existe");
			}
			
		}  //***********************************************************************************************************************
		
		public string verCliente(int nroCliBuscar)  //******************************************************************************
		{
			/*retorna el cliente iesimo:
			 ingreso el numero de cliente
			 verifico que exista:
			 recorro la lista buscando una coincidencia
			 si la hay, retorno los datos del cliente
			 de lo contrario imprimo msj de no coincidencia*/
			
			string datosCliente="";
			
			if (EsCliente(nroCliBuscar)) {
				foreach (Cliente xCliente in LisCli) {
					if (xCliente.NroCli == nroCliBuscar) {
						datosCliente = xCliente.ToString();
					}
				}
			}
			else
				datosCliente = "Ups! ese cliente no existe";
			
			return datosCliente;
			
		}  //***********************************************************************************************************************
		
		public int TotalClientes()  //*********************************************************************************************
		{
			return Clientes.Count;
			
		}  //***********************************************************************************************************************
		
		public bool EsCliente(int nroCli)  //***************************************************************************************
		{
			
			bool verificacion = false;
			
			foreach (Cliente x in Clientes) {
				if (x.NroCli ==nroCli) {
					verificacion = true;
				}
				else
					verificacion = false;
			}
			return verificacion;
			// Funciona de 10..
			
		}  //***********************************************************************************************************************
		
		public void ListaClientes()  //*********************************************************************************************
		{
			/* retorna el arraylist de clientes*/
			
			foreach (Cliente xCliente in LisCli) {
				Console.WriteLine(xCliente.ToString());
			}
			
		}  //***********************************************************************************************************************
		
		// => Metodos Tecnicos
		
		public void agregrarTec(Tecnico unTec)
		{
			Tecnicos.Add(unTec);
		}
		
		
		public void bajaTecnico(int nroTecBuscar)
		{
			
			if (esTecnico(nroTecBuscar)) {
				
				foreach (Tecnico x in Tecnicos)
				{
					if (x.NroTec == nroTecBuscar)
					{
						Tecnicos.RemoveAt(Tecnicos.IndexOf(x));
						Console.WriteLine("El Tecnico fue eliminado con exito..");
						break;
					}
				}
			}
			else{
				Console.WriteLine("Ups! ese Tecnico no existe");
			}
			
		}
		
		public int cantidadTecnicos()  //*******************************************************************************************
		{
			return LisTec.Count;
			
		}  //***********************************************************************************************************************
		
		public bool esTecnico(int nroTec)
		{
			
			bool veri = false;
			
			foreach (Tecnico x in Tecnicos) {
				if (x.NroTec ==nroTec) {
					veri = true;
				}
				else
					veri = false;
			}
			return veri;
			
		}
		
		public void listaTecnicos(string zona)
		{
			// retorna la lista de tecnicos
			
			foreach (Tecnico tc in LisTec) {
				
				if (tc.Area == zona) {
					Console.WriteLine("NRO:"+tc.NroTec+"Nombre: "+tc.Nombre+"Apellido: "+tc.Apellido+"Area: "+tc.Area);
				}
			}
		}
	}
}
