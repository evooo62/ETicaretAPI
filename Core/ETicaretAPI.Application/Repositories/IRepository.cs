using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //T cinsinden birsey gonderdigimiz zaman dbset te class zorunlu kilindigi icin bizde bunu bildiriyoruz. Sana class gondericez.
    public interface IRepository<T> where T : BaseEntity

    {
        DbSet<T> Table { get; }
    }
}
