using System;
using System.Collections.Generic;

namespace DbFirstApproch.Models
{
    public partial class StudentsTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Age { get; set; }
        public int nage { get; set; }
    }
}
