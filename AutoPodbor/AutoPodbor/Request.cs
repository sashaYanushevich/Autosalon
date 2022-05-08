using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;


namespace AutoPodbor
{
    internal class Request
    {
        private int id;
        private int id_account;
        private int id_car;
        private string login;
        private string message;
        private bool status;
        private string adminAnswer;
        private string date;
        private string listViewText;

        public Request(int id, int id_account, int id_car,string login,string message, bool status, string adminAnswer,string date,string listViewText)
        {
            this.id = id;
            this.id_account = id_account;
            this.id_car = id_car;
            this.login = login;
            this.message = message;
            this.status = status;
            this.adminAnswer = adminAnswer;
            this.date = date;
            this.listViewText = listViewText;
        }
        public int Id { get => this.id; }
        public int Id_account { get => this.id_account; }
        public int Id_car { get => this.id_car; }
        public string Login { get => this.login; }
        public string Message { get => this.message;}
        public bool Status { get => this.status;}
        public string AdminAnswer { get => this.adminAnswer;}
        public string ListViewText { get => this.listViewText;}
        public static List<Request> ReadRequests()
        {
            List<Request> requests = new List<Request>();
            string connStr = "server=194.87.210.23;user=Sasha2;database=autoPodbor;password=Qazx1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM requests";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(new Request(
                    Convert.ToInt32(reader[0].ToString()),
                    Convert.ToInt32(reader[1].ToString()),
                    Convert.ToInt32(reader[2].ToString()),
                    reader[3].ToString(), 
                    reader[4].ToString(),
                    Convert.ToBoolean(reader[5].ToString()),
                    reader[6].ToString(),
                    reader[7].ToString(),
                    $"{reader[3].ToString()} - {reader[7].ToString()}"
                ));
            }
            reader.Close();
            conn.Close();
            return requests;
        }
    }
}
