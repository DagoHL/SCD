﻿namespace SCD.Core.DataModels;

public class Album
{
    public bool Success { get; set; } = false;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public AlbumFile[]? Files { get; set; }
}