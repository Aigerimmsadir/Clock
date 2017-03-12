using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

          Thread t1 = new Thread(new ThreadStart(numbers.Color));
   
         t1.Start();
     
            
               
            
           
        }
    }
}
