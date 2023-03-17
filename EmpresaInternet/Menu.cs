using System;

namespace Empresa
{
	
	public class Menu
	{
		
		public Menu()
		{
		}
		
		
		//metodos
		
		public void menuA(Empresa dire) //******************************************************************************************
		{
			
			do
			{
				//Console.Clear();
				try {
					Console.Write("...............................................\n\nIngrese Nombre: ");
					string nom = Console.ReadLine();
					Console.Write("Ingrese Apellido: ");
					string ap = Console.ReadLine();
					Console.Write("Ingrese DNI: ");
					int dni = int.Parse(Console.ReadLine());
					Console.Write("ingrese Area: ");
					string area = Console.ReadLine();
					Console.Write("ingrese Plan: ");
					string plan = Console.ReadLine();
					Console.Write("ingrese Precio: $");
					int precio = int.Parse(Console.ReadLine());
					
					//fecha
					Console.Write("ingrese la fecha de inscripcion (dd/mm/aaaa): ");
					string fecha = Console.ReadLine();
					
					string [] partes = fecha.Split(new char[]{'/'} );
					
					int dia = int.Parse(partes[0]);
					int mes = int.Parse(partes[1]);
					int año = int.Parse(partes[2]);
					
					
					DateTime f = new DateTime(año,mes,dia);
					
					//asigna un tecnico
					
					//este tecnico es auxiliar para poder asignarselo al cliente mas  tarde
					
					string asig = "";
					
					
					/*//NOTA: debes crear primero los tecnicos antes que los clientes
					Tecnico asig = new Tecnico("","",0,"area");
					
					foreach (Tecnico p in dire.LisTec) {
						if (p.Area==area) {
							
							asig = p;
						}
					}*/
						
						Cliente x = new Cliente(nom,ap,dni,area,f,precio,plan,asig);
					Console.WriteLine("El numero asignado a este cliente es: "+x.NroCli);
					Console.WriteLine("...............................................");
					dire.altaCliente(x);
					Console.WriteLine("...............................................");
					
					foreach (Tecnico xArea in dire.LisTec) {
						if (area == xArea.Area) {
							x.TecAsignado = xArea.datosTecnico();
						}
					}
					
				}catch(Exception exp){
					Console.WriteLine(" Error " +exp.Message);
				}
				
				
				do{
					Console.WriteLine("desea agregar otro cliente?");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
				
				
			}while (respuesta != "no");
			
		}  //***********************************************************************************************************************
		
		
		public void menuB(Empresa dire)  //*****************************************************************************************
		{
			/*Cambiar servicio de un cliente:
  				ingreso el numero de cliente
				recorro la lista buscando una coincidencia
			 	si la hay, retorno los datos del cliente
			 	cambio el plan y el precio*/
			
			do
			{
				Console.Write("...............................................\n\nIngrese n° de cliente a modificar plan: ");
				buscarNro = int.Parse(Console.ReadLine());
				if (dire.EsCliente(buscarNro)) {
					Console.Write("................. \n..CAMBIAR PLAN... \n..ingresa el nombre del nuevo plan: ");
					string nuevoPlan = Console.ReadLine();
					Console.Write("..ingresa el precio del nuevo plan: $");
					int nuevoPrecio = int.Parse(Console.ReadLine());
					
					foreach (Cliente xCliente in dire.LisCli) {
						
						if (xCliente.NroCli == buscarNro) {
							xCliente.Plan = nuevoPlan;
							xCliente.Precio = nuevoPrecio;
							break;
						}
					}
					Console.WriteLine("\n..DATOS ACTUALIZADOS..\n");
					Console.WriteLine(dire.verCliente(buscarNro));
				}
				else{
					Console.WriteLine("\nUps! ese cliente no existe");
				}
				do{
					Console.WriteLine("...............................................\n\nDesea modificar el plan a otro cliente? (si/no)");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
				
			}while (respuesta != "no");
			
			
		}//fin opcion B  //*********************************************************************************************************
		
		
		public void menuC(Empresa dire)  //*****************************************************************************************
		{
			//Console.WriteLine("...ELIMINAR UN CLIENTE...");
			
			do
			{
				Console.Write("...............................................\n\nIngrese el numero del cliente a eliminar: ");
				int eli = int.Parse(Console.ReadLine());
				
				dire.bajaCliente(eli);
				do{
					Console.WriteLine("\ndesea eliminar otro cliente?");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
				
			}while (respuesta != "no");
			
		} //************************************************************************************************************************
		
		
		
		public void menuD(Empresa dire) //******************************************************************************************
		{
			//mostrara los tecnicos de una zona especifica
			do
			{
				Console.WriteLine("..BUSCAR TECNICOS..");
				Console.Write("ingrese el area: ");
				string zona = Console.ReadLine();
				bool existe = false;
				
				foreach (Tecnico xZona in dire.LisTec) {
					if (zona == xZona.Area) {
						existe = true;
					}
				}
				
				if (existe) {
					Console.WriteLine("..LISTADO DE TECNICOS DE: "+zona.ToUpper());
					dire.listaTecnicos(zona);
				}
				else
				{
					Console.WriteLine("NO se a encontrado el Area..");
				}
				
				Console.WriteLine("...............................................");
				do{
					Console.WriteLine("\nDesea realizar otra busqueda?");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
			}while (respuesta != "no");
			
		}  //***********************************************************************************************************************
		
		
		public void menuE(Empresa dire) //******************************************************************************************
		{
			//mostrara la lista de todos los clientes
			
			if (dire.TotalClientes() > 0) {
				Console.WriteLine("\n          ...LISTADO DE CLIENTES...     \n...............................................\n");
				dire.ListaClientes();
				Console.WriteLine("...............................................");
			}
			else
			{
				Console.WriteLine("\nAun no se registraron clientes!!\n");
			}
			
		}//fin opcion E  //*********************************************************************************************************
		
		
		public void menuF(Empresa dire) //******************************************************************************************
		{
			//Console.Clear();
			//agregara un nuevo tecnico
			do{
				Console.Write("...............................................\n\nIngrese nombre: ");
				string nomT = Console.ReadLine();
				Console.Write("Ingrese apellido: ");
				string apT = Console.ReadLine();
				Console.Write("Ingrese DNI: ");
				int dniT = int.Parse(Console.ReadLine());
				Console.Write("ingrese area: ");
				string areaT = Console.ReadLine();
				areaT = areaT.ToLower();
				Tecnico t = new Tecnico(nomT,apT,dniT,areaT);
				dire.agregrarTec(t);
				Console.WriteLine("Nro de tecnico asignado: "+t.NroTec);
				
				foreach (Cliente xCliente in dire.LisCli) {
					if (xCliente.TecAsignado == "") {
						foreach (Cliente xArea in dire.LisCli) {
							if (xArea.Area == areaT) {
								xArea.TecAsignado = "\nN°"+t.NroTec+"\nApellido: "+apT+"\nNombre: "+nomT+"\nDni: "+dniT;
							}
						}
					}
				}
				
				do{
					Console.WriteLine("...............................................\n\nDesea agregar otro tecnico?");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
					
			}while (respuesta != "no");
			
		}//fin opcion f  //*********************************************************************************************************
		
		
		public void menuG(Empresa dire)  //*****************************************************************************************
		{
			do
			{
				Console.WriteLine("...ELIMINAR UN TECNICO...");
				Console.Write("ingrese el numero del Tecnico a eliminar: ");
				int tce = int.Parse(Console.ReadLine());
				
				dire.bajaTecnico(tce);
				
				do{
					Console.WriteLine("\nDesea eliminar otro tecnico?");
					respuesta = Console.ReadLine();
					respuesta = respuesta.ToLower();
					if (respuesta == "no") break;
					if (respuesta != "si" && respuesta != "no") {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
					
				}while (respuesta != "si");
				
			}while (respuesta != "no");
			
		}   //**********************************************************************************************************************
		
		
		static string respuesta;
		static int buscarNro;
	}
	
}
