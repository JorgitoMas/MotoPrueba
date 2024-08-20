using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moto.Domain;
using Moto.SDK.Error;
using Moto.Service.Common;

namespace Moto.Service.Service
{
    public class ServerError
    {
        public ServerError() { }
    }
    public class BaseService
    {
        internal static ErrorManager? _logger;
        internal readonly DBContext _context;
        internal readonly IMapper _mapper;

        public BaseService(ErrorManager logger, DBContext context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
        }

        public static OperationResponse<T> Error<T>(OperationExceptions error)
        {
            return new OperationResponse<T>(default, false, error);
        }

        public static OperationResponse<T> Error<T>(string code, string? message = null, Exception? exOrigin = default)
        {
            if (_logger != null)
            {
                if (exOrigin != default)
                {
                    _logger.LogError(exOrigin.Message, exOrigin);
                }
         
                if (!String.IsNullOrEmpty(message))
                {
                    _logger?.LogInfo(message);
                }
            }

            var ex = new OperationExceptions(code, string.Format(ErrorsMessages.GetMessage(code), message));
            //default aqui es nulo porque no esta implementado el serciveError, mirar como se hizo en Biblioteca
            return new OperationResponse<T>(default, false, ex);
        }

        public static OperationResponse<T> Ok<T>(T data) 
        {
            return new OperationResponse<T>(data);
        }

    }
}
