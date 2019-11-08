using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginAndReg.Models
{
    public class LoginCredentials
    {
        [Required]
        [EmailAddress]
        public string EmailAddress{get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
    

}