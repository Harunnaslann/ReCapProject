using ReCap.Core.DataAccess;
using ReCap.Core.DataAccess.EntityFramework;
using ReCap.DataAccess.Concrete.EntityFramework;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
