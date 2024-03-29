using System;
using System.Collections.Generic;
using System.Data;
using Banco.Models;

namespace Banco.Queries
{
    public static class UserQuery
    {
        public static List<User> registeredUsers()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM customer");
            List<User> allUsers = new List<User>();

            foreach (DataRow n in dt.Rows)
            {
                User u = new User();

                u.id_user = n[0].ToString();
                u.name = n[1].ToString();
                u.username = n[2].ToString();
                u.email = n[3].ToString();
                u.password = n[4].ToString();

                allUsers.Add(u);
            }


            return allUsers;
        }

        public static void registerUser(User newUser)
        {
            Connection.ExecuteNonQuery($"INSERT INTO customers(customer_id, customer_fullname, customer_username, customer_email, customer_phone, customer_password) " +
                                        $"VALUES('{newUser.id_user}'," +
                                        $" '{newUser.name}'," +
                                        $"'{newUser.username}'," +
                                        $"'{newUser.email}'," +
                                        $"'{newUser.phone}'," +
                                        $"'{newUser.password}')");
        }
    }
}