using System.ComponentModel.DataAnnotations;

namespace TipsterFootballApp.Model
{
    public class Score
    {
        [Key]
        public long Id { get; set; }
        public int HomeTeam { get; set; }
        public int AwayTeam { get; set; }

    }
}