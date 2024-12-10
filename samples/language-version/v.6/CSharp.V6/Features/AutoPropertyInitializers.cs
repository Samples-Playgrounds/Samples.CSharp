using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.V6
{
	public partial class AutoPropertyInitializers
	{
		public string Name { get; set; } = "Moljac";
		public DateTime DateOfBirth { get; set; } = new DateTime(1968, 09, 24);

		// nogo
		//public TimeSpan Age { get; set; } = DateTime.Now - DateOfBirth;
		//public TimeSpan Age { get; set; } = DateTime.Now - this.DateOfBirth;

	}
}
