using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
	/* Random Variable Class. */
	public class aRandomVariable
	{
		int value;
		private static Random random = new Random();

		/* Defult Constructor. */
		public aRandomVariable()
        {
			value = random.Next(1,7);
		}
		/* Specific Constructor. */
		public aRandomVariable(int minValue, int maxValue)
		{
			value = getRand(minValue, maxValue);
		}

		/* Defined Function to get die value for Specific Constructor. */
		int getRand(int minValue, int MaxValue)
        {
			value = random.Next(minValue, MaxValue);
			return value;
        }

		/* Required Conversion Operator. */
		public static implicit operator int(aRandomVariable r) => r.value;
	}

	/* Die class that inherits from aRandomVariable class. */
	public class aDie : aRandomVariable
	{
		/* Defult Constructor. */
		public aDie() 
		{
			aRandomVariable r = new aRandomVariable(1,7);
		}
	}

}
