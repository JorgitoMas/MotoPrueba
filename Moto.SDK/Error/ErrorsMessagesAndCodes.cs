using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moto.SDK.Error
{
    public class ErrorsCodes
    {
        public const string C_000_MENSAJE_INVALIDO = "000_MENSAJE_INVALIDO";
        public const string C_S001_TOKEN_INVALIDO = "S001_TOKEN_INVALIDO";
        public const string C_S002_CLIENTID_INVALIDO = "S002_CLIENTID_INVALIDO";
        public const string C_S003_ENTITYID_INVALIDO = "S003_ENTITYID_INVALIDO";
        public const string C_002_CLIENTE_INACTIVO = "002_CLIENTE_INACTIVO";
        public const string C_003_TOKEN_INVALIDO = "003_TOKEN_INVALIDO";
        public const string C_009_ERROR_DUPLICATE = "009_ERROR_DUPLICATE";
        public const string C_013_ERROR_ONLY_MESSAGE = "013_ERROR_ONLY_MESSAGE";
        public const string C_999_ERROR_GENERICO = "999_ERROR_GENERICO";
    }

    public class ErrorsMessages
    {
        public static Dictionary<string, string> Dictionary = new Dictionary<string, string>
        {
            { "000_MENSAJE_INVALIDO", "El formato del cuerpo de la solicitud es inválido" },
            { "S001_TOKEN_INVALIDO", "El token es inválido" },
            { "S002_CLIENTID_INVALIDO", "El Id del Cliente es inválido" },
            { "S003_ENTITYID_INVALIDO", "El Id de la Entidad es inválido" },
            { "002_CLIENTE_INACTIVO", "El cliente está inactivo" },
            { "003_TOKEN_INVALIDO", "El token fue desactivado" },
            { "009_ERROR_DUPLICATE", "Ya existe un cliente con el correo ingresado" },
            { "013_ERROR_ONLY_MESSAGE", "{0}" },
            { "999_ERROR_GENERICO", "Ups!! Intentalo nuevamente en unos segundos"}
    };

        public static string GetMessage(string key)
        {
            return Dictionary.ContainsKey(key) ? Dictionary[key] : Dictionary[ErrorsCodes.C_999_ERROR_GENERICO];
        }
    }
}
