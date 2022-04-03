using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text_standardization
{
    public class ExecutionText
    {
        CheckText checkText = new CheckText();
        public String execution(string strInput)
        {

            String output="";

            String input = strInput.Replace("\t", "");

            String[] listStr = input.Split('\n');

            List<String> strList = new List<string>();

            for (var i = 0; i < listStr.Length; i++)
            {
                strList.Add(listStr[i].Trim());
            }

            for (var i = 0; i < strList.Count; i++)
            {
                if (String.IsNullOrEmpty(strList[i]) == true)
                {
                    strList.RemoveAt(i);
                    i--;
                }
                    
            }

            for (var i=0; i< strList.Count; i++)
            {
                strList[i] = checkText.checkString(strList[i]);
            }

            for (var i = 0; i < strList.Count; i++)
            {
                output += strList[i] + '\n';
            }

            return output;

        }

    }
}
