using System;
using System.ComponentModel.DataAnnotations;

namespace TipsterFootballApp
{
    public class Season
    {
        [Key]
        public long Id { get; set; }
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int CurrentMatchday { get; set; }
    }
}