using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Festiv.Models;
using Festive.Models;

namespace Festiv.ViewModels
{
    public class PartyDetailsViewModel
    {
        public Party? Party { get; set; }
        public List<Game>? Games { get; set; } = new List<Game>();
        public string? CurrentTrack { get; set; }
        public string? PlaylistId { get; set; }
        public IEnumerable<MissedConnections> MissedConnections { get; set;}
    }
}