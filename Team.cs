using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPlayers
{
    internal class Team
    {
       
        public int Id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string citta { get; set; }
        [Required]
        public string allenatore { get; set; }
        [Required]
        public string colori { get; set; }
        public List<Player> players { get; set; }
    }
}
