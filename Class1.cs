using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_Collection
{
    class Class1
    {
    }
    interface CarComaprision
    {
        //string name;

        //We can't divide Intnce Field 
       // public void DisplayResults();
        public void Message()
        {
            Console.WriteLine("this Message s coming from INterface ");
        }
    }
    
    
    public  class Car: CarComaprision
    
       // string CardModel { get;  set; }
        string ModelName { get;  set; }

        
    }

}

