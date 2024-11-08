using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Ects { get; set; }

        public bool IsOptional { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
