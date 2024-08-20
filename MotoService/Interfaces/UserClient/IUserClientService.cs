using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moto.Service.Common;
using Moto.Service.Models.Dtos.DtoRequest;

namespace Moto.Service.Interfaces.UserClient
{
    public interface IUserClientService
    {
        Task<OperationResponse<long>> Register(DtoRequestUserClientRegister user);
    }
}
