using System;
using System.Threading;

namespace EjemploPractica2
{
	class Principal
	{
		
		public void ejemploClear(){
			Console.WriteLine("Hola Mundo");
			Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Limpio");
		}
		
		public void ejemploFecha(){
			DateTime fechaActual = DateTime.Now;
			Console.WriteLine("Hora Actual");
			Console.WriteLine(fechaActual.Hour + ":" + 
			                  fechaActual.Minute + ":"
			                  + fechaActual.Second);
			
		}
		
		public void ejemploSleep(){
			Console.WriteLine("Dormido 3 segundos");
			System.Threading.Thread.Sleep(3000);// 3 segundos
			Thread.Sleep(1000);//1 segundo
			Console.Clear();
			Console.WriteLine("Desperto");
		}
		
		public static void Main (string[] args)
		{
			Principal programa = new Principal();
			programa.ejemploClear();
			programa.ejemploFecha();
			programa.ejemploSleep();
		}
	}
}

