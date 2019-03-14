using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass7
{
	class SalesPerson : Employee
	{
		private double SuccessSaleRevenue { get; set; }
		

		public double AddSuccessRevenue(double num)
		{
			return this.SuccessSaleRevenue = num;
		}


	}
}
