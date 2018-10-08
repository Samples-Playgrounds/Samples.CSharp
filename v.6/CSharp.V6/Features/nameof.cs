using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Console;

namespace CSharp.V6
{
	public class nameofExpression
	{

		public static void  nameof_ExpressionDemo()
		{
			Person p = new Person();
			WriteLine("{0} : {1}", nameof(Person.Name), p.Name);
			WriteLine("{0} : {1}", nameof(Person.DateOfBirth), p.DateOfBirth);

			return;
		}
	}


	public class Person
	{
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }

	}
}
