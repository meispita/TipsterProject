using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsterFootballApp.Model
{
    public class Stading
    {
        [Key]
        public long Id { get; set; }
        public Season season { get; set; }

        public Table Total { get; set; }

        public Table Home { get; set; }

        public Table Away { get; set; }
    }
}
