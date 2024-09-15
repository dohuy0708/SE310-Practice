using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace BLL
{
   public class AnimalsBLL
    {
        private AnimalsBLL() { }
        private static AnimalsBLL instance;
        public static AnimalsBLL Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new AnimalsBLL();
                }
                return instance;
            }

        }
        public int CountMilkCow()
        {
           int count = AnimalsAccess.Instance.CountMilkCow();
            return count;
        }
        public int CountMilkSheep()
        {
            int count = AnimalsAccess.Instance.CountMilkGoat();
            return count;
        }
        public int CountMilkGoat()
        {
            int count = AnimalsAccess.Instance.CountMilkSheep();
            return count;
        }
    }
}
