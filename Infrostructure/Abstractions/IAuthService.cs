using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrostructure.Abstractions
{
    internal interface IAuthService
    {
        Task<string> loginasync(string username, string password);
    }
}
