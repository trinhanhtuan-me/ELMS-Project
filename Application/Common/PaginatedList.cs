using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public record PaginatedList<T>(
        int Total,
        List<T> Data
        );
}
