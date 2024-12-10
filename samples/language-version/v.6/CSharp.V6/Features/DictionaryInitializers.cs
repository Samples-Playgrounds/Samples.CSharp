using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.V6
{
	class DictionaryInitializers
	{

		public static void DictionaryInitializer()
		{
			Dictionary<int, string> d = new Dictionary<int, string>()
			{
				{1,"one"},
				{2,"two"},
				{3,"three"},
			};

			return;
		}
	}
}
