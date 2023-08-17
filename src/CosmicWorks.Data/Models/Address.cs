namespace CosmicWorks.Data.Models;

public sealed record Address(
    string Name,
    string Street,
    string City,
    string State,
    string ZipCode,
    string Type = "work"
);