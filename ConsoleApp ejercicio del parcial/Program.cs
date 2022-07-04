using System;

namespace ConsoleApp_ejercicio_del_parcial
{
	class Program
	{
		static void Main(string[] args)
		{
			int horas;
			string indicador;
			int minutos;
			int seg;
			Console.Write(" ingrese la hora deseada ");
			horas = int.Parse(Console.ReadLine());

			Console.Write("ingrese los minutos deseados ");
			minutos = int.Parse(Console.ReadLine());

			Console.Write("ingrese los segundos deseados ");
			seg = int.Parse(Console.ReadLine());

			Console.Write("seleccione (PM) o (AM) ");
			indicador = Console.ReadLine();

			if (indicador.ToUpper().Equals("PM") || indicador.ToUpper().Equals("AM"))
			{
				if (horas > 12 && horas <= 23)
				{
					Console.WriteLine("estamos en PM ");
					Console.WriteLine("su horas es " + horas + ":" + minutos + ":" + seg + "PM");
				}
				if (horas < 12 && horas >= 00)
				{
					Console.WriteLine("estamos en AM ");
					Console.WriteLine("su horas es " + horas + ":" + minutos + ":" + seg + "AM");
				}
				else
				{
					Console.WriteLine("los datos son erroneo ");
				}

			}
		}
	}
}
