using Euler.Net.Excercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Net
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Type interfaceType = typeof(IExcercise);
				Type[] types = AppDomain.CurrentDomain.GetAssemblies()
										.SelectMany(a => a.GetTypes())
										.Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
										.ToArray();
				List<IExcercise> excercises = new List<IExcercise>();
				foreach (Type type in types)
				{
					excercises.Add((IExcercise)Activator.CreateInstance(type));
				}
				Console.WriteLine("Which excercise?");
				Console.Write("> ");
				string excerciseIndex = Console.ReadLine();
				IExcercise excercise = excercises.Where(e => e.Excercise == excerciseIndex).FirstOrDefault();
				if (excercise != null)
				{
					excercise.Execute();
				}
				else
				{
					throw new ArgumentException(string.Format("Excercise with key {0} not found", excerciseIndex));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(string.Format("Caught exception: {0}", e.Message));
			}
			finally
			{
				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
			}
		}
	}
}
