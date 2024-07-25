using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Bases
{
    public class BasesExceptions : ApplicationException
    {
        public BasesExceptions()
        {
            
        }
        public BasesExceptions(string message) : base(message)
        {
            
        }
        
    }
}
