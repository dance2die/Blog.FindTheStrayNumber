using System;
using System.Linq;
using static System.Console;


namespace FindTheStrayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] a1 = { 1, 1, 2 };
			int[] a2 = { 17, 17, 3, 17, 17, 17, 17 };

			var n1 = a1.Aggregate((a, b) => a ^ b);
			var n2 = a2.Aggregate((a, b) => a ^ b);

			n1 = GetStrayNumber(a1);
			n2 = GetStrayNumber(a2);
			

			WriteLine($"n1 => {n1}, n2 => {n2}");
        }

		private static int GetStrayNumber(int[] arr)
		{
			Func<int, string> format = n => $"{n} ({Convert.ToString(n, 2).PadLeft(5, '0')})";

			var xor = arr[0];
			for (int i = 0; i < arr.Length - 1; i++)
			{
				var a = xor;
				var b = arr[i + 1];
				xor = a ^ b;

				WriteLine($"{format(a)} ^ {format(b)} = {format(xor)}");
			}
			WriteLine(new string('=', 80));

			return xor;
		}
	}
}
