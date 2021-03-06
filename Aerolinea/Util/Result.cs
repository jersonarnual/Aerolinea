using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Infraestructure.Util
{
    public class Result
    {
        public bool State { get; set; }
        public string Message { get; set; }
        public string MessageException { get; set; }
        public object Model { get; set; }
        public IEnumerable<object> ListModel { get; set; }
    }
}
