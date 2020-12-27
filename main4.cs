using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DIRtree
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileTree = "DIRtree.txt";
            Console.WriteLine("Введите папку на компьютере для сканирования:");
            string workDir = Console.ReadLine();
            if (Directory.Exists(workDir))
            { 
            
                string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);
                for (int t = 0; t < entries.Length; t++)
                {
                    File.AppendAllText(fileTree, Environment.NewLine);
                    File.AppendAllText(fileTree,entries[t]);
                }
                // Это вызов рекурсивной функции
                filesTree(workDir);
                Console.WriteLine();
                Console.WriteLine("Результат работы программы - дерево каталогов и файлов в них.");
                Console.WriteLine("В файле DIRtree.txt - обычным способом.");
                Console.WriteLine("В файле DIRtree_Rec.txt - способом рекурсии.");
            }
            else Console.WriteLine("На Вашем компьютере такой папки нет!");
           
           
            Console.ReadLine();
        }
        static void  filesTree(string dir)
        {
            string fileTree = "DIRtree_Rec.txt";
            try
                {
                foreach (string f in Directory.GetFiles(dir))
                {
                    File.AppendAllText(fileTree, Environment.NewLine);
                    File.AppendAllText(fileTree, f);
                }                
                foreach (string d in Directory.GetDirectories(dir))
                    {
                    File.AppendAllText(fileTree, Environment.NewLine);
                    File.AppendAllText(fileTree, d);
                   // Вот она - рекурсия!                  
                        filesTree(d);
                    }

                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
         }
    }

}
