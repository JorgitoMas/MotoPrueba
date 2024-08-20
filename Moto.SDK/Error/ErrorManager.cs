using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


namespace Moto.SDK.Error
{
    public class ErrorManager
    {   ///<sumary>
        ///Logger para el manejo de los mensajes de erro
        ///<sumary>
        public readonly ILogger _logger;

        ///<sumary>
        ///Constructor
        ///<sumary>
        ///<param name="logger"></param>
        public ErrorManager(ILogger<ErrorManager> logger)
        {
            _logger = logger;
        }

        ///<sumary>
        ///Log un error y devuelve la exccepcion generada
        ///<sumary>
        public OperationExceptions LogError(string code, object data = null, Exception ex = null)
        {
            var opEx = new OperationExceptions(code, ErrorsMessages.GetMessage(code), ex);
            _logger.LogError(ex, $"{code} - {ErrorsMessages.GetMessage(code)}: Data{(data != null ? JsonConvert.SerializeObject(data) : String.Empty)}");
            return opEx;
        }

        public void LogWarning(string code, object data = null)
        {
            _logger.LogWarning($"{code} - {ErrorsMessages.GetMessage(code)}: Data{(data != null ? JsonConvert.SerializeObject(data) : String.Empty)}");
        }

        public void LogInfo(string code, object data = null)
        {
            _logger.LogInformation($"{code} - {ErrorsMessages.GetMessage(code)}: Data{(data != null ? JsonConvert.SerializeObject(data) : String.Empty)}");
        }

    }
}
