using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal AverageGrade { get; set; }

        public string? StudentImage { get; set; }

        public Group? Group { get; set; }
        public int GroupId {  get; set; }
    }
}
