﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < num.Length; i++)
			{
				if (num[i] == i)
				{
					Console.Write(i + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
