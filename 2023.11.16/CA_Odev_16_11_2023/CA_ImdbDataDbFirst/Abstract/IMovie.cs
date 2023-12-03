using CA_ImdbDataDbFirst.Models;

namespace CA_ImdbDataDbFirst.Abstract
{
    public interface IMovie
    {
        void GetMoviesByMinYear();
        void GetMoviesByMinYearAndRating();
        void GetMoviesWithRevenue();
        void GetDirectorsWithRevenue();
        void GetRandomMovie();
        void GetMoviesByDesc();
        void GetMoviesWithGenres();
        void GetMoviesByGenre();
        void GetMoviesWithDirector();
        void GetMoviesWithCasts();

    }
}
