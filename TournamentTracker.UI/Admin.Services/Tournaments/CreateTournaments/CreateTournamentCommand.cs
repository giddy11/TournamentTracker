using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Services.Tournaments.CreateTournaments
{
    public sealed class CreateTournamentCommand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? TournamentName { get; set; }
        public string? Description { get; set; }
    }
}
