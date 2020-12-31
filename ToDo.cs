using System;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace Lesson5
{
    public class ToDo
    {
        //
        public ToDo() { }
        public string Title { get; set; }
        public bool isDone { get; set; }
        public void duty( string str, bool done)
        {
          Title = str ;
          isDone = done;
        }


    }
}
