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
	System.Console.WriteLine("Введите текстовое сообщение:");
	string filename = "readme.txt";
    string str1 = System.Console.ReadLine();

	File.WriteAllText(filename, str1);
	//
	Console.ReadLine();
  
	}
	}
}
