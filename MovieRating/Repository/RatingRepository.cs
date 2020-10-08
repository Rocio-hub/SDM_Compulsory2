using MovieRating.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieRating.Repository
{
    public class RatingRepository : IRatingRepository
    {
        public RatingRepository()
        {
            FillList();
        }

        private static List<Rating> _rtngLst = new List<Rating>();
        public int initOnlyOnce = 0;

        public void FillList()
        {
            if (initOnlyOnce == 0)
            {
                using (StreamReader r = new StreamReader("ratings.json"))
                {
                    string json = r.ReadToEnd();
                    _rtngLst = JsonConvert.DeserializeObject<List<Rating>>(json);
                }
                initOnlyOnce++;
            }
        }

        public double GetAverageRateFromReviewer(int reviewer)
        {
            int counter = 0;
            int sum = 0;

            foreach (var rate in _rtngLst)
            {
                if (reviewer == rate.Reviewer)
                {
                    sum += rate.Grade;
                    counter++;
                }
            }
            return (double)sum / counter;
        }

        public double GetAverageRateOfMovie(int movie)
        {
            int counter = 0;
            int sum = 0;

            foreach (var rate in _rtngLst)
            {
                if (movie == rate.Movie)
                {
                    sum += rate.Grade;
                    counter++;
                }
            }
            return (double)sum / counter;
        }

        public List<int> GetMostProductiveReviewers()
        {
            int first = 0;
            int second = 0;
            int firstGreater = 0;
            int secondGreater = 0;
            List<int> reviewersList = new List<int>();

            foreach (var rating in _rtngLst)
            {
                if (GetNumberOfReviewsFromReviewer(rating.Reviewer) > firstGreater)
                {
                    first = rating.Reviewer;
                    firstGreater = GetNumberOfReviewsFromReviewer(rating.Reviewer);
                }

                if (GetNumberOfReviewsFromReviewer(rating.Reviewer) > secondGreater && GetNumberOfReviewsFromReviewer(rating.Reviewer) < firstGreater)

                {
                    second = rating.Reviewer;
                    secondGreater = GetNumberOfReviewsFromReviewer(rating.Reviewer);
                }
            }
            reviewersList.Add(first);
            reviewersList.Add(second);
            return reviewersList;
        }

        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            List<Rating> orderedList = _rtngLst.OrderBy(o => o.Grade).ToList();
            //orderedList.Take(3);

            List<int> movieList = new List<int>();
            foreach (var rating in orderedList)
            {
                movieList.Add(rating.Movie);
            }
            return movieList;
        }

        public int GetNumberOfRates(int movie, int rate)
        {
            int counter = 0;

            foreach (var rating in _rtngLst)
            {
                if (rating.Movie == movie && rating.Grade == rate) counter++;
            }
            return counter;
        }

        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            int counter = 0;

            foreach (var rating in _rtngLst)
            {
                if (reviewer == rating.Reviewer && rate == rating.Grade) counter++;
            }
            return counter;
        }

        public int GetNumberOfReviews(int movie)
        {
            int counter = 0;

            foreach (var rate in _rtngLst)
            {
                if (rate.Movie == movie) counter++;
            }
            return counter;
        }

        public int GetNumberOfReviewsFromReviewer(int reviewer)
        {
            int counter = 0;
            foreach (Rating rtng in _rtngLst)
            {
                if (rtng.Reviewer == reviewer) counter++;
            }
            return counter;
        }

        public List<int> GetReviewersByMovie(int movie)
        {
            List<int> reviewersList = new List<int>();

            foreach (var rate in _rtngLst)
            {
                if (rate.Movie == movie)
                {
                    reviewersList.Add(rate.Reviewer);
                }
            }
            return reviewersList;
        }

        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            List<Rating> orderedList = _rtngLst.OrderByDescending(o => o.Grade).ToList();
            List<int> topRatedMovies = new List<int>();
            foreach (var rating in orderedList)
            {
                if (rating.Reviewer == reviewer)
                {
                    topRatedMovies.Add(rating.Movie);
                }

            }
            return topRatedMovies;
        }

        public List<int> GetTopRatedMovies(int amount)
        {
            List<Rating> orderedList = _rtngLst.OrderByDescending(o => o.Grade).ToList();
            orderedList.Take(amount);
            List<int> topRatedMovies = new List<int>();
            foreach (var rating in orderedList)
            {
                topRatedMovies.Add(rating.Movie);
            }
            return topRatedMovies;
        }
    }
}
