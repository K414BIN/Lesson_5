using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName = "ByteFile.bin";
            Console.WriteLine(" Введите через пробел целые положительные цифры от 1 до 255. ");
            string text = Console.ReadLine();
            byte[] byteArr = new byte[] { };
            try
            {
                 byteArr = text.Split(' ').Select(x => Convert.ToByte(x)).ToArray();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Введено значение больше 255!");
            }
            finally
            {
                File.WriteAllBytes(fileName, byteArr);
            }
            Console.ReadLine();

        }
    }
}
