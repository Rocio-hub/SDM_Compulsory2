﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Entities
{
    public class Rating
    {
        public int Reviewer { get; set; }
        public int Movie { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
