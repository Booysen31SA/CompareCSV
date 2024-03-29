﻿using System;
using System.Collections.Generic;
using System.IO;

namespace CSV_compare.Compare
{
    internal class CompareText
    {
        public string compareText(String text1, String text2)
        {
            String combineText = "";

            using (StreamReader f1 = new StreamReader(text1))
            using (StreamReader f2 = new StreamReader(text2))
            {
                var differences = new List<string>();

                int lineNumber = 0;

                while (!f1.EndOfStream)
                {
                    if (f2.EndOfStream)
                    {
                        differences.Add("Differing number of lines - f2 has less.");
                        break;
                    }

                    lineNumber++;
                    var line1 = f1.ReadLine().Replace(";", "; ");
                    var line2 = f2.ReadLine().Replace(";", "; ");

                    if (line1 != line2)
                    {
                        differences.Add(string.Format("Line {0} differs. \r\nFile 1: {1}, \r\nFile 2: {2}\r\n==============\r\n", lineNumber, line1, line2));
                        combineText += string.Format("Line {0} differs. \r\nFile 1: {1}, \r\nFile 2: {2}\r\n==============\r\n", lineNumber, line1, line2);
                    }
                    else
                    {
                        differences.Add(string.Format("No differences Found on Line {0}\r\n==========================\r\n", lineNumber));
                        combineText += string.Format("No differences Found on Line {0}\r\n===========================\r\n", lineNumber);
                    }
                }//End of While

                if (!f2.EndOfStream)
                {
                    differences.Add("Differing number of lines - f1 has less.");
                }
            }
            return combineText;
        }//End of Method
    }
}