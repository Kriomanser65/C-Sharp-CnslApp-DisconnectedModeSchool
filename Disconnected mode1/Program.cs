using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace Disconnected_mode1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectString = "Data Source=DESKTOP-4SK39GD;Initial Catalog=ITacademy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connect = new SqlConnection(connectString)) 
            {
                connect.Open();
                ShowDataInGrid(connect, "select * from Students");
            }
        }
        static void ShowDataInGrid(SqlConnection connect, string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
        }
    }
}
//create table Students
//(
//Id int primary key identity(1,1),
//Name nvarchar(50) not null
//);
//go
//create table Teachers
//(
//Id int primary key identity(1,1),
//Name nvarchar(50) not null
//);
//go
//create table Audience
//(
//Id int primary key identity(1,1),
//Name nvarchar(50) not null
//);
//go
//create table K
//(
//Id int primary key identity(1,1),
//Name nvarchar(50) not null
//);