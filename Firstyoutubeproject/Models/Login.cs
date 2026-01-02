using Microsoft.AspNetCore.Mvc;

namespace Firstyoutubeproject.Models
{
    public class Login 
    {
        public string username { get; set; }
        public string password { get; set; }

        public Login(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
