using CA_ImdbDataDbFirst.Repository;
using CA_ImdbDataDbFirst.Utils;

namespace CA_ImdbDataDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepository = new MovieRepository();
            while (true)
            {
                MainMenu.GetMainMenu();
                int secim = MainMenu.GetSelectionFromMainMenu();
                switch (secim)
                {
                    case 1:
                        movieRepository.GetMoviesByMinYear();
                        break;
                    case 2:
                        movieRepository.GetMoviesByMinYearAndRating();
                        break;
                    case 3:
                        movieRepository.GetMoviesWithRevenue();
                        break;
                    case 4:
                        movieRepository.GetDirectorsWithRevenue();
                        break;
                    case 5:
                        movieRepository.GetRandomMovie();
                        break;
                    case 6:
                        movieRepository.GetMoviesByDesc();
                        break;
                    case 7:
                        movieRepository.GetMoviesWithGenres();
                        break;
                    case 8:
                        movieRepository.GetMoviesByGenre();
                        break;
                    case 9:
                        movieRepository.GetMoviesWithDirector();
                        break;
                    case 10:
                        movieRepository.GetMoviesWithCasts();
                        break;
                }
            }
        }
    }
}