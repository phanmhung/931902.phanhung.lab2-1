using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace lab1.Models
{
	public class CalcModel
	{
		public readonly int a;
		public readonly int b;
		public readonly string add;
		public readonly string sub;
		public readonly string mul;
		public readonly string div;
		public CalcModel(int a, int b, string add, string sub, string mul, string div)
		{
			this.a = a;
			this.b = b;
			this.add = add;
			this.sub = sub;
			this.mul = mul;
			this.div = div;
		}
	}
}

