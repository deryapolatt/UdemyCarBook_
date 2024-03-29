﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Application.Interfaces;
using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllBlogsWithAuthors();
            return values.Select(x => new GetAllBlogsWithAuthorQueryResult

            {
                BlogID = x.BlogID,
                Title = x.Title,
                CoverImageURL = x.CoverImageURL,
                AuthorName = x.Author?.Name, // hata aldığın için null olabiliri ekledin
                CategoryName = x.Category?.Name,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
            }).ToList();
        }

    }


}


