using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{
    public interface InterfaceDemo
    {
       void animalSound(); 
        }
        class Pig : InterfaceDemo
        {
            public void animalSound()
            {
                
                Console.WriteLine("The pig says: wee wee");
            }
        }

     
}
