using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Sheep: Animals
    {
        public Sheep() {
            Name="Sheep";
        }
        public override string GetSound()
        {
            return "Meeeeeeee";
        }
        public override int GetMilk()
        {
            Random random = new Random();
            Milk = random.Next(1, 6);
            return  Milk;
        }
        public override int GetChild()
        {
            Random random = new Random();
            Child = random.Next(1, 4);
            return Child;
        }
    }
}
