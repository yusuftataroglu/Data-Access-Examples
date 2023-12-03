using CA_ImdbDataDbFirst.Abstract;
using CA_ImdbDataDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ImdbDataDbFirst.Repository
{
    public class MovieRepository : IMovie
    {
        ImdbDataDbContext context = new ImdbDataDbContext();



        public void GetMoviesByMinYear()
        {
            int year = 0;
            Console.Write("Minimum cikis yilini giriniz: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetMoviesByMinYear();
            }
            var movieList = context.Movies.Where(x => x.Year > year).OrderBy(x => x.Year).ToList();
            foreach (var item in movieList)
            {
                Console.WriteLine($"{item.Id} {item.Title} {item.Year}");
            }
        }

        public void GetMoviesByMinYearAndRating()
        {
            int year = 0;
            Console.Write("Minimum cikis yilini giriniz: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetMoviesByMinYearAndRating();
            }
            var movieList = context.Movies.Where(x => x.Year > year && x.Rating >= 75 && x.Rating <= 100).OrderByDescending(x => x.Rating).ToList();
            foreach (var item in movieList)
            {
                Console.WriteLine($"{item.Id} {item.Title} {item.Year} {item.Rating}");
            }
        }

        public void GetMoviesWithRevenue()
        {
            var filmListesi = context.Movies.Select(x => new
            {
                x.Id,
                x.Title,
                x.Year,
                x.Rating,
                x.RevenueMillions
            }).OrderByDescending(x => x.RevenueMillions).ToList();
            foreach (var item in filmListesi)
            {
                Console.WriteLine(item);
            }
        }

        public void GetDirectorsWithRevenue()
        {
            var yonetmenListesi = context.Movies
            .GroupBy(x => x.DirectorId)
            .Select(x => new
            {
                DirectorID = x.Key, //todo Director id yok, sor.
                TotalRevenue = x.Sum(movie => movie.RevenueMillions)
            })
            .OrderByDescending(x => x.TotalRevenue)
            .ToList();

            foreach (var item in yonetmenListesi)
            {
                Console.WriteLine($"DirectorName: {item.DirectorID}, TotalRevenue: {item.TotalRevenue}");
            }
        }

        public void GetRandomMovie()
        {
            Random rnd = new Random();
            Movie randomMovie = context.Movies.Find(rnd.Next(1, context.Movies.Count() + 1));
            Console.WriteLine($"ID: {randomMovie.Id} Title: {randomMovie.Title}");
        }

        public void GetMoviesByDesc()
        {
            Console.Write("Filmin konusunda geceni giriniz: ");
            string value = Console.ReadLine();
            var result = context.Movies.Where(x => x.Description.Contains(value)).ToList();
            if (result != null) //todo Null donmuyor, sor
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"ID: {item.Id} Title: {item.Title} Description: {item.Description}");
                }
            }
            else
            {
                Console.WriteLine("Boyle bir film bulunmamakta.");
            }
        }

        public void GetMoviesWithGenres()
        {
            var result = context.Movies.Select(x => new
            {
                x.Id,
                x.Title,
                x.Genres //todo MovieGenres tablosu yok, sor.
            }).OrderBy(x => x.Id).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void GetMoviesByGenre()
        {
            Console.Write("Filmin turunu giriniz: ");
            string value = Console.ReadLine();
            //todo sor, çoka çok ilişki 
        }

        public void GetMoviesWithDirector()
        {
            var result = context.Movies.Select(x => new
            {
                x.Title,
                x.Director.FullName
            }).OrderBy(x => x.FullName).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void GetMoviesWithCasts()
        {
            var result = context.Movies.Select(x=> new
            {
                x.Title,
                x.Casts.First().FullName //todo sor, first?
            }).OrderBy(x=>x.FullName).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
