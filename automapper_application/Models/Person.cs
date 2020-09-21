using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace automapper_application.Models
{
	public class Person
	{
		public int ssn { get; set; }
		public string PersonName { get; set; }

		public string PersonMiddlename { get; set; }

		public string matialStatus { get; set; }


		public Person()
		{
			ssn = 123456;
			PersonName = "Ramji Rengaramanujam";
			PersonMiddlename = "Renga";
			matialStatus = "Married";
		}
	}
}
