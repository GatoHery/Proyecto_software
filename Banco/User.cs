using System;

namespace Banco{
    public class User{
        public int id_usuario { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }

        public User(){
            admin = false;
        }
    }
}