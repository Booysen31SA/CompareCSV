using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_compare.line
{
    class LineShow
    {
        public String CompareLine(String text1, String text2)
        {
            String combineText = "";

            using (StreamReader f1 = new StreamReader(text1))
            using (StreamReader f2 = new StreamReader(text2))
            {

                int lineNumber = 0;

                while (!f1.EndOfStream)
                {
                    if (f2.EndOfStream)
                    {
                        break;
                    }

                    lineNumber++;
                    var line1 = f1.ReadLine();
                    var line2 = f2.ReadLine();

                    if (line1 != line2)
                    {
                        combineText += string.Format("Line {0}\r\n==========================\r\n", lineNumber);
                    }
                    else
                    {
                        combineText += string.Format("No differences Found on Line {0}\r\n==========================\r\n", lineNumber);
                    }
                }//End of While


                if (!f2.EndOfStream)
                {
                }
            }
            return combineText;
        }//End of Method
    }
}
