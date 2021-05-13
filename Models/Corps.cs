using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class Corps
    {
        public Corps()
        {
            Autos = new HashSet<Auto>();
        }

        public string Mark { get; set; }
        public string Location { get; set; }
        public string President { get; set; }
        public string Production { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
