using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_standardization
{
    internal class CheckText
    {
		private String removeSpace(String str)
		{
			Stack<char> charStack = new Stack<char>();
			StringBuilder strBuilder = new StringBuilder(str);
			int shiftIndex = 0;



			for (int i = 0; i < str.Length; i++)
			{
				if (charStack.Count <= 0)
				{
					if (str[i] == ' ' || str[i] == '(' || str[i] == ')' )
						charStack.Push(str[i]);
				}
				else
				{
					//Delete character if have two space
					if (str[i] == charStack.Peek())
					{
						strBuilder.Remove(i - shiftIndex, 1);
						shiftIndex++;
					}


					else if (str[i] == ' ' && charStack.Peek() == '(')
					{
						strBuilder.Remove(i - shiftIndex, 1);
						shiftIndex++;
					}


					//Delete character if before ',' or '.' or ':' or ')' is space
					else if (charStack.Peek() == ' ' && (str[i] == ',') || (str[i] == '.') || (str[i] == ':' || str[i] == ')'))
					{
						strBuilder.Remove(i - shiftIndex - 1, 1);
						shiftIndex++;

					}

					else charStack.Pop();
				}

			}

			
			return strBuilder.ToString();
		}


		private String addMissingSpace(String str)
		{
			Stack<char> charStack = new Stack<char>();
			String newString = removeSpace(str);

			StringBuilder strBuilder = new StringBuilder(newString);

			int numOfChar = 0;

			for (int i = 0; i < newString.Length; i++)
			{
				if (charStack.Count <= 0)
				{
					if (newString[i] == ',' || newString[i] == '.' || newString[i] == ':' || newString[i] == ')')
					{
						charStack.Push(newString[i]);
					}
				}
				else
				{
					//Add new space after ',' '.' ':' ')'
					if ((charStack.Peek() == ',' || charStack.Peek() == '.' || charStack.Peek() == ':' || charStack.Peek() == ')') &&
						newString[i] != ' ' && !isNumber(newString[i]))
					{
						strBuilder.Insert(i - numOfChar, ' ');
						numOfChar--;
						charStack.Pop();
					}
					else charStack.Pop();
				}
			}
			return strBuilder.ToString();
		}


		private String finalCheck(String str)
		{
			String newString = addMissingSpace(str);
			StringBuilder strBuilder = new StringBuilder(newString);
	
			

			for (int i = 0; i < newString.Length - 1; i++)
			{
				if (newString[i] == '.' && !isNumber(newString[i + 1]) && newString[i + 1] != '\n')
				{

					strBuilder[i + 2] = Char.ToUpper(strBuilder[i + 2]);

				}
			}
		
			strBuilder[0] = Char.ToUpper(strBuilder[0]);
			strBuilder.Insert(0, '\t');

			if (strBuilder[strBuilder.Length - 1] != '.')
			{
				strBuilder.Insert(strBuilder.Length, '.');
			}



			return strBuilder.ToString();
		}

		private Boolean isNumber(char c)
		{
			return (c >= 48 && c <= 57) ? true : false;
		}



		public String checkString(string str)
		{
			String finalString = finalCheck(str);
			return finalString;
		}

	}
}
