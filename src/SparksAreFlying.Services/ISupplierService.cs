using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparksAreFlying.Services
{
    public interface ISupplierService
    {
        IEnumerable<Usage> ParseUsage(Stream stream);
    }
}
