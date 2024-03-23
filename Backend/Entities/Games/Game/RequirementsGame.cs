﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Entities.Games.Game;

public class RequirementsGame
{
    [Key]
    public Guid RequirementsGameId { get; set; } = Guid.NewGuid();
    public string Minimum { get; set; }
    public string Recommended { get; set; }
}
