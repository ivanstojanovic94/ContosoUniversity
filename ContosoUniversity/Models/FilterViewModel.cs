using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class FilterViewModel
    {
        public List<Student> Students { get; set; }

        public string Message { get; set; }
    }
}