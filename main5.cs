using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fName = "Tasks.json";
            byte y=2;
            do
            {
                createList();
                Console.WriteLine("Ввести еще задачу  [1- Да / 2 - Нет]?");
                y=Convert.ToByte(Console.ReadLine());
            } while (y!=2);

            Console.WriteLine();
            Console.ReadLine();
        }
        static void createList()
        {
            string fName = "Tasks.json";
            Console.WriteLine( "Введите новую задачу:");
            ToDo Task = new ToDo();
            string json = Console.ReadLine();
            bool done = pass(json);
            if (done) json = "[X]" + json;
            Task.duty(json, done);
            json = JsonSerializer.Serialize(Task);
            File.AppendAllText(fName, Environment.NewLine);
            File.AppendAllText(fName, json);
        }
        static bool pass( string str)
        {
            bool answer;
            byte y;
            do
            {
                Console.WriteLine("Эта задача [" + str + "] уже выполнена? [1- Да / 2 - Нет]");
                y = Convert.ToByte(Console.ReadLine());
            } while (y > 2 || y < 1);
            //
            if (y ==1) answer = true;
            else answer = false;
            return answer;
        }
    }
}
