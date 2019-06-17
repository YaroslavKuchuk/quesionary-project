using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectMVC.Areas.Admin.Models.Test
{
    public class TestPassingVm
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string  StudentName { get; set; }
        public string LectorName { get; set; }
        public string TestName { get; set; }
    }
}