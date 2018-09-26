using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTFToTextConverter;
using System.Windows.Forms;

namespace RTFTestTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleRtf = @"{\rtf1\ansi\deff0
	        {\colortbl;\red0\green0\blue0;\red255\green0\blue0; }
	        This line is the default color\line
		        \cf2
		        This line is red\line
		        \cf1
		        This line is the default color
        }";

            string str = RTFToText.converting().rtfFromString(exampleRtf);
            Console.WriteLine(str);
            Console.ReadLine();


            string str1 = RTFToText.converting().rtfFromFile(@"C:\Custom Library\test.rtf");
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
