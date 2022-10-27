using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitancework
{
    public class kopek : Zoo
    {
        public bool kuyruk_kesikmi 
        {
            get
            {
                return true;
            }
            set
            {
                if (value == false)
                {
                    Console.WriteLine("kuyruk kesik değil");
                }
                else
                {
                    Console.WriteLine("kuyruk kesik");
                }
            }


        }



    }
}
