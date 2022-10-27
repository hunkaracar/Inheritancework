using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inharitancework
{
    public class Zoo
    {
        private string _hayvan_cinsi;
        public string hayvan_isim { get; set; }
        public string hayvan_cinsi 
        { 
            get 
            {
                return _hayvan_cinsi;    
            }
            set 
            {
                _hayvan_cinsi = value;
            } 
        }  
        public string hayvan_rengi { get; set; }    
        public int hayvan_yas { get; set; } 



        public void bilgilerigöst()
        {
            Console.WriteLine("Hayvan isim:" + hayvan_isim);
            Console.WriteLine("Hayvan cinsi:" + hayvan_cinsi);
            Console.WriteLine("Hayvan rengi :" + hayvan_rengi);
            Console.WriteLine("Hayvan yaşi:" + hayvan_yas);
            
        }







    }
}
