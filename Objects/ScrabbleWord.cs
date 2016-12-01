using System.Collections.Generic;

namespace Scrabble.Objects
{
	public class ScrabbleWord
	{
		private static Dictionary <string, int> _WordValues = new Dictionary <string, int>()
		{
			[" "]=0, [","]=0, ["."]=0, ["-"]=0, ["\""]=0, ["'"]=0,
			["1"]=0, ["2"]=0, ["3"]=0, ["4"]=0, ["5"]=0, ["6"]=0, ["7"]=0, ["8"]=0, ["9"]=0, ["0"]=0,
			["A"]=1, ["E"]=1, ["I"]=1, ["O"]=1, ["U"]=1, ["L"]=1, ["N"]=1, ["R"]=1, ["S"]=1, ["T"]=1,
			["D"]=2, ["G"]=2,
			["B"]=3, ["C"]=3, ["M"]=3, ["P"]=3,
			["F"]=4, ["H"]=4, ["V"]=4, ["W"]=4, ["Y"]=4,
			["K"]=5,
			["J"]=8, ["X"]=8,
			["Q"]=10, ["Z"]=10,
		};

		public static int GetWordValue(string word)
		{
			int counter = 0;

			foreach(char Letter in word.ToUpper())
			{
				counter += _WordValues[Letter.ToString()];
			}
			return counter;
		}
	}
}
