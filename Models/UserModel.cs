using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REZIDE_API.Models
{
    public class UserModel
    {
        //[Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}