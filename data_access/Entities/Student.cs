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

        [Required(ErrorMessage = "This field is required."), MinLength(3)]
        public string FullName { get; set; }

        [Required, Range(2,5)]
        public decimal AverageGrade { get; set; }

        [Url]
        public string? StudentImage { get; set; }

        public Group? Group { get; set; }
        public int GroupId {  get; set; }
    }
}
