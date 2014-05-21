﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orgchart.Web.Tests
{
    [TestClass]
    public class DatabaseContext_specs
    {
        [TestMethod]
        public void Can_connecto_to_Database()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseContext"].ToString();
            var conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                Assert.IsTrue(conn.State == ConnectionState.Open);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Assert.Fail(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}