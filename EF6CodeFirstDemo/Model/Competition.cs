using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsterFootballApp.Model
{
    public class Competition
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } = null;
        public DateTime LastUpDateTime { get; set; }
        public virtual Season CurrentSeason { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
    }
}
