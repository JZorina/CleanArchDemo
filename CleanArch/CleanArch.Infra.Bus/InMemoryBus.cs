using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus :IMediatorHandler
    {
        private readonly IMediator _meditaor;

        public InMemoryBus(IMediator mediator)
        {
            _meditaor = mediator;
        }

        public Task SendCommand <T>(T command) where T:Command
        {
            return _meditaor.Send(command);
        }
    }
}
