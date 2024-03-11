namespace Encryptor.Vest
{
	public static class Crypt
	{
		static readonly char[] alphabet =
		[
			'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
			'k', 'l', 'm', 'n', 'o','p', 'q', 'r', 's', 't',
			'u', 'v', 'w', 'x', 'y', 'z'
		];

		/// <summary>
		/// Кодирует буквы и транспонирует слова.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Encrypt(string input)
		{
			string result = Encode(input);
			result = Transposition(result);
			return result;
		}

		/// <summary>
		/// Декодирует буквы и детранспонирует слова.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Decrypt(string input) 
		{
			string result = Decode(input);
			result = Detransposition(result);
			return result;
		}

		/// <summary>
		/// Кодирует строку по алгоритму Vest. Возвращает строку в нижнем регистре.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Encode(string input)
		{
			if(input.Equals(string.Empty))
				return string.Empty;

			input = input.ToLower();
			string code = string.Empty;
			foreach(var c in input)
			{
				if (!NotLetter(c))
				{
					code += c;
					continue;
				}
				if (c.Equals('a'))
				{
					code += 'z';
					continue;
				}
				code += alphabet[Array.IndexOf(alphabet, c)-1];
			}
			return code;
		}

		/// <summary>
		/// Декодирует строку по алгоритму Vest. Возвращает строку в нижнем регистре.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Decode(string input)
		{
			if (input.Equals(string.Empty))
				return string.Empty;

			input = input.ToLower();
			string code = string.Empty;
			foreach (var c in input)
			{
				if (!NotLetter(c))
				{
					code += c;
					continue;
				}
				if (c.Equals('z'))
				{
					code += 'a';
					continue;
				}
				code += alphabet[Array.IndexOf(alphabet, c) + 1];
			}
			return code;
		}

		/// <summary>
		/// Делает транспозицию слов в строке с ключом 2-3-1-4
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Transposition(string input) 
		{
			var words = input.Split();
			string[][] wordsArray;
			int countArray = words.Length%4!=0 ? words.Length/4+1 : words.Length/4;
			wordsArray = new string[countArray][];
			int countWord = 0;
			for (int i = 0; i < wordsArray.Length; i++)
			{
				int j = 0;
				wordsArray[i] = ["", "", "", ""];
				while (words.Length > countWord && j < 4)
				{
					wordsArray[i][j] = words[countWord];
					countWord++;
					j++;
				}
			}
			var resultsArray = new string[countArray][];
			for (int i = 0; i < wordsArray.Length; i++)
			{
				resultsArray[i] = new string[4] { "","","",""};
				resultsArray[i][0] = wordsArray[i][1];
				resultsArray[i][1] = wordsArray[i][2];
				resultsArray[i][2] = wordsArray[i][0];
				resultsArray[i][3] = wordsArray[i][3];
			}
			string result = string.Empty;
			foreach(var word in resultsArray)
			{
				foreach(var w in word)
				{
					if (w.Equals(""))
						continue;
					result += w;
					result += " ";
				}
			}
			result = result.Remove(result.Length-1);
			return result;
		}

		/// <summary>
		/// Делает транспозицию слов в строке с ключом 3-1-2-4
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string Detransposition(string input)
		{
			var words = input.Split();
			string[][] wordsArray;
			int countArray = words.Length % 4 != 0 ? words.Length / 4 + 1 : words.Length / 4;
			wordsArray = new string[countArray][];
			int countWord = 0;
			for (int i = 0; i < wordsArray.Length; i++)
			{
				int j = 0;
				wordsArray[i] = ["", "", "", ""];
				while (words.Length > countWord && j < 4)
				{
					wordsArray[i][j] = words[countWord];
					countWord++;
					j++;
				}
			}
			var resultsArray = new string[countArray][];
			for (int i = 0; i < wordsArray.Length; i++)
			{
				int countEmpty = 0;
				if (wordsArray[i][0].Equals(""))
					countEmpty++;
				if (wordsArray[i][1].Equals(""))
					countEmpty++;
				if (wordsArray[i][2].Equals(""))
					countEmpty++;
				if (wordsArray[i][3].Equals(""))
					countEmpty++;
				if (countEmpty == 2)
				{
					resultsArray[i] = new string[4] { "", "", "", "" };
					resultsArray[i][0] = wordsArray[i][1];
					resultsArray[i][1] = wordsArray[i][0];
				}
				else
				{
					resultsArray[i] = new string[4] { "", "", "", "" };
					resultsArray[i][0] = wordsArray[i][2];
					resultsArray[i][1] = wordsArray[i][0];
					resultsArray[i][2] = wordsArray[i][1];
					resultsArray[i][3] = wordsArray[i][3];
				}
			}
			string result = string.Empty;
			foreach (var word in resultsArray)
			{
				foreach (var w in word)
				{
					if (w.Equals(""))
						continue;
					result += w;
					result += " ";
				}
			}
			result = result.Remove(result.Length - 1);
			return result;
		}

		/// <summary>
		/// Проверяет символ на то, является ли он буквой
		/// </summary>
		/// <param name="symbol"></param>
		/// <returns></returns>
		private static bool NotLetter(char symbol)
		{
			return Array.Exists(alphabet, elem => elem == symbol);
		}
	}
}
