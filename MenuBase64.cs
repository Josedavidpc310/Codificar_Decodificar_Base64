using System;
using System.Text;

public class Example
{
   public static void Main()
   {  	 
	bool Repetir=true;
	int Opcion=1;
	String texto,base64;
	byte[] bytes;
	while(Repetir)
	{
	   while(Repetir)
	   {
		Console.WriteLine("====================================================");
	   	Console.WriteLine("Presione");
	   	Console.WriteLine("1. Codificar Base64");
	   	Console.WriteLine("2. Decodificar Base64");
		string OpcionString=Console.ReadLine();
		try{
	   		Opcion = Convert.ToInt16(OpcionString);
			break;
		}catch(Exception)
		{
			Console.WriteLine("Error, las unicas opciones disponibles son 1 y 2");
			//repetir
		}
	   }

	   switch (Opcion)
	   {
		case 1:   
			// Entrada
	   		Console.WriteLine("Ingrese el texto que desea pasar a base64:");
	   		texto=Console.ReadLine();
       			// Conversion cadena String en Byte Array
	   		bytes = Encoding.ASCII.GetBytes(texto);  
			foreach ( byte b in bytes){}
       			// Convertir Byte Array en cadena de texto base64.
       			base64 = Convert.ToBase64String(bytes);
       			Console.WriteLine("La cadena de texto base64 de "+texto+" es: "+base64+"\n");
		break;
		   
	   		case 2:
        		// Volver de cadena de texto en base64 a Byte Array.
			Console.WriteLine("Ingrese el base64 que desa decodificar:");
			base64=Console.ReadLine();
     			//Volver de Byte Array a Cadena String.
			try
			{
				bytes = Convert.FromBase64String(base64);
     				texto = Encoding.ASCII.GetString(bytes);
				Console.WriteLine("La cadena de texto base64 "+base64+" significa: "+texto);
			}
			catch(Exception)
			{
				Console.WriteLine("Error, el base64 ingresado no tiene significado");
			}
		break;
			   
		default:
			 Console.WriteLine("Error, la opcion seleccionada no hace parte de las opciones disponibles \n");  
		break;
	  }
   	}
	//repetir
  }
}
