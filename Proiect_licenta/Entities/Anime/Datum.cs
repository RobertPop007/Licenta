using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proiect_licenta.Entities.Anime
{
    public class Datum
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Mal_id { get; set; }
        public string Url { get; set; }
        public Images Images { get; set; }
        public Trailer Trailer { get; set; }
        public string Title { get; set; }
        public string Title_english { get; set; }
        public string Title_japanese { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public int? Episodes { get; set; }
        public string Status { get; set; }
        public bool Airing { get; set; }
        public Aired Aired { get; set; }
        public string Duration { get; set; }
        public string Rating { get; set; }
        public double? Score { get; set; }
        public int Scored_by { get; set; }
        public int? Rank { get; set; }
        public int? Popularity { get; set; }
        public int? Members { get; set; }
        public int? Favorites { get; set; }
        public string Synopsis { get; set; }
        public string Background { get; set; }
        public string Season { get; set; }
        public int? Year { get; set; }
        public Broadcast Broadcast { get; set; }
        public IList<Producer> Producers { get; set; }
        public IList<Licensor> Licensors { get; set; }
        public IList<Studio> Studios { get; set; }
        public IList<Genre> Genres { get; set; }
        public IList<Theme> Themes { get; set; }
        public IList<Demographic> Demographics { get; set; }
    }
}
