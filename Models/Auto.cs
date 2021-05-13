using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class Auto
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string BodyType { get; set; }

        public virtual Corps MarkNavigation { get; set; }
    }
}
