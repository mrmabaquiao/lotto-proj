using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoProject.Domain
{
    public interface ILottoDataSource
    {
        IQueryable<Draw> Draws { get; }

    }
}
