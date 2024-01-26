using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.SocialMediaResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>//bu kısım cqrs'ten farklı
    {
        public int Id { get; set; }
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
