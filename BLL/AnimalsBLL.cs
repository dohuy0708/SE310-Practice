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
            int count = AnimalsAccess.Instance.CountMilkSheep();
            return count;
        }
        public int CountMilkGoat()
        {
            int count = AnimalsAccess.Instance.CountMilkGoat();
            return count;
        }
        public int CountChildGoat()
        {
            int count = AnimalsAccess.Instance.CountChildGoat();
            return count;
        }
        public int CountChildCow()
        {
            int count = AnimalsAccess.Instance.CountChildCow();
            return count;
        }
        public int CountChildSheep()
        {
            int count = AnimalsAccess.Instance.CountChildSheep();
            return count;
        }

        public void Delete()
        {
            AnimalsAccess.Instance.Reset();
        }
        public void Insert(int num, int child, int milk, string name)
        {
            AnimalsAccess.Instance.Insert(num, child, milk, name);
        }
    }
}
