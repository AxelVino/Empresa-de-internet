using System;

namespace Empresa
{
	
	public class  CupoInsuficienteException : Exception
	{
		public override string Message
		{
			get {return " Cupos Insufientes.";}
			
		}

	}
}
