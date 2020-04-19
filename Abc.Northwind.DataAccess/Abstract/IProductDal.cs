using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        //Custom Operations
    }
}
