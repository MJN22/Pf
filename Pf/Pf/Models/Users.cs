using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pf.Models
{
    public partial class Users
    {
        public Users()
        {
            UserLocation = new HashSet<UserLocation>();
        }

        public int Id { get; set; }
       // [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        public virtual ICollection<UserLocation> UserLocation { get; set; }
    }
}
