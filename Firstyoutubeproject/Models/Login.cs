using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Firstyoutubeproject.Models
{
    public class Login 
    {
        [DisplayName("Enter Name")]
        public string username { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }

      
    }
}
