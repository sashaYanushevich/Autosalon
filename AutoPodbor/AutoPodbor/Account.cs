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
        private static string connStr = "server=194.87.210.23;user=Sasha2;database=autoPodbor;password=Qazx1234;";
        public static bool Registration(string login,string pass,string passConf)
        {
            List<string> logins = new List<string>();
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
            if (pass != passConf || login.Length <=5 || pass.Length<7 || logins.Contains(login) || login.Contains("-"))
            {
                return false;
            }
            else 
            {
                conn.Open();
                string sql2 = $"INSERT INTO accounts VALUES('0','{login}','{GetHash(pass)}','{login}','0')";
                MySqlCommand command2 = new MySqlCommand(sql2, conn);
                command2.ExecuteNonQuery();
                conn.Close();
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                File.WriteAllText(Path.Combine(folderPath, "accountInfo"), login);
                return true;
            }
        }
        public static bool Authorization(string login, string pass)
        {
            string passSql = string.Empty;
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = $"SELECT * FROM accounts WHERE login ='{login}'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                passSql = reader[2].ToString();
            }
            if (GetHash(pass) == passSql) { 
                
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                File.WriteAllText(Path.Combine(folderPath, "accountInfo"), login);
                return true;
            }
            else
                return false;


        }
        private static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}
