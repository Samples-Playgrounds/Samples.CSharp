using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Console;
using System.Convert;

namespace CSharp.V6
{
	public partial class UsingStaticClass
	{
		public static void UsingStaticClassMethodsWithoutClassSpecification()
		{
			WriteLine("Enter first value ");
			int val1 = ToInt32(ReadLine());
			WriteLine("Enter next value ");
			int val2 = ToInt32(ReadLine());
			WriteLine("sum : {0}", (val1 + val2));
			ReadLine();

			return;
		}
	}
}
