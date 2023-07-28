using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1BLL.Services
{
    public interface IAddService
    {
        public Task<int> AddAsync(int a, int b);
    }
}
