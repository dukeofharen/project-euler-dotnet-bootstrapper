using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Net.Excercises.Interfaces
{
	public interface IExcercise
	{
		string Excercise { get; }
		void Execute();
	}
}
