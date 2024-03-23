﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities.Movies;

public class CountryList
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Key { get; set; }
    public string Value { get; set; }
}
