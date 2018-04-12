using System;
using System.Data.SqlClient;
using System.Data;
namespace GenericSQL
{
    internal class SQLCommands
    {
        public void updateDatabase(string tablename)
        {
            string query = string.Empty;
            string temp = string.Empty;
            int temp1 = 0;
            try
            {
                SqlConnection Connection = new SqlConnection("data source=GGKU4MPC71;database=Student;integrated security=SSPI");
                Connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from " + tablename, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, tablename);
                Console.WriteLine("Enter column number to modify");
                for (int j = 0; j < dataSet.Tables[tablename].Columns.Count; j++)
                {
                    Console.WriteLine(j + " " + dataSet.Tables[tablename].Columns[j].ColumnName);
                }
                temp1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the update field " + dataSet.Tables[tablename].Columns[temp1].ColumnName + " to select row");
                temp = Console.ReadLine();
                Console.WriteLine("Enter updating value");
                if (dataSet.Tables[tablename].Columns[temp1].DataType == typeof(string) || dataSet.Tables[tablename].Columns[temp1].DataType == typeof(DateTime))
                {
                    query = "update " + tablename + " set " + dataSet.Tables[tablename].Columns[temp1].ColumnName + " = '" + Console.ReadLine() + "' where " + dataSet.Tables[tablename].Columns[temp1].ColumnName + " = " + "'" + temp + "'";
                }
                else
                {
                    query = "update " + tablename + " set " + dataSet.Tables[tablename].Columns[temp1].ColumnName + " = " + Console.ReadLine() + " where " + dataSet.Tables[tablename].Columns[temp1].ColumnName + " = " + temp;
                }
                SqlCommand command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Updated");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("not updated");
                Console.WriteLine(e.Message);
            }
        }
        public void DeleteFromDatabase(string tablename)
        {
            string query = string.Empty;
            int temp1 = 0;
            try
            {
                SqlConnection Connection = new SqlConnection("data source=GGKU4MPC71;database=Student;integrated security=SSPI");
                Connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from " + tablename, Connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, tablename);

                Console.WriteLine("Enter column number to delete");
                for (int j = 0; j < dataSet.Tables[tablename].Columns.Count; j++)
                {
                    Console.WriteLine(j + " " + dataSet.Tables[tablename].Columns[j].ColumnName);
                }
                temp1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Field value for deleting");
                if (dataSet.Tables[tablename].Columns[temp1].DataType == typeof(string) || dataSet.Tables[tablename].Columns[temp1].DataType == typeof(DateTime))
                {
                    query = "Delete from " + tablename + " where " + dataSet.Tables[tablename].Columns[temp1] + " = '" + Console.ReadLine() + "'";
                }
                else
                {
                    query = "Delete from " + tablename + " where " + dataSet.Tables[tablename].Columns[temp1] + " = " + Console.ReadLine();
                }
                SqlCommand command = new SqlCommand(query, Connection);
                command.ExecuteNonQuery();
                Connection.Close();
                Console.WriteLine("Deleted");
            }
            catch (Exception e)
            {
                Console.WriteLine("not deleted");
                Console.WriteLine(e.Message);
            }
        }
        public void select(string tablename)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=GGKU4MPC71;database=Student;integrated security=SSPI");
                SqlDataAdapter da1 = new SqlDataAdapter("select * from " + tablename, con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataTable dt1 = new DataTable();
                dt1 = ds1.Tables[0];
                Console.WriteLine("The Details of the table are");
                foreach (DataRow row in dt1.Rows)
                {
                    foreach (DataColumn column in dt1.Columns)
                    {
                        Console.Write("Item: ");
                        Console.Write(column.ColumnName);
                        Console.Write(" ");
                        Console.WriteLine(row[column]);
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void insert(string tablename)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=GGKU4MPC71;database=Student;integrated security=SSPI");
                SqlDataAdapter da1 = new SqlDataAdapter("select * from " + tablename, con);
                SqlCommandBuilder cd = new SqlCommandBuilder(da1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, tablename);
                DataTable dt1 = new DataTable();
                dt1 = ds1.Tables[0];
                DataRow dr = ds1.Tables[tablename].NewRow();
                foreach (DataColumn column in ds1.Tables[tablename].Columns)
                {
                    Console.WriteLine("Enter the field" + " " + column.ColumnName);
                    dr[column.ColumnName] = Console.ReadLine();
                }
                ds1.Tables[0].Rows.Add(dr);
                da1.Update(ds1, tablename);
                Console.WriteLine("Inserted");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}