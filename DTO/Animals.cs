using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Animals
    {
        public Animals() { }
       
        public string Name { get; set; }    
          public int Num { get; set; }
        public int Milk { get; set; }
        public int Child { get; set; }
      
        public virtual string GetSound ()
        {
            return "";
        }
        public virtual int GetMilk()
        {
            return 0; 
        }
        public virtual int GetChild()
        {
            return 0;
        }
    }
}
