using Microsoft.AspNetCore.Mvc.Rendering;

namespace CO550_Project_Blazor.Models.Services
{
    public class FilmService
    {
        public static readonly List<Film> Films = new List<Film>()
        {
            new()
            {
                FilmID = 1,
                Title = "Top Gun: Maverick",
                ReleaseDate = "27/05/2022",
                Rating = "U",
                Director = "Jospeph Kosinski",
                Runtime = "2h 10m",
                Genre = "Action/Drama",
                Price = 5,
                ImageURL = "TopGunMaverick.jpg"
            },
            new()
            {
                FilmID = 2,
                Title = "Inception",
                ReleaseDate = "16/07/2010",
                Rating = "12",
                Director = "Christopher Nolan",
                Runtime = "2h 28m",
                Genre = "Sci-Fi",
                Price = 9,
                 ImageURL = "Inception.jpg"
            },
            new()
            {
                FilmID = 3,
                Title = "The Man from U.N.C.L.E",
                ReleaseDate = "14/08/2015",
                Rating = "12A",
                Director = "Guy Ritchie",
                Runtime = "1h 56m",
                Genre = "Action",
                Price = 9,
                 ImageURL = "TheManfromUNCLE.jpg"
            },
            new()
            {
                FilmID = 4,
                Title = "Black Adam",
                ReleaseDate = "21/10/2022",
                Rating = "12A",
                Director = "Jaume Collet-Serra",
                Runtime = "1h 38m",
                Genre = "Comedy",
                Price = 8,
                ImageURL = "BlackAdam.jpg"
            },
            new()
            {
                FilmID = 5,
                Title = "Jurassic World",
                ReleaseDate = "11/06/2015",
                Rating = "12A",
                Director = "Colin Trevvorrow",
                Runtime = "2h 4m",
                Genre = "Action/Adventure",
                Price = 7,
                 ImageURL = "JurassicWorld.jpg"
            },
            new()
            {
                FilmID = 6,
                Title = "Cloud 9",
                ReleaseDate = "28/02/2014",
                Rating = "15",
                Director = "Paul Hoen",
                Runtime = "1h 25m",
                Genre = "Romance",
                Price = 6,
                 ImageURL = "Cloud9.jpg"
            },
            new()
            {
                FilmID = 7,
                Title = "Guardians of the Galaxy",
                ReleaseDate = "31/07/2014",
                Rating = "12A",
                Director = "James Gunn",
                Runtime = "2h 2m",
                Genre = "Action",
                Price = 8,
                 ImageURL = "GuardiansOfTheGalaxy.jpeg"
            },
            new()
            {
                FilmID = 8,
                Title = "Bird Box",
                ReleaseDate = "21/08/2018",
                Rating = "18",
                Director = "Susanne Bier",
                Runtime = "2h 4m",
                Genre = "Horror",
                Price = 5,
                ImageURL = "Birdbox.jpg"
            },
            new()
            {
                FilmID = 9,
                Title = "Iron Man",
                ReleaseDate = "24/04/2008",
                Rating = "12A",
                Director = "Jon Favreau",
                Runtime = "2h 6m",
                Genre = "Action",
                Price = 9,
                 ImageURL = "IronMan.jpg"
            },
            new()
            {
                FilmID = 10,
                Title = "Scarface",
                ReleaseDate = "10/02/1984",
                Rating = "18",
                Director = "Brian De Palma",
                Runtime = "2h 50m",
                Genre = "Crime",
                Price = 6,
                 ImageURL = "Scarface.jpg"
            }

        };

    }
}
