﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResult;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    //burası listemizin oluşacağı yer

    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>> //Mediatr'ın farklılık burada başlıyor adım 3 gibi düşünebilirsin
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetFooterAddressQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();
        }
    }
}
