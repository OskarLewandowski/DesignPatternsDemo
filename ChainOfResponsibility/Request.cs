using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Request
    {
        public string UserRole { get; set; }
        public int UserId { get; set; }
        public int EntityId { get; set; }
    }
}
