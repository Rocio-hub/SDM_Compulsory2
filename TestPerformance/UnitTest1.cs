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
        [Timeout(4000)]
        public void TestGetAverageRateFromReviewer()
        {
            IRatingRepository rr = new RatingRepository();
            rr.GetAverageRateFromReviewer(1);
        }

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetAverageRateOfMovie(int movie)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetMostProductiveReviewers()
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetMoviesWithHighestNumberOfTopRates()
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetNumberOfRates(int movie, int rate)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetNumberOfRatesByReviewer(int reviewer, int rate)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetNumberOfReviews(int movie)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetNumberOfReviewsFromReviewer(int reviewer)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetReviewersByMovie(int movie)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetTopMoviesByReviewer(int reviewer)
        //{
        //    throw new System.NotImplementedException();
        //}

        //[TestMethod]
        //[Timeout(4000)]
        //public void TestGetTopRatedMovies(int amount)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
