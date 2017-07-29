﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> words = Console.ReadLine().Split().ToList();

			// because Count decrements after every removal, i += 2 becomes i++.
			for (int i = 0; i < words.Count; i++)
			{
				words.RemoveAt(i);
			}

			Console.WriteLine(string.Join("", words));
		}
	}
}
