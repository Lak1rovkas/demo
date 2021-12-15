using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    interface ICup
    {
        string Refill();
        string Wash();

        string Type { get; set; }
        double Capacity { get; set; }
    }
}
