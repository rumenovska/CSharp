using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private string _Password { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }

        public User(string id,string userName,string address, Role role)
        {
            Id = id;
            UserName = userName;
            Address = address;
            Role = role;

        }

        public void SetPasswordValidate (string password)
        {
            if(password.Length >= 8)
            {
                _Password = password;
            } 

        }
        
        public bool CheckPassword(string password)
        {
            if(_Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
