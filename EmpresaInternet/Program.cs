using System;

namespace Empresa
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//creamos la empresa
			//NOTA: no la borres o romperas todo,saludos Gaby c:
			Empresa dire = new Empresa("directv",5,8);
			Menu menu = new Menu();
			
			/*agrego otro do while para que solo ingresen si o no*/
			
			Console.WriteLine("                ...Bienvenido...\n");
			Console.WriteLine("      ...SISTEMA DE GESTION DE "+dire.Nombre.ToUpper()+"...");
			int opcion;

			do
			{
				do
				{
					Console.WriteLine("..............................................." +
					                  "\n                   Menu  " +
					                  "\n...............................................\n1-Agregar un cliente" +
					                  "\n2-Cambiar servicio de un cliente\n3-Eliminar cliente\n4-Ver lista de tecnicos en area" +
					                  "\n5-Ver lista de clientes\n6-Agregar Tecnico\n7-Eliminar Tecnico\n8-salir" +
					                  "\n...............................................");
					Console.Write("\nIngrese una opcion para continuar: ");
					opcion = int.Parse(Console.ReadLine());
					switch (opcion) {
						case 1:
							//agregar un cliente

							menu.menuA(dire);

							break;
						case 2:
							/*Cambiar servicio de un cliente:*/

							menu.menuB(dire);

							break;



						case 3:
							//Eliminar cliente

							menu.menuC(dire);
							break;



						case 4:
							//Ver lista de tecnicos en area
							menu.menuD(dire);
							break;
						case 5:
							//Ver lista de clientes
							menu.menuE(dire);

							break;
						case 6:
							//Agregar Tecnico Console.Write("\nIngrese Apellido y Nombre: ");
							
							menu.menuF(dire);
							
							break;
						case 7:
							//Eliminar Tecnico
							menu.menuG(dire);
							break;

					}

					if (opcion <1 || opcion > 8) {
						Console.WriteLine("Opcion ingresada es incorrecta..\n");
					}
				}while (opcion <1 | opcion < 8);

			}while (opcion !=8);
			
			
			
			/*aca comienza el de gabi*/
			/*Console.WriteLine("  ...SISTEMA DE GESTION DE "+dire.Nombre.ToUpper()+"...");
			
			string Ac;
			
			do{
				
				Console.WriteLine("");
				dire.TotalClientes();
				
				Console.WriteLine("...............................................");
				Console.WriteLine("Bienvenido! ingrese una opcion para continuar: ");
				Console.WriteLine("...............................................");
				Console.WriteLine("A-Agregar un cliente");
				Console.WriteLine("B-Cambiar servicio de un cliente");
				Console.WriteLine("C-Eliminar cliente");
				Console.WriteLine("D-Ver lista de tecnicos en area");
				Console.WriteLine("E-Ver lista de clientes");
				Console.WriteLine("F-Agregar Tecnico");
				Console.WriteLine("G-Eliminar Tecnico");
				Console.WriteLine("H-salir");
				Console.WriteLine("...............................................");
				Console.Write("opcion: ");
				string op = Console.ReadLine();
				
				switch (op) {
					case "a":
						menu.menuA(dire);
						break;
						
					case "b":
						menu.menuB(dire);
						break;
						
					case "c":
						
						menu.menuC(dire);
						
						break;
					case "d":
						
						menu.menuD(dire);
						
						break;
						
					case "e":
						menu.menuE(dire);
						
						break;
					case "f":
						
						menu.menuF(dire);
						
						break;
					case "g":
						
						menu.menuG(dire);
						
						break;
						
				}//fin del switch
				
				
				//esta instruccion siempre se ejecutara para volver a ejecutar el menu
				Console.WriteLine("");
				Console.Write("Desea seguir operando? (si/no): ");
				Ac = Console.ReadLine();
				
				
			}while(Ac !="no");//fin del do while
			*/
			
			
			
			
			
			//mensaje de despedida c:
			Console.WriteLine("..................................");
			Console.WriteLine("..................................");
			Console.WriteLine("Es triste verte partir,nos vemos :(");
			Console.WriteLine("..................................");
			Console.WriteLine("..................................");
			Console.ReadKey(true);
			
		}
	}
}