using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleSerach.Filter;

namespace VehicleSerach.Services
{
    public interface IUriService
    {
         Uri GetPageUri(PaginationFilter filter, string route);
    }
}
