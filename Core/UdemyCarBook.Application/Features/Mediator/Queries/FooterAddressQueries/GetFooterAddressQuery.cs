﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>//bu kısım cqrs'ten farklı
    {
    }
}
