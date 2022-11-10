using System;
using System.Collections.Generic;

namespace Banco{
    public static class UserQuery {
        public static List<User> registeredUsers(){
            List<User> allUsers = new List<User>();
            allUsers.Add(new User());
            allUsers[0].id_usuario = 1;
            allUsers[0].name = "Dennys";
            allUsers[0].username = "dennys";
            allUsers[0].password = "1234";
            allUsers[0].admin = false;

            return allUsers;
        }
    }
}