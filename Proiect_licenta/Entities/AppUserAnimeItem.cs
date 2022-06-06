﻿using Proiect_licenta.Entities.Anime;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_licenta.Entities
{
    public class AppUserAnimeItem
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int AnimeId { get; set; }
        public Datum AnimeItem { get; set; }
    }
}