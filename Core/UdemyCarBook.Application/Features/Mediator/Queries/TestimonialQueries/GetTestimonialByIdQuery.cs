using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.TestimonialResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>//bu kısım cqrs'ten farklı
    {
        public int Id { get; set; }
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}
