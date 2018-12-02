using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			var data = new string[] { "Apple", "Banana", "Orange", "Peach", "Pineapple" };

			//straight/direct inheritance chain
			Straight.LessThan25 strLengthCheckerStraight = new Straight.LessThan25();
			//works due to direct inheritance
			Straight.ISomething<string> somethingGenericStraight = strLengthCheckerStraight;
			//works due to direct inheritance
			Straight.ISomething somethingNonGenericStraight = somethingGenericStraight;

			var straightResult = data.All(somethingGenericStraight.CheckSomething);

			//inverted inheritance chain
			Inverted.LessThan25 strLengthCheckerInverted = new Inverted.LessThan25();
			//works due to direct generic inheritance
			Inverted.ISomething<string> somethingGenericInverted = strLengthCheckerInverted;
			
			//fail. I wanted to trick the compiler)) 
			//Inverted.ISomething somethingNonGenericInverted = somethingGenericInverted;

			var invertedResult = data.All(somethingGenericInverted.CheckSomething);

			Console.WriteLine(straightResult == invertedResult);
			Console.ReadLine();
		}
	}
}
