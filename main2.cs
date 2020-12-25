using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace files
{  
    class Program 
	{	
    static void Main(string[] args)
    {    
	string filename = "startup.txt";
    string str1 = DateTime.Now.ToString();
	File.AppendAllText(filename, Environment.NewLine); 
	File.AppendAllText(filename, str1);
	Console.WriteLine(DateTime.Now);
	Console.ReadLine();
  
	}
	}
}
