using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moto.Service.Common
{
    public class IdResponse<T>
    {
        public T Id { get; set; }
        public string IdStr { get => Id.ToString(); }
        public bool IsNew() => object.Equals(Id, default(T));
        public IdResponse(T id) 
        {
            Id = id;
        }
    }
}
