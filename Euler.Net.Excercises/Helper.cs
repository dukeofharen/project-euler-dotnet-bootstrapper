using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Net.Excercises
{
	public static class Helper
	{
		public static void WriteLineFormat(string format, params object[] parameters)
		{
			Console.WriteLine(string.Format(format, parameters));
		}

		public static bool IsPrime(int number)
		{
			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
