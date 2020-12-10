using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softpayintegration
{
   public interface IAppHandler
    {
        Task<bool> LaunchApp(string packagename);
    }
}
