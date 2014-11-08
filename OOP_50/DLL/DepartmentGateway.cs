using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_50.Class;
using System.Data.SqlClient;
using Database;

namespace OOP_50.Gateway
{
    class DepartmentGateway
    {
        private SqlConnection aConnection;
        public DepartmentGateway()
        {
            aConnection = new SqlConnection(new Connection().ConnectionString);
        }
        public bool Insert(Department aDepartment)
        {
            try
            {
                aConnection.Open();
                string query = String.Format(@"insert into Department values('{0}','{1}')", aDepartment.Name,
                    aDepartment.Code);
                SqlCommand aCommand = new SqlCommand(query, aConnection);
                int total = 0;
                total = aCommand.ExecuteNonQuery();
                aConnection.Close();

                if (total > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Department> GetAll()
        {
            List<Department> listDepartment = new List<Department>();

            try
            {
                aConnection.Open();
                string query = String.Format(@"select * from department");
                SqlCommand aCommand = new SqlCommand(query, aConnection);
                SqlDataReader aReader = aCommand.ExecuteReader();
                if (aReader.HasRows)
                {
                    while (aReader.Read())
                    {
                        Department oneDepartment = new Department();
                        oneDepartment.ID = decimal.Parse(aReader[0].ToString());
                        oneDepartment.Name = aReader[1].ToString();
                        oneDepartment.Code = aReader[2].ToString();
                        listDepartment.Add(oneDepartment);
                    }
                }
                aConnection.Close();
                return listDepartment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


    }
}
