using System;

namespace Banco.Models
{
    public class User
    {
        public string id_user { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }

        /*internal void Show()
        {
            throw new NotImplementedException();
        }*/
    }
}