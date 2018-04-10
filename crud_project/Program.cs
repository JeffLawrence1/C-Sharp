using System;
using System.Collections.Generic;
using DbConnection;

namespace crud_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        // Reader();
        Create("TDawg", "TTTTt", 17);
        Create("TDsdfasfsawg", "TTghhhhhhhhhTTt", 33);
        Create("TDasdfsdwg", "TggggggggggTTTt", 18);
        Update(2, "hhhh", "lkjlkjklj", 84);
        Update(3, "hgggggghhh", "lkjlmmmmmmmmkjklj", 184);
        Update(4, "hkkkkkkhhh", "lkjlvvvvvvvvvvvvvkjklj", 44);
        Delete(3);
        Delete(4);
        }
        static void Reader(){
            List<Dictionary<string, object>> all = DbConnector.Query("SELECT * FROM users");
            foreach(Dictionary<string, object> dict in all){
                Console.WriteLine("Entry: ");
                foreach(KeyValuePair<string, object> keyVal in dict) {
                    Console.WriteLine(keyVal.Key + "=" + keyVal.Value + ", ");
                }
                Console.WriteLine();
            }
        }
        static void Create(string firstName, string lastName, int favoriteNum) {
            string query = $"INSERT INTO users (FirstName, LastName, FavoriteNumber) VALUES ('{firstName}', '{lastName}', '{favoriteNum}')";
            Console.WriteLine("Adding user...");
            DbConnector.Execute(query);
            Reader();
        }
        static void Update(int id, string firstName, string lastName, int favoriteNum) {
            string query = $"UPDATE users SET FirstName='{firstName}', LastName='{lastName}', FavoriteNumber='{favoriteNum}' WHERE id={id}";
            Console.WriteLine("Updating user...");
            DbConnector.Execute(query);
            Reader();
        }
        static void Delete(int id) {
            string query = $"DELETE FROM users WHERE id={id}";
            Console.WriteLine("Deleting user...");
            DbConnector.Execute(query);
            Reader();
        }
    }
}
