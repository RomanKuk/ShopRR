using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace diagram.Classes
{
    static class CodeGenerator
    {
        public static String GenerateCode(String tabName, String cdStart)
        {
            decimal number;
            using (SqlConnection connection =
                new SqlConnection(Properties.Settings.Default.my_db_for_db_2ConnectionString))
            {
                SqlCommand comand = new SqlCommand("SELECT IDENT_CURRENT('"+tabName+"')", connection);
                connection.Open();
                number = (decimal)comand.ExecuteScalar() + 1;
                connection.Close();
            }
            int zeroCount = 10 - (number).ToString().Length - cdStart.Length;
            String zero = "";
            for (int i = 0; i < zeroCount; i++)
            {
                zero += "0";
            }
            return cdStart + zero + number;
        }
    }
}
