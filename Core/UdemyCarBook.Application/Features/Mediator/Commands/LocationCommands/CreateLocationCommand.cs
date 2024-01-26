using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class CreateLocationCommand: IRequest //cqrs'ten farklı 5.adım
    {
        public string Name { get; set; }
    }
}
