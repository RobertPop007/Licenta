using System;
using System.ComponentModel.DataAnnotations;

namespace Proiect_licenta.Entities.TvShows
{
    public class TvShowActorList
    {
        [Key]
        public Guid TvShowActorListId { get; set; } = Guid.NewGuid();
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string AsCharacter { get; set; }
    }
}
