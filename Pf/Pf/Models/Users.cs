using System;
using System.Collections.Generic;

namespace Pf.Models
{
    public partial class Users
    {
        public Users()
        {
            UserLocation = new HashSet<UserLocation>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
				public string UserName { get; set; }
		public virtual ICollection<UserLocation> UserLocation { get; set; }
		
	}
}
