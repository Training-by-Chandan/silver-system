using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Db.Models
{
    [Table("UserInformation")]
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}