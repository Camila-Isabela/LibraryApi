﻿namespace LibraryApi.Models;

public class UpdateBookDto
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    public decimal? Price { get; set; }
    public int? QuantityInStock { get; set; }
}
