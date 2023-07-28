using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1BLL.Services
{
    public class AddService : IAddService
    {
        private readonly ILogger<AddService> _logger;

        public AddService(ILogger<AddService> logger) => _logger = logger;

        public Task<int> AddAsync(int a, int b)
        {
            var res = a + b;
            _logger.LogInformation($"{a} + {b} = {res}");
            return Task.FromResult(a + b);
        }
    }
}
