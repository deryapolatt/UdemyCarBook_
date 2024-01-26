﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetAllBlogsWithAuthorQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int AuthorID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImageURL { get; set; }
        public int CategoryID { get; set; }
    }
}