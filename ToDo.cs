using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool isDone { get; set; }
        public void duty( string str, bool done)
        {
          Title = str ;
          isDone = done;
        }


    }
}
