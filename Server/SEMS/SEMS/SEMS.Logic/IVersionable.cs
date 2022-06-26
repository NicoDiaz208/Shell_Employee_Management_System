using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMS.Logic
{
    public interface IVersionable : IIdentifyable
    {
        byte[]? RowVersion { get; }
    }
}
