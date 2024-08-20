using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Moto.SDK.Error
{
    public class OperationExceptions : Exception
    {
        public OperationExceptionData Info { get; set; }
        public OperationExceptions(string code, string message, Exception ex = null) : base($"{code} - {message}", ex) 
        {
            Info = new OperationExceptionData
            {
                Code = code,
                Description = message
            };
        }
    }

    public class OperationExceptionData
    {
        [JsonProperty("codigo")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
}
