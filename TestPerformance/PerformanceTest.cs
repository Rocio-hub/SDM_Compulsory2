using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating.Repository;

namespace TestPerformance
{
    [TestClass]
    public class PerformanceTest
    {
        private static IRatingRepository rr;

        [TestMethod]
        [Timeout(20000)]
        public void TestGetAverageRateFromReviewer()
        {
            rr.GetAverageRateFromReviewer(1);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetAverageRateOfMovie()
        {
            rr.GetAverageRateOfMovie(558634);
        }

        [TestMethod]
        [Timeout(25000)]
        public void TestGetMostProductiveReviewers()
        {
            rr.GetMostProductiveReviewers();
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetMoviesWithHighestNumberOfTopRates()
        {
            rr.GetMoviesWithHighestNumberOfTopRates();
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfRates()
        {
            rr.GetNumberOfRates(662870, 5);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfRatesByReviewer()
        {
            rr.GetNumberOfRatesByReviewer(331, 4);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfReviews()
        {
            rr.GetNumberOfReviews(90668);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfReviewsFromReviewer()
        {
            rr.GetNumberOfReviewsFromReviewer(199);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetReviewersByMovie()
        {
            rr.GetReviewersByMovie(1890591);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetTopMoviesByReviewer()
        {
            rr.GetTopMoviesByReviewer(12);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetTopRatedMovies()
        {
            rr.GetTopRatedMovies(3);
        }
    }
}
