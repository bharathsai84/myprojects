using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace GenericSQL
{
    internal class Execute
    {
        public void Run()
        {
            Console.WriteLine("1.Insert\n2.Select\n3.Update\n4.Delete\n5.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            SQLCommands sobj = new SQLCommands();
            switch (option)
            {
                case 1:
                    {
                        intialize();
                        Console.WriteLine("Enter the table name to Insert");
                        string tablename = Console.ReadLine();
                        sobj.insert(tablename);
                        break;
                    }
                case 2:
                    {
                        intialize();
                        Console.WriteLine("Enter the table name to Select");
                        string tablename = Console.ReadLine();
                        sobj.select(tablename);
                        break;
                    }
                case 3:
                    {
                        intialize();
                        Console.WriteLine("Enter the table name to update");
                        string tablename = Console.ReadLine();
                        sobj.updateDatabase(tablename);
                        break;
                    }
                case 4:
                    {
                        intialize();
                        Console.WriteLine("Enter the table name to Delete");
                        string tablename = Console.ReadLine();
                        sobj.DeleteFromDatabase(tablename);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong Option!!!!");
                        break;
                    }
            }
        }
        public void intialize()
        {
            SqlConnection con = new SqlConnection("data source=GGKU4MPC71;database=Student;integrated security=SSPI");
            SqlDataAdapter da = new SqlDataAdapter("select * from sys.tables", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int temp = ds.Tables.Count;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            List<string> list1 = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string cellData = row["name"].ToString();
                list1.Add(cellData);
            }
            Console.WriteLine("The tables present int the DataBase are");
            foreach (string str in list1)
            {
                Console.WriteLine(str);
            }
        }
    }
}