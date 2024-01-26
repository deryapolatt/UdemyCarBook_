using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                CoverImageUrl = command.CoverImageUrl,
                BigImageURL = command.BigImageURL,
                Model = command .Model,
                Km = command.Km,
                Seat =      command.Seat,
                Transmission = command.Transmission,
                Fuel = command.Fuel,
                Luggage = command.Luggage,



            });
        }
    }
}
