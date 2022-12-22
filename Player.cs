using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPlayers
{
    internal class Player
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string cognome { get; set; }
        [Required]
        public double punteggio { get; set; }
        [Required]
        public int numero_giocate { get; set; }
        [Required]
        public int numero_vinte { get; set; }
        public int teamid { get; set; }
        public Team team { get; set; }
    }
}
