using System;
using System.Globalization;

namespace Course
{
	class Program
	{
		static void Main(string[] args)
		{
			BusinessAcount count = new BusinessAcount(40, "Helo", 800.70, 10000);
            Console.WriteLine(count.Balance);
		}
	}
}