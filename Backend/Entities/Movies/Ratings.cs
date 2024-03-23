﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities.Movies;

public class Ratings
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string ImDbId { get; set; }
    public string Title { get; set; }
    public string FullTitle { get; set; }
    public string Type { get; set; }
    public string Year { get; set; }
    public string ImDb { get; set; }
    public string Metacritic { get; set; }
    public string TheMovieDb { get; set; }
    public string RottenTomatoes { get; set; }
    public string FilmAffinity { get; set; }
    public string ErrorMessage { get; set; }
}
