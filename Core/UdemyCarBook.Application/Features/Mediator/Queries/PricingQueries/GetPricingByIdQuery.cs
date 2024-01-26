using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.PricingResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery:IRequest<GetPricingByIdQueryResult>//bu kısım cqrs'ten farklı
    {
        public int Id { get; set; }
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
