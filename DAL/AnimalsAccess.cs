using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
   public class AnimalsAccess 
    {
        private AnimalsAccess() { }
        private static AnimalsAccess instance;
       public static AnimalsAccess Instance
        {

            get {
                if ( instance == null)
                {
                    instance = new AnimalsAccess();
                }
                return instance; }
             
        }
        public int CountMilkCow()
        {
            string query = "SELECT Milk FROM Animals WHERE Name = 'Cow'";

            int MilkCow =SQLConnectionData.Instance.ExecuteQuery(query);
            return MilkCow;
        }

        public int CountMilkSheep()
        {
            string query = "SELECT Num FROM Animals WHERE Name = 'Sheep'";

            int MilkCow = SQLConnectionData.Instance.ExecuteQuery(query);
            return MilkCow;
        }

        public int CountMilkGoat()
        {
            string query = "SELECT Num FROM Animals WHERE Name = 'Goat'";

            int MilkCow = SQLConnectionData.Instance.ExecuteQuery(query);
            return MilkCow;
        }

    }
}
