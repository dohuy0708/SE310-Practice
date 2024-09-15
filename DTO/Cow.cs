using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Cow : Animals
    {
        public Cow() {
            Name = "Cow";
        }
      
       public override string GetSound()
        {
            return "Umaaaaa";
        }
        public override int GetMilk()
        {
             Random random = new Random();
            Milk = random.Next(1, 21);
            return Milk;
        }
        public override int GetChild()
            { 
            Child=1; return Child;  
        }
    }
}
