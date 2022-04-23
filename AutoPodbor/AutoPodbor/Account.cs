using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using MySqlConnector;


namespace AutoPodbor
{
    internal class Account
    {
        public static bool Registration(string login,string pass,string passConf)
        {
            List<string> logins = new List<string>();
            string connStr = "server=194.87.210.23;user=Sasha2;database=autoPodbor;password=Qazx1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT login FROM accounts";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                logins.Add(reader[0].ToString());
            }
            conn.Close();
            if (pass != passConf || login.Length <5 || pass.Length<7 || logins.Contains(login))
            {
                return false;
            }
            else 
            {
                conn.Open();
                string sql2 = $"INSERT INTO accounts VALUES('0','{login}','{GetHash(pass)}','0')";
                MySqlCommand command2 = new MySqlCommand(sql2, conn);
                command2.ExecuteNonQuery();
                conn.Close();
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                File.WriteAllText(Path.Combine(folderPath, "testCache"), "test123");
                return true;
            }
        }
        private static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
