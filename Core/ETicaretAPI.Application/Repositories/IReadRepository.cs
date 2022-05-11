using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //Read islemleri: Database den sorgu ile bir islem yapicaksan bu islemler read islemleridir.
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
    {
        //IQuerybal mantigini kullanicaz. Sebebi direk database sorgu atmasi ve performans acisindan onemli olmasi
        //IEnuirebul ise herseyi ram dan yonnettigi icin performans ileride performans problemi cikarabilir.

        IQueryable<T> GetAll(bool tracking =true);
        //Bool vermemizin sebebi sonucu true veya false donmesini istedigimiz icin.
        IQueryable<T> GetWhere(Expression<Func<T,bool>>method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T,bool>>method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
