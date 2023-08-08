using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace vidhya
{

    public class info
    {
        public int Rollnum;
        public string name;
        public string lname;
    }

    public class Registrationrepository
    {
        public readonly string connectionString;

        public info addata()
        {
            info obj111 = new info();

            Console.WriteLine("Enetr Rollnumbe");
            obj111.Rollnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr Firstname");
            obj111.name = Console.ReadLine();
            Console.WriteLine("Enetr Lastname");
            obj111.lname = Console.ReadLine();


            return obj111;
        }
        public Registrationrepository()
        {
            connectionString = @"Data source=ANIYAAN-1006;Initial catalog=Employee details;User Id=sa;Password=Anaiyaan@123";
        }
        public void Insert(info a)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();

                con.Execute($"insert into Employeedetails(emplid,firstname,lastname) values ('{a.Rollnum}','{a.name}','{a.lname}')");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

