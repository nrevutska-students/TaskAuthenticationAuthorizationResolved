using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAuthenticationAuthorization.Models
{
    public enum BuyerType { None, Regular, Golden, Wholesale }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public BuyerType BuyerType { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public Customer Customer { get; set; }
    }
}
