using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsterFootballApp.Model
{
    public class Match
    {
        [Key]
        public long Id { get; set; }

        public Competition Competition { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public Score Score { get; set; }

    }
}
