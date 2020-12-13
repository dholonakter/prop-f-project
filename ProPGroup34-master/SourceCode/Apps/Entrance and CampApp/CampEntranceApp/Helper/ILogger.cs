using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampEntranceApp
{
    public interface ILogger
    {
        void LogMessage(ErrorType errorType,string message);
    }
}
