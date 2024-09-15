using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class Goat : Animals
    {
         public Goat() {
            Name = "Goat";
        }
        public override string GetSound()
        {
            return "Deeeeeee";
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk = random.Next(1, 11);
            return Milk;
        }
        public override int GetChild()
        {
            Random random = new Random();
            Child = random.Next(1, 4);
            return Child;
        }
    }
}
