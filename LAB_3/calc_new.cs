using System;
using System.Reflection;
[assembly : AssemblyVersion("1.0.0.0")]
namespace Lab3
{
	class Calculator
	{
		public int addition(int x, int y)
		{
			Console.WriteLine("new version");
			return x+y;
		}
		public int multiplication(int x, int y)
		{
			return x*y;
		}
	}
}