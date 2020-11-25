using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plana.Api.Services
{
    public class ServiceResponce<T>
    {
        public T Data { get; set; }
        public bool Seccess { get; set; } = true;
        public string Message { get; set; } = null;
    }
}
