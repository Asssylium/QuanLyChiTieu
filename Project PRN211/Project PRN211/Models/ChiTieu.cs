using System;
using System.Collections.Generic;

namespace Project_PRN211.Models
{
    public partial class ChiTieu
    {
        public int Id { get; set; }
        public int? Userid { get; set; }
        public string Chude { get; set; } = null!;
        public decimal Money { get; set; }
        public DateTime Datetime { get; set; }
        public string Noidung { get; set; } = null!;
        public string group_name { get; set; } = null!;
        public virtual Account? User { get; set; }
    }
}
