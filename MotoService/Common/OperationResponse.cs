using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moto.SDK.Error;

namespace Moto.Service.Common
{
    public class OperationResponse<T>
    {
        public bool Success { get; set; }
        public OperationExceptions Exception { get; set; }
        public T Data { get; set; }

        public OperationResponse(T data, bool success = true, OperationExceptions ex = null) 
        {
            Data = data;
            Success = success;
            Exception = ex;
        }
    }
}
