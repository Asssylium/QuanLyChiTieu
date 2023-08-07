using System;
using System.Collections.Generic;

namespace Project_PRN211.Models
{
    public partial class Account
    {
        public Account()
        {
            ChiTieus = new HashSet<ChiTieu>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Gender { get; set; } = null!; 
        public string Email { get; set; } = null!;

        public virtual ICollection<ChiTieu> ChiTieus { get; set; }
    }
}
