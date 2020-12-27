using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TuikProject.Models;

namespace TuikProject.Models
{
    public class IssizlikOrani
    {
        public int Id { get; set; }

        public IEnumerable<IssizlikOraniT1> IssizlikOraniT1 { get; set; }

        public IEnumerable<IssizlikOraniT2> IssizlikOraniT2 { get; set; }

    }
}
