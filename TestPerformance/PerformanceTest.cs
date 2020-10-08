using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating.Repository;

namespace TestPerformance
{
    [TestClass]
    public class UnitTest1
    {
        private static IRatingRepository ratingRepo;

        [ClassInitialize]
        public static void SetupRepo(TestContext tc)
        {
            ratingRepo = new RatingRepository();
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetAverageRateFromReviewer()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetAverageRateFromReviewer(1);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetAverageRateOfMovie()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetAverageRateOfMovie(558634);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetMostProductiveReviewers()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetMostProductiveReviewers();
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetMoviesWithHighestNumberOfTopRates()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetMoviesWithHighestNumberOfTopRates();
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfRates()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetNumberOfRates(662870, 5);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfRatesByReviewer()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetNumberOfRatesByReviewer(331, 4);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfReviews()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetNumberOfReviews(90668);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetNumberOfReviewsFromReviewer()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetNumberOfReviewsFromReviewer(199);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetReviewersByMovie()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetReviewersByMovie(1890591);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetTopMoviesByReviewer()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetTopMoviesByReviewer(12);
        }

        [TestMethod]
        [Timeout(20000)]
        public void TestGetTopRatedMovies()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetTopRatedMovies(3);
        }
    }
}
