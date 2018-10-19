using System.ComponentModel.DataAnnotations;

namespace TipsterFootballApp.Model
{
    public class Team
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Code { get; set; }

    }
}