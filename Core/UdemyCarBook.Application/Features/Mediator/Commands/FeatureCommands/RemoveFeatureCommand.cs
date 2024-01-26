using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand: IRequest //Cqrs'ten fakrlı 5.adım

    {
        public int Id { get; set; }
        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
